Imports System.ComponentModel
''' <summary>
''' User control responsible for searching Amazon.com Web service for movie titles, and adding titles to the collection. 
''' </summary>
''' <remarks>
''' Click on the search button or enter search text to perform an online search.  
''' Select a valid movie title and Add To Collection to save the data locally.  
''' The simplified Amazon.com search class returns a generic BindingList of DVD objects.  The user control UI elements are 
''' data bound to the list of DVDs using the Data Source Object binding feature.  Adding the title to collection converts
''' the DVD object to the in-memory datatable format, which the rest of the application uses.  
''' </remarks>
Public Class SearchOnline

    ''' <summary>Calls Amazon.com Web service and binds dvd bindinglist result to the UI.  </summary>
    Private Sub PerformSearch()
        'object responsible for containing dvd search results
        Dim searchResults As New BindingList(Of DVD)

        'simple wrapper object responsible for handling requests and responses from the Amazon.com Web service
        Dim amazonService As New SimpleAmazonWS

        'show hour glass during the search to tell users that work is being done
        Me.Cursor = Cursors.WaitCursor

        Try
            'request search results from the Web service passing in the user's search criteria
            searchResults = amazonService.SearchDVDs(Me.SearchTextBox.Text)

            'data bind the search results to the form UI
            Me.DVDBindingSource.DataSource = searchResults
        Catch ex As Exception
            MsgBox(String.Format("There was a problem connecting to the Web service.  Please verify that you are connected to the Internet.  Additional details: {0}", ex.Message))
            My.Application.Log.WriteException(ex)
        Finally
            'set cursor back to the default now that work is done
            Me.Cursor = Cursors.Default
        End Try

        'tell the user how many results were found.  Use String.Format feature to concat strings in a Localization-friendly way
        Me.Label2.Text = String.Format("{0} results found.  ", searchResults.Count.ToString)
    End Sub

    ''' <summary>Adds the current movie selection to the local movie collection, and displays the ListDetails user control.  </summary>
    Private Sub AddCurrentToCollection()
        'try to add data to the collection
        Try
            'check boundary cases where DVD list is empty or there is no current selection
            If (Me.DVDBindingSource.Count > 0) AndAlso (Me.DVDBindingSource.Current IsNot Nothing) Then
                'object that stores the current DVD selection
                Dim currentDVD As DVD = CType(Me.DVDBindingSource.Current, DVD)

                'try to cache the image to the dvd object
                If Me.PictureBox1.Image IsNot Nothing Then
                    'try loading from picture box first
                    currentDVD.ImageCache = Me.PictureBox1.Image
                ElseIf currentDVD.ImageUrl <> "" Then
                    'else try from the source URL
                    Me.PictureBox1.Load(currentDVD.ImageUrl)
                    currentDVD.ImageCache = Me.PictureBox1.Image
                End If

                'convert custom DVD object to the datable / datarow format used by the application, and
                'add the datarow to the datatable
                My.Forms.MainForm.ListDetailsPart.DVDCollectionDataSet.DVDs.AddDVDsRow(currentDVD)

                'update display to show ListDetailsPart with new row selected
                My.Forms.MainForm.ListDetailsPart.DVDsBindingSource.MoveLast()
                My.Forms.MainForm.ShowListDetailsPart()
            Else
                MsgBox("No DVD is selected.  Please select a DVD before adding to collection.  ")
            End If

        Catch ex As Exception
            MsgBox("There was a problem adding this DVD to the collection.  ")
            My.Application.Log.WriteException(ex)
        End Try
    End Sub

    ''' <summary>Performs online search when button is clicked.  </summary>
    Private Sub SearchButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchButton1.Click
        Me.PerformSearch()
    End Sub

    ''' <summary>Performs online search when enter is pressed in the search textbox.  </summary>
    Private Sub SearchTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.PerformSearch()
        End If
    End Sub

    ''' <summary>Adds the current selection to the local collection when the button is pressed.  </summary>
    Private Sub AddToCollectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToCollectionButton.Click
        Me.AddCurrentToCollection()
    End Sub

    ''' <summary>Adds the current selection to the local collection when the DataGridView is double clicked.  </summary>
    Private Sub DVDDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DVDDataGridView.DoubleClick
        If Me.DVDBindingSource.Current IsNot Nothing Then
            Me.AddCurrentToCollection()
        End If
    End Sub
End Class
