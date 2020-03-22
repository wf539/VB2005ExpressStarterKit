<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListDetails
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DVDDetailsPanel = New System.Windows.Forms.Panel
        Me.ImportButton = New System.Windows.Forms.Button
        Me.DetailsLabel = New System.Windows.Forms.Label
        Me.YearReleasedLabel1 = New System.Windows.Forms.Label
        Me.BoxArtPictureBox = New System.Windows.Forms.PictureBox
        Me.MinutesLabel = New System.Windows.Forms.Label
        Me.YearDisplay = New System.Windows.Forms.Label
        Me.TitleDisplay = New System.Windows.Forms.Label
        Me.MyRatingLabel = New System.Windows.Forms.Label
        Me.UPCLabel = New System.Windows.Forms.Label
        Me.UPCTextBox = New System.Windows.Forms.TextBox
        Me.RatedLabel = New System.Windows.Forms.Label
        Me.LengthLabel = New System.Windows.Forms.Label
        Me.DirectorLabel = New System.Windows.Forms.Label
        Me.DirectorTextBox = New System.Windows.Forms.TextBox
        Me.CommentsLabel = New System.Windows.Forms.Label
        Me.CommentsTextbox = New System.Windows.Forms.TextBox
        Me.DescriptionLabel = New System.Windows.Forms.Label
        Me.DescriptionTextbox = New System.Windows.Forms.TextBox
        Me.TitleLabel = New System.Windows.Forms.Label
        Me.TitleTextBox = New System.Windows.Forms.TextBox
        Me.YearReleasedDateTimePicker = New System.Windows.Forms.TextBox
        Me.RatedComboBox = New System.Windows.Forms.ComboBox
        Me.LengthNumericUpDown = New System.Windows.Forms.TextBox
        Me.YearReleasedTextbox = New System.Windows.Forms.TextBox
        Me.ViewOnlineButton = New System.Windows.Forms.Button
        Me.RefreshOnlineButton = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.AddTitleButton = New System.Windows.Forms.Button
        Me.LookLabel = New System.Windows.Forms.Label
        Me.FilterTextBox = New System.Windows.Forms.TextBox
        Me.ShowAllImage = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.FilterButton = New System.Windows.Forms.Button
        Me.ShowAllButton = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YearReleased = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Director = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MyRating = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Actors = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Length = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UPC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImageLink = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WebPageLink = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Genre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DVDsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DVDCollectionDataSet = New $safeprojectname$.DVDCollectionDataSet
        Me.DVDsTableAdapter = New $safeprojectname$.DVDCollectionDataSetTableAdapters.DVDsTableAdapter
        Me.DVDDetailsPanel.SuspendLayout()
        CType(Me.BoxArtPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVDsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVDCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DVDDetailsPanel
        '
        Me.DVDDetailsPanel.BackColor = System.Drawing.Color.Transparent
        Me.DVDDetailsPanel.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.panel_dvdInfo_noTxt
        Me.DVDDetailsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DVDDetailsPanel.Controls.Add(Me.ImportButton)
        Me.DVDDetailsPanel.Controls.Add(Me.DetailsLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.YearReleasedLabel1)
        Me.DVDDetailsPanel.Controls.Add(Me.BoxArtPictureBox)
        Me.DVDDetailsPanel.Controls.Add(Me.MinutesLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.YearDisplay)
        Me.DVDDetailsPanel.Controls.Add(Me.TitleDisplay)
        Me.DVDDetailsPanel.Controls.Add(Me.MyRatingLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.UPCLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.UPCTextBox)
        Me.DVDDetailsPanel.Controls.Add(Me.RatedLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.LengthLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.DirectorLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.DirectorTextBox)
        Me.DVDDetailsPanel.Controls.Add(Me.CommentsLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.CommentsTextbox)
        Me.DVDDetailsPanel.Controls.Add(Me.DescriptionLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.DescriptionTextbox)
        Me.DVDDetailsPanel.Controls.Add(Me.TitleLabel)
        Me.DVDDetailsPanel.Controls.Add(Me.TitleTextBox)
        Me.DVDDetailsPanel.Controls.Add(Me.YearReleasedDateTimePicker)
        Me.DVDDetailsPanel.Controls.Add(Me.RatedComboBox)
        Me.DVDDetailsPanel.Controls.Add(Me.LengthNumericUpDown)
        Me.DVDDetailsPanel.Controls.Add(Me.YearReleasedTextbox)
        Me.DVDDetailsPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVDDetailsPanel.ForeColor = System.Drawing.Color.White
        Me.DVDDetailsPanel.Location = New System.Drawing.Point(320, 64)
        Me.DVDDetailsPanel.Name = "DVDDetailsPanel"
        Me.DVDDetailsPanel.Size = New System.Drawing.Size(577, 414)
        Me.DVDDetailsPanel.TabIndex = 4
        '
        'ImportButton
        '
        Me.ImportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImportButton.BackColor = System.Drawing.Color.Transparent
        Me.ImportButton.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_smallBlue_search
        Me.ImportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImportButton.FlatAppearance.BorderSize = 0
        Me.ImportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ImportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportButton.ForeColor = System.Drawing.Color.Black
        Me.ImportButton.Location = New System.Drawing.Point(45, 335)
        Me.ImportButton.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(150, 23)
        Me.ImportButton.TabIndex = 8
        Me.ImportButton.Text = "Import image"
        Me.ImportButton.UseVisualStyleBackColor = False
        '
        'DetailsLabel
        '
        Me.DetailsLabel.AutoSize = True
        Me.DetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsLabel.ForeColor = System.Drawing.Color.DarkGray
        Me.DetailsLabel.Location = New System.Drawing.Point(16, 27)
        Me.DetailsLabel.Name = "DetailsLabel"
        Me.DetailsLabel.Size = New System.Drawing.Size(110, 24)
        Me.DetailsLabel.TabIndex = 50
        Me.DetailsLabel.Text = "dvd details"
        '
        'YearReleasedLabel1
        '
        Me.YearReleasedLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YearReleasedLabel1.AutoSize = True
        Me.YearReleasedLabel1.BackColor = System.Drawing.Color.DimGray
        Me.YearReleasedLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearReleasedLabel1.ForeColor = System.Drawing.Color.White
        Me.YearReleasedLabel1.Location = New System.Drawing.Point(440, 229)
        Me.YearReleasedLabel1.Name = "YearReleasedLabel1"
        Me.YearReleasedLabel1.Size = New System.Drawing.Size(105, 15)
        Me.YearReleasedLabel1.TabIndex = 47
        Me.YearReleasedLabel1.Text = "Year Released:"
        '
        'BoxArtPictureBox
        '
        Me.BoxArtPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxArtPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DVDsBindingSource, "ImageBinary", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.BoxArtPictureBox.Location = New System.Drawing.Point(19, 123)
        Me.BoxArtPictureBox.Margin = New System.Windows.Forms.Padding(3, 1, 3, 2)
        Me.BoxArtPictureBox.Name = "BoxArtPictureBox"
        Me.BoxArtPictureBox.Size = New System.Drawing.Size(196, 208)
        Me.BoxArtPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BoxArtPictureBox.TabIndex = 37
        Me.BoxArtPictureBox.TabStop = False
        '
        'MinutesLabel
        '
        Me.MinutesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinutesLabel.AutoSize = True
        Me.MinutesLabel.BackColor = System.Drawing.Color.DimGray
        Me.MinutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesLabel.ForeColor = System.Drawing.Color.White
        Me.MinutesLabel.Location = New System.Drawing.Point(486, 208)
        Me.MinutesLabel.Name = "MinutesLabel"
        Me.MinutesLabel.Size = New System.Drawing.Size(38, 15)
        Me.MinutesLabel.TabIndex = 46
        Me.MinutesLabel.Text = "mins"
        '
        'YearDisplay
        '
        Me.YearDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YearDisplay.AutoSize = True
        Me.YearDisplay.BackColor = System.Drawing.Color.DimGray
        Me.YearDisplay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "YearReleased", True))
        Me.YearDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearDisplay.ForeColor = System.Drawing.Color.White
        Me.YearDisplay.Location = New System.Drawing.Point(19, 95)
        Me.YearDisplay.Name = "YearDisplay"
        Me.YearDisplay.Size = New System.Drawing.Size(57, 20)
        Me.YearDisplay.TabIndex = 38
        Me.YearDisplay.Text = "[Year]"
        '
        'TitleDisplay
        '
        Me.TitleDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleDisplay.AutoSize = True
        Me.TitleDisplay.BackColor = System.Drawing.Color.DimGray
        Me.TitleDisplay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "Title", True))
        Me.TitleDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleDisplay.ForeColor = System.Drawing.Color.White
        Me.TitleDisplay.Location = New System.Drawing.Point(19, 64)
        Me.TitleDisplay.Name = "TitleDisplay"
        Me.TitleDisplay.Size = New System.Drawing.Size(55, 24)
        Me.TitleDisplay.TabIndex = 36
        Me.TitleDisplay.Text = "[Title]"
        '
        'MyRatingLabel
        '
        Me.MyRatingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyRatingLabel.AutoSize = True
        Me.MyRatingLabel.BackColor = System.Drawing.Color.DimGray
        Me.MyRatingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyRatingLabel.ForeColor = System.Drawing.Color.White
        Me.MyRatingLabel.Location = New System.Drawing.Point(19, 388)
        Me.MyRatingLabel.Name = "MyRatingLabel"
        Me.MyRatingLabel.Size = New System.Drawing.Size(75, 15)
        Me.MyRatingLabel.TabIndex = 48
        Me.MyRatingLabel.Text = "My Rating:"
        '
        'UPCLabel
        '
        Me.UPCLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UPCLabel.AutoSize = True
        Me.UPCLabel.BackColor = System.Drawing.Color.DimGray
        Me.UPCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPCLabel.ForeColor = System.Drawing.Color.White
        Me.UPCLabel.Location = New System.Drawing.Point(19, 365)
        Me.UPCLabel.Name = "UPCLabel"
        Me.UPCLabel.Size = New System.Drawing.Size(39, 15)
        Me.UPCLabel.TabIndex = 45
        Me.UPCLabel.Text = "UPC:"
        '
        'UPCTextBox
        '
        Me.UPCTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UPCTextBox.BackColor = System.Drawing.Color.White
        Me.UPCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "UPC", True))
        Me.UPCTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPCTextBox.Location = New System.Drawing.Point(128, 363)
        Me.UPCTextBox.Name = "UPCTextBox"
        Me.UPCTextBox.Size = New System.Drawing.Size(87, 21)
        Me.UPCTextBox.TabIndex = 7
        '
        'RatedLabel
        '
        Me.RatedLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RatedLabel.AutoSize = True
        Me.RatedLabel.BackColor = System.Drawing.Color.DimGray
        Me.RatedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatedLabel.ForeColor = System.Drawing.Color.White
        Me.RatedLabel.Location = New System.Drawing.Point(440, 133)
        Me.RatedLabel.Name = "RatedLabel"
        Me.RatedLabel.Size = New System.Drawing.Size(49, 15)
        Me.RatedLabel.TabIndex = 42
        Me.RatedLabel.Text = "Rated:"
        '
        'LengthLabel
        '
        Me.LengthLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LengthLabel.AutoSize = True
        Me.LengthLabel.BackColor = System.Drawing.Color.DimGray
        Me.LengthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LengthLabel.ForeColor = System.Drawing.Color.White
        Me.LengthLabel.Location = New System.Drawing.Point(440, 181)
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(55, 15)
        Me.LengthLabel.TabIndex = 44
        Me.LengthLabel.Text = "Length:"
        '
        'DirectorLabel
        '
        Me.DirectorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DirectorLabel.AutoSize = True
        Me.DirectorLabel.BackColor = System.Drawing.Color.DimGray
        Me.DirectorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirectorLabel.ForeColor = System.Drawing.Color.White
        Me.DirectorLabel.Location = New System.Drawing.Point(284, 133)
        Me.DirectorLabel.Name = "DirectorLabel"
        Me.DirectorLabel.Size = New System.Drawing.Size(62, 15)
        Me.DirectorLabel.TabIndex = 41
        Me.DirectorLabel.Text = "Director:"
        '
        'DirectorTextBox
        '
        Me.DirectorTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DirectorTextBox.BackColor = System.Drawing.Color.White
        Me.DirectorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "Director", True))
        Me.DirectorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirectorTextBox.Location = New System.Drawing.Point(284, 154)
        Me.DirectorTextBox.Name = "DirectorTextBox"
        Me.DirectorTextBox.Size = New System.Drawing.Size(132, 21)
        Me.DirectorTextBox.TabIndex = 1
        '
        'CommentsLabel
        '
        Me.CommentsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommentsLabel.AutoSize = True
        Me.CommentsLabel.BackColor = System.Drawing.Color.DimGray
        Me.CommentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentsLabel.ForeColor = System.Drawing.Color.White
        Me.CommentsLabel.Location = New System.Drawing.Point(284, 181)
        Me.CommentsLabel.Name = "CommentsLabel"
        Me.CommentsLabel.Size = New System.Drawing.Size(75, 15)
        Me.CommentsLabel.TabIndex = 43
        Me.CommentsLabel.Text = "Comments:"
        '
        'CommentsTextbox
        '
        Me.CommentsTextbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommentsTextbox.BackColor = System.Drawing.Color.White
        Me.CommentsTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "Comments", True))
        Me.CommentsTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentsTextbox.Location = New System.Drawing.Point(284, 202)
        Me.CommentsTextbox.Multiline = True
        Me.CommentsTextbox.Name = "CommentsTextbox"
        Me.CommentsTextbox.Size = New System.Drawing.Size(132, 67)
        Me.CommentsTextbox.TabIndex = 3
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.BackColor = System.Drawing.Color.DimGray
        Me.DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.ForeColor = System.Drawing.Color.White
        Me.DescriptionLabel.Location = New System.Drawing.Point(284, 278)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(80, 15)
        Me.DescriptionLabel.TabIndex = 49
        Me.DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextbox
        '
        Me.DescriptionTextbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionTextbox.BackColor = System.Drawing.Color.White
        Me.DescriptionTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "Description", True))
        Me.DescriptionTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextbox.Location = New System.Drawing.Point(284, 299)
        Me.DescriptionTextbox.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.DescriptionTextbox.Multiline = True
        Me.DescriptionTextbox.Name = "DescriptionTextbox"
        Me.DescriptionTextbox.Size = New System.Drawing.Size(208, 89)
        Me.DescriptionTextbox.TabIndex = 6
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.DimGray
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(284, 86)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(39, 15)
        Me.TitleLabel.TabIndex = 40
        Me.TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleTextBox.BackColor = System.Drawing.Color.White
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(284, 107)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(207, 21)
        Me.TitleTextBox.TabIndex = 0
        '
        'YearReleasedDateTimePicker
        '
        Me.YearReleasedDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YearReleasedDateTimePicker.Location = New System.Drawing.Point(284, 154)
        Me.YearReleasedDateTimePicker.Name = "YearReleasedDateTimePicker"
        Me.YearReleasedDateTimePicker.Size = New System.Drawing.Size(50, 21)
        Me.YearReleasedDateTimePicker.TabIndex = 29
        '
        'RatedComboBox
        '
        Me.RatedComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RatedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "Rated", True))
        Me.RatedComboBox.DropDownHeight = 120
        Me.RatedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RatedComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatedComboBox.FormattingEnabled = True
        Me.RatedComboBox.IntegralHeight = False
        Me.RatedComboBox.Items.AddRange(New Object() {"G", "PG", "PG-13", "R", "NC-17", "NR"})
        Me.RatedComboBox.Location = New System.Drawing.Point(440, 154)
        Me.RatedComboBox.Name = "RatedComboBox"
        Me.RatedComboBox.Size = New System.Drawing.Size(69, 23)
        Me.RatedComboBox.TabIndex = 2
        '
        'LengthNumericUpDown
        '
        Me.LengthNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LengthNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "Length", True))
        Me.LengthNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LengthNumericUpDown.Location = New System.Drawing.Point(440, 202)
        Me.LengthNumericUpDown.Name = "LengthNumericUpDown"
        Me.LengthNumericUpDown.Size = New System.Drawing.Size(36, 21)
        Me.LengthNumericUpDown.TabIndex = 4
        '
        'YearReleasedTextbox
        '
        Me.YearReleasedTextbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YearReleasedTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDsBindingSource, "YearReleased", True))
        Me.YearReleasedTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearReleasedTextbox.Location = New System.Drawing.Point(440, 250)
        Me.YearReleasedTextbox.Name = "YearReleasedTextbox"
        Me.YearReleasedTextbox.Size = New System.Drawing.Size(69, 21)
        Me.YearReleasedTextbox.TabIndex = 5
        '
        'ViewOnlineButton
        '
        Me.ViewOnlineButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ViewOnlineButton.BackColor = System.Drawing.Color.Transparent
        Me.ViewOnlineButton.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_smallBlue_search
        Me.ViewOnlineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ViewOnlineButton.FlatAppearance.BorderSize = 0
        Me.ViewOnlineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ViewOnlineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ViewOnlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewOnlineButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewOnlineButton.ForeColor = System.Drawing.Color.Black
        Me.ViewOnlineButton.Location = New System.Drawing.Point(119, 446)
        Me.ViewOnlineButton.Name = "ViewOnlineButton"
        Me.ViewOnlineButton.Size = New System.Drawing.Size(107, 32)
        Me.ViewOnlineButton.TabIndex = 8
        Me.ViewOnlineButton.Text = "View Online"
        Me.ViewOnlineButton.UseVisualStyleBackColor = False
        '
        'RefreshOnlineButton
        '
        Me.RefreshOnlineButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RefreshOnlineButton.BackColor = System.Drawing.Color.Transparent
        Me.RefreshOnlineButton.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_smallBlue_search
        Me.RefreshOnlineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshOnlineButton.FlatAppearance.BorderSize = 0
        Me.RefreshOnlineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RefreshOnlineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RefreshOnlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshOnlineButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshOnlineButton.ForeColor = System.Drawing.Color.Black
        Me.RefreshOnlineButton.Location = New System.Drawing.Point(13, 446)
        Me.RefreshOnlineButton.Name = "RefreshOnlineButton"
        Me.RefreshOnlineButton.Size = New System.Drawing.Size(99, 32)
        Me.RefreshOnlineButton.TabIndex = 7
        Me.RefreshOnlineButton.Text = "Refresh"
        Me.RefreshOnlineButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.DataSource = Me.DVDsBindingSource
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.YearReleased, Me.Director, Me.MyRating, Me.Rated, Me.Actors, Me.Length, Me.Description, Me.Comments, Me.UPC, Me.ImageLink, Me.WebPageLink, Me.ID, Me.Genre})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 151)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.EnableHeadersVisualStyles = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(277, 243)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 3
        '
        'RemoveButton
        '
        Me.RemoveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RemoveButton.BackColor = System.Drawing.Color.Transparent
        Me.RemoveButton.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_smallBlue_search
        Me.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemoveButton.FlatAppearance.BorderSize = 0
        Me.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.ForeColor = System.Drawing.Color.Black
        Me.RemoveButton.Location = New System.Drawing.Point(119, 407)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(107, 32)
        Me.RemoveButton.TabIndex = 6
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = False
        '
        'AddTitleButton
        '
        Me.AddTitleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddTitleButton.BackColor = System.Drawing.Color.Transparent
        Me.AddTitleButton.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_smallBlue_search
        Me.AddTitleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddTitleButton.FlatAppearance.BorderSize = 0
        Me.AddTitleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.AddTitleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.AddTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTitleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTitleButton.ForeColor = System.Drawing.Color.Black
        Me.AddTitleButton.Location = New System.Drawing.Point(13, 407)
        Me.AddTitleButton.Name = "AddTitleButton"
        Me.AddTitleButton.Size = New System.Drawing.Size(99, 32)
        Me.AddTitleButton.TabIndex = 5
        Me.AddTitleButton.Text = "Add Title"
        Me.AddTitleButton.UseVisualStyleBackColor = False
        '
        'LookLabel
        '
        Me.LookLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LookLabel.AutoSize = True
        Me.LookLabel.BackColor = System.Drawing.Color.Transparent
        Me.LookLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookLabel.ForeColor = System.Drawing.Color.White
        Me.LookLabel.Location = New System.Drawing.Point(71, 39)
        Me.LookLabel.Name = "LookLabel"
        Me.LookLabel.Size = New System.Drawing.Size(167, 15)
        Me.LookLabel.TabIndex = 4
        Me.LookLabel.Text = "Look in my collection for:"
        '
        'FilterTextBox
        '
        Me.FilterTextBox.Location = New System.Drawing.Point(71, 66)
        Me.FilterTextBox.Name = "FilterTextBox"
        Me.FilterTextBox.Size = New System.Drawing.Size(140, 20)
        Me.FilterTextBox.TabIndex = 0
        '
        'ShowAllImage
        '
        Me.ShowAllImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ShowAllImage.BackColor = System.Drawing.Color.Transparent
        Me.ShowAllImage.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_showDVD_L
        Me.ShowAllImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ShowAllImage.FlatAppearance.BorderSize = 0
        Me.ShowAllImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ShowAllImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ShowAllImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowAllImage.Location = New System.Drawing.Point(323, 15)
        Me.ShowAllImage.Name = "ShowAllImage"
        Me.ShowAllImage.Size = New System.Drawing.Size(62, 45)
        Me.ShowAllImage.TabIndex = 5
        Me.ShowAllImage.TabStop = False
        Me.ShowAllImage.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.icon_magnifyingGlass
        Me.PictureBox2.Location = New System.Drawing.Point(13, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 88)
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'FilterButton
        '
        Me.FilterButton.BackColor = System.Drawing.Color.Transparent
        Me.FilterButton.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_smallBlue_search
        Me.FilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FilterButton.FlatAppearance.BorderSize = 0
        Me.FilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.FilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterButton.ForeColor = System.Drawing.Color.Black
        Me.FilterButton.Location = New System.Drawing.Point(218, 59)
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(70, 32)
        Me.FilterButton.TabIndex = 1
        Me.FilterButton.Text = "Filter"
        Me.FilterButton.UseVisualStyleBackColor = False
        '
        'ShowAllButton
        '
        Me.ShowAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ShowAllButton.BackColor = System.Drawing.Color.Transparent
        Me.ShowAllButton.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_showDvd_r
        Me.ShowAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ShowAllButton.FlatAppearance.BorderSize = 0
        Me.ShowAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ShowAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowAllButton.ForeColor = System.Drawing.Color.Black
        Me.ShowAllButton.Location = New System.Drawing.Point(385, 15)
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(120, 45)
        Me.ShowAllButton.TabIndex = 2
        Me.ShowAllButton.Text = "Show all dvds"
        Me.ShowAllButton.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Common image files (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png|Jpeg files (" & _
            "*.jpg)|*.jpg|GIF files (*.gif)|*.gif|Bitmap files (*.bmp)|*.bmp|PNG files (*.png" & _
            ")|*.png"
        Me.OpenFileDialog1.Title = "Select the image file to import and press Open: "
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Title.Width = 224
        '
        'YearReleased
        '
        Me.YearReleased.DataPropertyName = "YearReleased"
        DataGridViewCellStyle2.Format = "yyyy"
        Me.YearReleased.DefaultCellStyle = DataGridViewCellStyle2
        Me.YearReleased.HeaderText = "Year"
        Me.YearReleased.Name = "YearReleased"
        Me.YearReleased.ReadOnly = True
        Me.YearReleased.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Director
        '
        Me.Director.DataPropertyName = "Director"
        Me.Director.HeaderText = "Director"
        Me.Director.Name = "Director"
        Me.Director.ReadOnly = True
        Me.Director.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'MyRating
        '
        Me.MyRating.DataPropertyName = "MyRating"
        Me.MyRating.HeaderText = "MyRating"
        Me.MyRating.Name = "MyRating"
        Me.MyRating.ReadOnly = True
        Me.MyRating.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Rated
        '
        Me.Rated.DataPropertyName = "Rated"
        Me.Rated.HeaderText = "Rated"
        Me.Rated.Name = "Rated"
        Me.Rated.ReadOnly = True
        Me.Rated.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Actors
        '
        Me.Actors.DataPropertyName = "Actors"
        Me.Actors.HeaderText = "Actors"
        Me.Actors.Name = "Actors"
        Me.Actors.ReadOnly = True
        Me.Actors.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Length
        '
        Me.Length.DataPropertyName = "Length"
        Me.Length.HeaderText = "Length"
        Me.Length.Name = "Length"
        Me.Length.ReadOnly = True
        Me.Length.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Comments
        '
        Me.Comments.DataPropertyName = "Comments"
        Me.Comments.HeaderText = "Comments"
        Me.Comments.Name = "Comments"
        Me.Comments.ReadOnly = True
        Me.Comments.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'UPC
        '
        Me.UPC.DataPropertyName = "UPC"
        Me.UPC.HeaderText = "UPC"
        Me.UPC.Name = "UPC"
        Me.UPC.ReadOnly = True
        Me.UPC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ImageLink
        '
        Me.ImageLink.DataPropertyName = "ImageLink"
        Me.ImageLink.HeaderText = "ImageLink"
        Me.ImageLink.Name = "ImageLink"
        Me.ImageLink.ReadOnly = True
        Me.ImageLink.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'WebPageLink
        '
        Me.WebPageLink.DataPropertyName = "WebPageLink"
        Me.WebPageLink.HeaderText = "WebPageLink"
        Me.WebPageLink.Name = "WebPageLink"
        Me.WebPageLink.ReadOnly = True
        Me.WebPageLink.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Genre
        '
        Me.Genre.DataPropertyName = "Genre"
        Me.Genre.HeaderText = "Genre"
        Me.Genre.Name = "Genre"
        Me.Genre.ReadOnly = True
        Me.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DVDsBindingSource
        '
        Me.DVDsBindingSource.DataMember = "DVDs"
        Me.DVDsBindingSource.DataSource = Me.DVDCollectionDataSet
        '
        'DVDCollectionDataSet
        '
        Me.DVDCollectionDataSet.DataSetName = "DVDCollectionDataSet"
        Me.DVDCollectionDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DVDsTableAdapter
        '
        Me.DVDsTableAdapter.ClearBeforeFill = True
        '
        'ListDetails
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.PanelBG_Tile
        Me.Controls.Add(Me.ShowAllButton)
        Me.Controls.Add(Me.FilterButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ShowAllImage)
        Me.Controls.Add(Me.LookLabel)
        Me.Controls.Add(Me.FilterTextBox)
        Me.Controls.Add(Me.AddTitleButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ViewOnlineButton)
        Me.Controls.Add(Me.RefreshOnlineButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DVDDetailsPanel)
        Me.Name = "ListDetails"
        Me.Size = New System.Drawing.Size(900, 500)
        Me.DVDDetailsPanel.ResumeLayout(False)
        Me.DVDDetailsPanel.PerformLayout()
        CType(Me.BoxArtPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVDsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVDCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DVDDetailsPanel As System.Windows.Forms.Panel
    Friend WithEvents YearReleasedLabel1 As System.Windows.Forms.Label
    Friend WithEvents BoxArtPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents MinutesLabel As System.Windows.Forms.Label
    Friend WithEvents YearDisplay As System.Windows.Forms.Label
    Friend WithEvents TitleDisplay As System.Windows.Forms.Label
    Friend WithEvents MyRatingLabel As System.Windows.Forms.Label
    Friend WithEvents UPCLabel As System.Windows.Forms.Label
    Friend WithEvents UPCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RatedLabel As System.Windows.Forms.Label
    Friend WithEvents LengthLabel As System.Windows.Forms.Label
    Friend WithEvents DirectorLabel As System.Windows.Forms.Label
    Friend WithEvents DirectorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommentsLabel As System.Windows.Forms.Label
    Friend WithEvents CommentsTextbox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents DescriptionTextbox As System.Windows.Forms.TextBox
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearReleasedDateTimePicker As System.Windows.Forms.TextBox
    Friend WithEvents RatedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LengthNumericUpDown As System.Windows.Forms.TextBox
    Friend WithEvents YearReleasedTextbox As System.Windows.Forms.TextBox
    Friend WithEvents DVDsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewOnlineButton As System.Windows.Forms.Button
    Friend WithEvents RefreshOnlineButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents AddTitleButton As System.Windows.Forms.Button
    Friend WithEvents LookLabel As System.Windows.Forms.Label
    Friend WithEvents FilterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShowAllImage As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilterButton As System.Windows.Forms.Button
    Friend WithEvents ShowAllButton As System.Windows.Forms.Button
    Friend WithEvents DetailsLabel As System.Windows.Forms.Label
    Friend WithEvents DVDCollectionDataSet As $safeprojectname$.DVDCollectionDataSet
    Friend WithEvents DVDsTableAdapter As $safeprojectname$.DVDCollectionDataSetTableAdapters.DVDsTableAdapter
    Friend WithEvents ImportButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearReleased As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Director As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MyRating As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Actors As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Length As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UPC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImageLink As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WebPageLink As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Genre As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
