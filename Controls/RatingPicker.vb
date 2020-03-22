Imports System.ComponentModel

<DefaultProperty("CurrentRating"), _
DefaultEvent("CurrentRatingChanged"), _
DefaultBindingProperty("CurrentRating")> _
Public Class RatingPickerControl
    Implements ISupportInitialize

    Private Const DEFAULTVALUE As Integer = -1

    Private m_Initializing As Boolean = False
    Private m_CurrentRating As Integer = DEFAULTVALUE

    Public Event CurrentRatingChanged As EventHandler

    <Bindable(True)> _
    Public Property CurrentRating() As Integer
        Get
            Return Me.m_CurrentRating
        End Get
        Set(ByVal value As Integer)
            If (value <> Me.m_CurrentRating) AndAlso Not (Me.m_Initializing) Then
                Me.m_CurrentRating = value
                RaiseEvent CurrentRatingChanged(Me, EventArgs.Empty)
                ShowNewRating(value)
            End If
        End Set
    End Property

    Private Function ShouldSerializeCurrentRating() As Boolean
        Return Not CBool(Me.m_CurrentRating <> DEFAULTVALUE)
    End Function

    Public Overrides Function ToString() As String
        Return Me.CurrentRating.ToString
    End Function

    Public Enum RatingPickerValue As Integer
        NotSet = -1
        Poor = 1
        BelowAverage = 2
        Average = 3
        AboveAverage = 4
        Excellent = 5
    End Enum

    Protected Friend Overridable Sub Star_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Star1.Click, Star2.Click, Star3.Click, Star4.Click, Star5.Click
        Dim currentStar As PictureBox = CType(sender, PictureBox)

        If Not Me.m_Initializing Then
            Select Case (currentStar.Name)
                Case Me.Star1.Name
                    Me.CurrentRating = RatingPickerValue.Poor
                Case Me.Star2.Name
                    Me.CurrentRating = RatingPickerValue.BelowAverage
                Case Me.Star3.Name
                    Me.CurrentRating = RatingPickerValue.Average
                Case Me.Star4.Name
                    Me.CurrentRating = RatingPickerValue.AboveAverage
                Case Me.Star5.Name
                    Me.CurrentRating = RatingPickerValue.Excellent
            End Select
        End If

    End Sub

    Protected Friend Overridable Sub Star_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Star1.MouseHover, Star2.MouseHover, Star3.MouseHover, Star4.MouseHover, Star5.MouseHover
        Dim hoverOverStar As PictureBox = CType(sender, PictureBox)

        If Not Me.m_Initializing Then
            Select Case (hoverOverStar.Name)
                Case Me.Star1.Name
                    Me.PreviewNewRating(RatingPickerValue.Poor)
                Case Me.Star2.Name
                    Me.PreviewNewRating(RatingPickerValue.BelowAverage)
                Case Me.Star3.Name
                    Me.PreviewNewRating(RatingPickerValue.Average)
                Case Me.Star4.Name
                    Me.PreviewNewRating(RatingPickerValue.AboveAverage)
                Case Me.Star5.Name
                    Me.PreviewNewRating(RatingPickerValue.Excellent)
            End Select
        End If

    End Sub

    Protected Friend Overridable Sub Star_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Star1.MouseLeave, Star2.MouseLeave, Star3.MouseLeave, Star4.MouseLeave, Star5.MouseLeave
        If Not Me.m_Initializing Then
            Me.ShowNewRating(Me.CurrentRating)
        End If

    End Sub

    Protected Friend Overridable Sub ShowNewRating(ByVal newRating As Integer)
        Dim notsetimage As Bitmap = My.Resources.star_empty
        Dim setimage As Bitmap = My.Resources.star_filled

        Select Case (newRating)
            Case RatingPickerValue.NotSet
                Me.Star1.Image = notsetimage
                Me.Star2.Image = notsetimage
                Me.Star3.Image = notsetimage
                Me.Star4.Image = notsetimage
                Me.Star5.Image = notsetimage
            Case RatingPickerValue.Poor
                Me.Star1.Image = setimage
                Me.Star2.Image = notsetimage
                Me.Star3.Image = notsetimage
                Me.Star4.Image = notsetimage
                Me.Star5.Image = notsetimage
            Case RatingPickerValue.BelowAverage
                Me.Star1.Image = setimage
                Me.Star2.Image = setimage
                Me.Star3.Image = notsetimage
                Me.Star4.Image = notsetimage
                Me.Star5.Image = notsetimage
            Case RatingPickerValue.Average
                Me.Star1.Image = setimage
                Me.Star2.Image = setimage
                Me.Star3.Image = setimage
                Me.Star4.Image = notsetimage
                Me.Star5.Image = notsetimage
            Case RatingPickerValue.AboveAverage
                Me.Star1.Image = setimage
                Me.Star2.Image = setimage
                Me.Star3.Image = setimage
                Me.Star4.Image = setimage
                Me.Star5.Image = notsetimage
            Case RatingPickerValue.Excellent
                Me.Star1.Image = setimage
                Me.Star2.Image = setimage
                Me.Star3.Image = setimage
                Me.Star4.Image = setimage
                Me.Star5.Image = setimage
            Case Else
                Me.Star1.Image = notsetimage
                Me.Star2.Image = notsetimage
                Me.Star3.Image = notsetimage
                Me.Star4.Image = notsetimage
                Me.Star5.Image = notsetimage
        End Select
    End Sub

    Protected Friend Overridable Sub PreviewNewRating(ByVal newRating As Integer)
        'currently same as ShowNewRating; in future one might want a 
        'custom image or behavior
        Me.ShowNewRating(newRating)
    End Sub

    Public Sub BeginInit() Implements System.ComponentModel.ISupportInitialize.BeginInit
        Me.m_Initializing = True

    End Sub

    Public Sub EndInit() Implements System.ComponentModel.ISupportInitialize.EndInit
        Me.m_Initializing = False
        Me.CurrentRating = Me.m_CurrentRating

        'Refresh display in case there was no change via the Set
        Me.ShowNewRating(Me.CurrentRating)
    End Sub
End Class
