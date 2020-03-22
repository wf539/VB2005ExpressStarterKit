Imports System.ComponentModel

''' <summary>
''' Simplified class responsible for making requests to Amazon.com Web service and returning results.  
''' </summary>
''' <remarks>
''' ***Online Web service features are not implemented in this version of the starter kit.  Please see the Getting Started documentation to learn how to download an updated version.  
''' </remarks>
Public Class SimpleAmazonWS

    ''' <summary>
    ''' Configures defaults for the search request
    ''' </summary>
    ''' <remarks>Some default values can be changed in the Settings designer without changing code.  </remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Simple search method that returns a list of DVD objects based on the search string argument. 
    ''' </summary>
    ''' <param name="searchString">dvd keyword to search for, e.g. name, actor, or UPC</param>
    ''' <returns>BindingList of DVD search results</returns>
    ''' <remarks></remarks>
    Public Function SearchDVDs(ByVal searchString As String) As BindingList(Of DVD)
        Throw New NotImplementedException("Online Web service features are not implemented in this version of the starter kit.  Please see the Getting Started documentation to learn how to download an updated version.  ")
    End Function


    ''' <summary>
    ''' Looks up refreshed data about a particular DVD based on a UPC string argument.  
    ''' </summary>
    ''' <param name="upc">UPC code of the DVD to look up</param>
    ''' <returns>First DVD object found with this matching UPC, or nothing if none were found</returns>
    ''' <remarks></remarks>
    Public Function RefreshDVDByUPC(ByVal upc As String) As DVD
        Throw New NotImplementedException("Online Web service features are not implemented in this version of the starter kit.  Please see the Getting Started documentation to learn how to download an updated version.  ")
    End Function

    ''' <summary>
    ''' Utility function to return Amazon's custom date formats into a .NET Date type
    ''' </summary>
    ''' <param name="amazonDate">Date string returned by Amazon.com's ProductInfo type</param>
    ''' <returns>Date type converted from custom string, or Date.MinValue if parameter is nothing</returns>
    ''' <remarks></remarks>
    Private Function AmazonDateFormatToDateString(ByVal amazonDate As String) As String
        ' Format to handle Amazon's convention for date strings; 0 means not set
        Dim expectedFormats As String() = {"d", "yyyymmdd", "yyyy0000", "yyyymm00", "yyyy00dd"}
        Dim myDate As Date
        If amazonDate IsNot Nothing Then
            myDate = DateTime.ParseExact(amazonDate, _
                                expectedFormats, _
                                My.Application.Culture, Globalization.DateTimeStyles.AllowWhiteSpaces)
        Else
            Return Nothing
        End If

        Return myDate.ToString("yyyy")
    End Function

End Class
