'Code behind for DVDCollectionDataset that defines user-owned utility functions for working with this dataset
'and interactions with the custom DVD object returned by Amazon.com
'Uses partial classes to compile one dataset/datatable type that combines designer code with user code.  
'All user owned code for the dataset/datatable should be added to this file.  

Partial Public Class DVDCollectionDataSet

    Partial Public Class DVDsDataTable

        ''' <summary>
        ''' Overrides default new row behavior to ensure that a unique ID is created for each record.  
        ''' </summary>
        ''' <remarks>Unique ID's are needed to properly look up rows and avoid conflicts with similar rows.  IDs will be GUIDs.  </remarks>
        Private Sub dvdsDataTable_TableNewRow(ByVal sender As Object, ByVal e As System.Data.DataTableNewRowEventArgs) Handles Me.TableNewRow
            Dim newDVDRow As DVDsRow = TryCast(e.Row, DVDsRow)
            If newDVDRow IsNot Nothing Then
                newDVDRow.ID = Guid.NewGuid.ToString
                newDVDRow.Title = "[New row - select to enter details]"
            End If
        End Sub

        ''' <summary>
        ''' Overload that adds a DVD row to the datatable by passing in a custom DVD object.  
        ''' </summary>
        ''' <param name="myDVD">Custom DVD object that should be converted and added to the datatable</param>
        Public Overloads Sub AddDvdsRow(ByVal myDVD As DVD)
            Me.AddDVDsRow(Me.DVDsRowFromDVDObject(myDVD))
        End Sub

        ''' <summary>
        ''' Utility function to return a new DVDRow object converted from a custom DVD object.  
        ''' </summary>
        ''' <param name="myDvd">Custom DVD object to be converted to DVDRow.  </param>
        ''' <returns>New DVDRow object initialized by the DVD object parameter.  </returns>
        ''' <remarks>New DVDRow will be created in the context of this particular datatable instance.  </remarks>
        Public Function DVDsRowFromDVDObject(ByVal myDvd As DVD) As DVDCollectionDataSet.DVDsRow
            'objects used to store new row value 
            Dim dvdRow As DVDCollectionDataSet.DVDsRow

            'create a new row in the context of this datatable: "Me"
            dvdRow = Me.NewDVDsRow()

            'try to convert the DVD object to a DVDRow
            Try
                With dvdRow
                    'do copy of simple values
                    .Title = myDvd.Title
                    .Actors = myDvd.Actors
                    .Director = myDvd.Directors
                    .Rated = myDvd.Rating
                    .YearReleased = myDvd.ReleasedDate
                    .UPC = myDvd.UPC
                    .ImageLink = myDvd.ImageUrl
                    .WebPageLink = myDvd.WebPageUrl
                    .Description = myDvd.Description

                    'initialize user-set fields; these are not converted from input
                    .MyRating = -1
                    .Comments = ""
                    .Genre = ""

                    'do more problematic conversions:
                    '

                    'convert length value from string to integer
                    If (myDvd.RunningTime.Length > 0) Then
                        .Length = CInt(myDvd.RunningTime)
                    Else
                        .Length = 0
                    End If

                    'convert image to Byte array to be saved in database
                    If myDvd.ImageCache IsNot Nothing Then
                        Using memStream As New System.IO.MemoryStream()
                            myDvd.ImageCache.Save(memStream, myDvd.ImageCache.RawFormat)

                            .ImageBinary = memStream.GetBuffer()
                        End Using
                    End If

                End With
            Catch ex As Exception
                My.Application.Log.WriteEntry("An error occurred trying to convert DVD object to DVDTableRow. ")
                My.Application.Log.WriteException(ex)
            End Try

            Return dvdRow
        End Function

    End Class
End Class
