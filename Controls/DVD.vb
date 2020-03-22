Imports System.Collections.Generic

''' <summary>
''' Represents DVD title.  
''' </summary>
''' <remarks>SimpleAmazon Web service class returns a generic list of these DVD classes.  </remarks>
<Serializable()> Public Class DVD

    Private m_UPC As String = ""
    Private m_Title As String = ""
    Private m_Description As String = ""
    Private m_Actors As String() = New String() {}
    Private m_Directors As String() = New String() {}
    Private m_Rating As String = ""
    Private m_RunningTime As String = ""
    Private m_ReleasedDate As String = ""
    Private m_WebPageUrl As String = ""
    Private m_ImageUrl As String = ""
    Public ImageCache As Bitmap = Nothing

    Public Sub New()

    End Sub

    Public Sub New(ByVal title As String, ByVal upc As String, ByVal description As String)
        m_UPC = CheckString(upc)
        m_Title = CheckString(title)
        m_Description = CheckString(description)
    End Sub

    Public Sub New(ByVal title As String, ByVal upc As String, ByVal description As String, ByVal actors As String(), ByVal directors As String(), ByVal rating As String, ByVal runningtime As String, ByVal releasedDate As String, ByVal webPageUrl As String, ByVal imageUrl As String)
        m_UPC = CheckString(upc)
        m_Title = CheckString(title)
        m_Description = CheckString(description)
        m_Actors = actors
        m_Directors = directors
        m_Rating = CheckString(rating)
        m_RunningTime = CheckString(runningtime)
        m_ReleasedDate = CheckString(releasedDate)
        m_WebPageUrl = CheckString(webPageUrl)
        m_ImageUrl = CheckString(imageUrl)
    End Sub

    Public Sub New(ByVal title As String, ByVal upc As String, ByVal description As String, ByVal actors As String, ByVal directors As String, ByVal rating As String, ByVal runningtime As String, ByVal releasedDate As String, ByVal webPageUrl As String, ByVal imageUrl As String)
        m_UPC = CheckString(upc)
        m_Title = CheckString(title)
        m_Description = CheckString(description)
        m_Actors(0) = actors
        m_Directors(0) = directors
        m_Rating = CheckString(rating)
        m_RunningTime = CheckString(runningtime)
        m_ReleasedDate = CheckString(releasedDate)
        m_WebPageUrl = CheckString(webPageUrl)
        m_ImageUrl = CheckString(imageUrl)
    End Sub

    Public ReadOnly Property UPC() As String
        Get
            Return Me.m_UPC
        End Get
    End Property

    Public ReadOnly Property Title() As String
        Get
            Return m_Title
        End Get
    End Property

    Public ReadOnly Property Description() As String
        Get
            Return m_Description
        End Get
    End Property

    Public ReadOnly Property Actors() As String
        Get
            Dim singleString As String = ""
            Try
                If Me.m_Actors IsNot Nothing Then
                    For Each part As String In Me.m_Actors
                        If singleString = "" Then
                            singleString = part
                        Else
                            If part IsNot Nothing Then singleString = singleString & ";" & part
                        End If
                    Next
                End If
            Catch ex As Exception
                My.Application.Log.WriteException(ex)
            End Try

            Return singleString
        End Get
    End Property

    Public ReadOnly Property Directors() As String
        Get
            Dim singleString As String = ""
            Try
                If Me.m_Directors IsNot Nothing Then
                    For Each part As String In Me.m_Directors
                        If singleString = "" Then
                            singleString = part
                        Else
                            If part IsNot Nothing Then singleString = singleString & ";" & part
                        End If
                    Next
                End If

            Catch ex As Exception
                My.Application.Log.WriteException(ex)
            End Try

            Return singleString
        End Get
    End Property

    Public Property ImageUrl() As String
        Get
            Return Me.m_ImageUrl
        End Get
        Set(ByVal value As String)
            m_ImageUrl = value
        End Set
    End Property

    Public ReadOnly Property Rating() As String
        Get
            Return Me.m_Rating
        End Get
    End Property

    Public ReadOnly Property ReleasedDate() As String
        Get
            Return Me.m_ReleasedDate
        End Get

    End Property


    Public ReadOnly Property RunningTime() As String
        Get
            Return Me.m_RunningTime
        End Get
    End Property


    Public ReadOnly Property WebPageUrl() As String
        Get
            Return Me.m_WebPageUrl
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0} {1}", Me.m_Title, Me.m_ReleasedDate)
    End Function

    ''' <summary>
    ''' Utility Function that converts null strings to the empty string.
    ''' </summary>
    ''' <param name="OriginalValue">The string to check against Nothing.</param>
    ''' <returns>If the original value is nothing, returns the empty string.  Else, returns the original value.</returns>
    ''' <remarks></remarks>
    Private Shared Function CheckString(ByVal OriginalValue As String) As String
        If (OriginalValue Is Nothing) Then
            Return ""
        Else
            Return OriginalValue
        End If
    End Function
End Class
