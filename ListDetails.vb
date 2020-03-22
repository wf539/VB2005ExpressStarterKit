''' <summary>
''' User control responsible viewing, managing, and live editing the details of the movie collection.  
''' </summary>
''' <remarks>
''' Movies are added programatically by the SearchOnline control or are added manually after pressing the 
''' Add button.  Movies can be live edited by selecting a value in the grid.  They can be deleted by selecting and pressing 
''' Delete button.  Press the View Online button to visit the Amazon.com Web site.  Press Refresh button 
''' to refresh data fields with live information from the Amazon.com Web service.  
''' Movies are read from and written to MovieDatabase.mdf.  It is recommended that movie information is 
''' refreshed regularly.  
''' </remarks>
Public Class ListDetails

    'Represents the in memory representation of the movie collection.  Type is defined in DVDCollectionDataSet.xsd file.  
    'This variable is defined again locally as WithEvents to make it easier to handle events in the code editor.  
    Dim WithEvents dvdsDataTable As $safeprojectname$.DVDCollectionDataSet.DVDsDataTable

    Dim WithEvents hostingForm As Form

    'Control object responsible for rating movie titles.  
    'Workaround: project cannot dynamically build this custom control type
    '                      after using New Project wizard; the control instance is created and sited at runtime instead of 
    '                      adding to design surface.  
    Friend WithEvents RatingPickerControl1 As RatingPickerControl

    'Gets turned on, while database updates are occuring.
    Dim IsUpdating As Boolean = False

    ''' <summary>
    ''' Initializes this control and loads data.    
    ''' </summary>
    ''' <remarks>
    ''' All movie titles in the collection are loaded into the in-memory datatable;  
    ''' The control monitors for changes to the datatable and auto saves changes made to each field. 
    ''' </remarks>
    Private Sub ListDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dynamically create rating picker control and site on the form
        InitRatingPickerControl()

        'reference DVDs datatable on the design surface
        Me.dvdsDataTable = Me.DVDCollectionDataSet.DVDs

        'load data from database
        If Me.LoadData() = 0 Then
            ' If no rows were available, create a new row so users can start entering a new dvd
            Me.DVDsBindingSource.AddNew()
        End If

        Me.TitleTextBox.Select()
    End Sub

    Private Sub dt_rowChanged(ByVal sender As Object, ByVal e As Data.DataRowChangeEventArgs) Handles dvdsDataTable.RowChanged
        If Me.IsUpdating Then
            Return
        End If
        Dim dvdDataRow As DVDCollectionDataSet.DVDsRow = CType(e.Row, DVDCollectionDataSet.DVDsRow)
        If dvdDataRow IsNot Nothing Then
            Me.SaveData()
        End If
    End Sub

    ''' <summary>
    ''' Creates a new movie in the collection when Add button is clicked.  
    ''' </summary>
    ''' <remarks>It is preferable to call AddNew from the dataconnector to keep data binding between the control and datatable in sync.  </remarks>
    Private Sub AddTitleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTitleButton.Click
        Me.DVDsBindingSource.AddNew()
    End Sub

    ''' <summary>Deletes the currently selected movie.  </summary>
    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Me.DeleteCurrent()
    End Sub

    ''' <summary>Applies the user-specified filter when clicked.  </summary>
    Private Sub FilterButton_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        Me.ApplyTextboxFilter()
    End Sub

    ''' <summary>Applies the user-specified filter when filter string is entered.  </summary>
    Private Sub FilterTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FilterTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.ApplyTextboxFilter()
        End If
    End Sub

    ''' <summary>Resets DataConnector to be unfiltered when button is clicked.  </summary>
    Private Sub ShowAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllImage.Click, ShowAllButton.Click
        Me.DVDsBindingSource.Filter = ""
    End Sub

    ''' <summary>
    ''' Refreshes the current movie selection with data from the Amazon.com Web service after prompting the user.  
    ''' </summary>
    ''' <remarks>
    ''' Uses UPC value to fetch the movie title from the Web service, and merges/overwrites the 
    ''' existing data.  Comments and MyRating fields are preserved as a special case.  
    ''' </remarks>
    Private Sub RefreshOnlineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshOnlineButton.Click
        'prompt the user to refresh and store the result
        Dim yesNoResult As MsgBoxResult = MsgBox("This feature will potentially overwrite your changes.  Do you want to proceed? ", MsgBoxStyle.YesNo, "Refresh data from online Web service?")

        'if yes, then begin refresh process
        If yesNoResult = MsgBoxResult.Yes Then
            'object used to call Amazon.com Web service
            Dim amazonService As New SimpleAmazonWS

            'objects used to store search result
            Dim refreshedDVD As DVD
            Dim refreshedDVDRow As $safeprojectname$.DVDCollectionDataSet.DVDsRow

            Try
                'boundary check: make sure movie datatable is not empty
                If Me.DVDsBindingSource.Count > 0 Then
                    'gets the current movie selection and converts to a typed movie row object
                    Dim rowView As DataRowView = CType(Me.DVDsBindingSource.Current, DataRowView)
                    Dim dvdRow As DVDCollectionDataSet.DVDsRow = CType(rowView.Row, $safeprojectname$.DVDCollectionDataSet.DVDsRow)

                    ' check to see if UPC value is null
                    If (Not dvdRow.IsUPCNull) AndAlso dvdRow.UPC <> "" Then

                        'variables to store and preserve custom comment and rating values
                        Dim currentComments As String = dvdRow.Comments
                        Dim currentRating As Integer = dvdRow.MyRating

                        'get updated DVD object from Web service
                        refreshedDVD = amazonService.RefreshDVDByUPC(dvdRow.UPC)

                        'update cached image
                        Me.BoxArtPictureBox.Load(refreshedDVD.ImageUrl)
                        refreshedDVD.ImageCache = Me.BoxArtPictureBox.Image

                        'convert DVD to dvdRow
                        refreshedDVDRow = Me.DVDCollectionDataSet.DVDs.DVDsRowFromDVDObject(refreshedDVD)

                        'set the same ID as original row so row look up in the in-memory datatable succeeds
                        refreshedDVDRow.ID = dvdRow.ID

                        'restore/merge back the custom comment and rating values
                        refreshedDVDRow.Comments = currentComments
                        refreshedDVDRow.MyRating = currentRating

                        'merge dvdRow with matching row
                        Me.DVDCollectionDataSet.DVDs.LoadDataRow(refreshedDVDRow.ItemArray, LoadOption.Upsert)
                    End If
                End If

            Catch ex As Exception
                MsgBox(String.Format("There was a problem refreshing the data from the online Web service: {0}", ex.Message))
                My.Application.Log.WriteException(ex)
            End Try
        End If

    End Sub

    ''' <summary>
    ''' Navigates the to Amazon.com Web page for the current movie selection in an external browser after prompting the user.  
    ''' </summary>
    ''' <remarks>The user should see the hyperlink before starting the browser process and navigating to the URL.  </remarks>
    Private Sub ViewOnlineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewOnlineButton.Click

        'boundary check: make sure movie datatable is not empty
        If Me.DVDsBindingSource.Count > 0 Then
            'gets the current movie selection and converts to a typed movie row object
            Dim rowView As DataRowView = CType(Me.DVDsBindingSource.Current, DataRowView)
            Dim dvdRow As DVDCollectionDataSet.DVDsRow = CType(rowView.Row, $safeprojectname$.DVDCollectionDataSet.DVDsRow)

            'variable to store the Web page URL value
            Dim webLink As String = ""

            'check for null before accessing WebPageLink property
            If Not dvdRow.IsWebPageLinkNull Then webLink = dvdRow.WebPageLink

            'prompts to see if end user trusts URL and stores the prompt result value
            Dim msgText As String = String.Format("About to view this URL in an external browser: '{0}'. Is it safe to proceed?", webLink)
            Dim yesNoResult As MsgBoxResult = MsgBox(msgText, MsgBoxStyle.YesNo, "OK to browse?")

            'start the URL path if the user approves the prompt
            If (yesNoResult = MsgBoxResult.Yes) AndAlso (webLink <> "") Then
                Process.Start(webLink)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Prompts user for file to import when Clicked.  
    ''' </summary>
    Private Sub ImportButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ImportButton.Click
        Me.OpenFileDialog1.ShowDialog()
    End Sub

    ''' <summary>
    ''' Imports image provided by user when user clicks OK to open file prompt.   
    ''' </summary>
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.ImportImage(Me.OpenFileDialog1.FileName)
    End Sub

    ''' <summary>
    ''' Loads movie collection data.  
    ''' </summary>
    ''' <returns>Positive integer for number of rows loaded; 0 if no rows are loaded.  </returns>
    ''' <remarks>Loads movie collection data into the in-memory datatable</remarks>
    Friend Function LoadData() As Integer
        Dim rowsLoaded As Integer = 0

        'Try to fill the datatable with the query of all movies.
        'Note: If the database contains a large number of movies you'll likely want to add a query to the 
        'TableAdapter and only fill a subset of the movies in the database into memory.
        Try
            Me.IsUpdating = True
            rowsLoaded = Me.DVDsTableAdapter.Fill(Me.DVDCollectionDataSet.DVDs)
        Catch ex As Exception
            MsgBox(String.Format("There was a problem loading data: {0}", ex.Message))
            My.Application.Log.WriteException(ex)
        Finally
            Me.IsUpdating = False
        End Try

        Return rowsLoaded
    End Function

    ''' <summary>
    ''' Saves changes made to movie collection data.  
    ''' </summary>
    ''' <returns>Positive integer for number of rows updated in database; 0 if no rows are updated.  </returns>
    ''' <remarks>Saves the changes from in-memory datatable and bound UI.  </remarks>
    Friend Function SaveData() As Integer
        If IsUpdating Then
            Return 0
        End If
        Dim rowsSaved As Integer = 0

        'try to get changes and save to database
        Try
            'only push update to database if changes are detected
            If Me.DVDCollectionDataSet.HasChanges Then
                IsUpdating = True
                rowsSaved = Me.DVDsTableAdapter.Update(Me.DVDCollectionDataSet.DVDs)
            End If
        Catch ex As Exception
            MsgBox(String.Format("There was a problem saving data: {0}", ex.Message))
            My.Application.Log.WriteException(ex)
        Finally
            IsUpdating = False
        End Try
        Return rowsSaved
    End Function

    ''' <summary>
    ''' Applies filter over the in-memory movie records using the user-specified input in the text box.  
    ''' </summary>
    ''' <remarks>DataConnector object's Filter property is applied to all controls bound to the DataConnector. </remarks>
    Private Sub ApplyTextboxFilter()
        Try
            'sets filter string WHERE clause in the form "Where COLUMNNAME like '@FilterText'"
            Me.DVDsBindingSource.Filter = _
                  String.Format("{0} like '%{1}%'", _
                                Me.DVDCollectionDataSet.DVDs.TitleColumn.ColumnName, _
                                Me.FilterTextBox.Text)
        Catch
        End Try
    End Sub

    ''' <summary>Deletes the currently selected movie after prompting the user.  </summary>
    Friend Sub DeleteCurrent()
        'check for boundaries before performing delete: datatable is empty, or there is no selection
        If (Me.DVDsBindingSource.Count > 0) AndAlso (Me.DVDsBindingSource.Current IsNot Nothing) Then
            'convert generic Current object returned by DataConnector to the typed movie row object
            Dim rowView As DataRowView = CType(Me.DVDsBindingSource.Current, DataRowView)
            Dim dvdRow As DVDCollectionDataSet.DVDsRow = CType(rowView.Row, $safeprojectname$.DVDCollectionDataSet.DVDsRow)

            'string representing the friendly name of the current movie to be deleted
            Dim title As String = "[No Title]"

            'use movie title property in the typed row object if it contains valid data
            If (Not dvdRow.IsTitleNull) AndAlso (dvdRow.Title IsNot Nothing) Then title = dvdRow.Title

            'text displayed in a prompt to the user before deleting
            Dim msgText As String = String.Format("Are you sure you want to permanently delete {0} from your collection? ", title)

            'display Yes/No prompt to the user and store the result
            Dim result As MsgBoxResult = MsgBox(msgText, MsgBoxStyle.YesNo, "OK to delete?")

            'remove the current movie if the user accepts the prompt
            If result = MsgBoxResult.Yes Then
                Me.DVDsBindingSource.RemoveCurrent()
            End If

            ' Make sure we always have a row available
            If DVDsBindingSource.Count = 0 Then
                Me.DVDsBindingSource.AddNew()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Initializes the rating picker control used on this user control.  
    ''' </summary>
    ''' <remarks>
    ''' Called by ListDetails.Load event.  This special initialization code is not required if the 
    ''' RatingPickerControl is built and referenced in a separate control library.  
    ''' </remarks>
    Private Sub InitRatingPickerControl()
        'create rating picker control object and site it on the parent user control
        Me.RatingPickerControl1 = New RatingPickerControl
        Me.DVDDetailsPanel.Controls.Add(Me.RatingPickerControl1)

        'set default properties and data binding
        CType(Me.RatingPickerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RatingPickerControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RatingPickerControl1.BackColor = System.Drawing.Color.Transparent
        Me.RatingPickerControl1.CurrentRating = -1
        Me.RatingPickerControl1.DataBindings.Add("CurrentRating", Me.DVDsBindingSource, "MyRating", True, DataSourceUpdateMode.OnPropertyChanged)
        Me.RatingPickerControl1.Location = New System.Drawing.Point(128, 388)
        Me.RatingPickerControl1.Name = "RatingPickerControl1"
        Me.RatingPickerControl1.Size = New System.Drawing.Size(80, 16)
        Me.RatingPickerControl1.TabIndex = 7
        CType(Me.RatingPickerControl1, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub

    ''' <summary>
    ''' Imports image value into datatable from file provided by user.  
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ImportImage(ByVal filename As String)
        Try
            'check for boundaries before performing delete: datatable is empty, or there is no selection
            If Me.DVDsBindingSource.Current IsNot Nothing Then
                'convert generic Current object returned by DataConnector to the typed movie row object
                Dim rowView As DataRowView = CType(Me.DVDsBindingSource.Current, DataRowView)
                Dim dvdRow As DVDCollectionDataSet.DVDsRow = CType(rowView.Row, $safeprojectname$.DVDCollectionDataSet.DVDsRow)

                'open file as Readonly from file system, copy bytes, and assign to the image property of the current row
                dvdRow.ImageBinary = My.Computer.FileSystem.ReadAllBytes(filename)

                Me.DVDsBindingSource.ResetCurrentItem()
            End If

        Catch ex As Exception
            MsgBox(String.Format("There was a problem loading the image: {0}", ex.Message))
            My.Application.Log.WriteException(ex)
        End Try
    End Sub

    Private Sub hostingForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        Try
            'call EndEdit to capture all changes made in the UI
            Me.DVDsBindingSource.EndEdit()
        Catch ex As Exception
            MsgBox(String.Format("There was a problem saving data: {0}", ex.Message))
            My.Application.Log.WriteException(ex)
        End Try

        ' when the parent form is closing, be sure to save the data on this control
        Me.SaveData()
    End Sub

    Private Sub ListDetails_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        ' If the parent form for this user control ever changes we need to reset the form.Closed event handler for the new parent form
        If hostingForm IsNot Nothing Then
            RemoveHandler hostingForm.FormClosed, AddressOf hostingForm_FormClosed
        End If
        Me.hostingForm = Me.ParentForm
        AddHandler hostingForm.FormClosed, AddressOf hostingForm_FormClosed

    End Sub

    Private Sub TitleTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleTextBox.Click
        If Me.TitleTextBox.Text = "[New row - select to enter details]" Then
            Me.TitleTextBox.SelectAll()
        End If
    End Sub
End Class
