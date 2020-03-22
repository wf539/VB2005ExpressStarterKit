<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchOnline
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
        Me.DVDDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DVDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SearchButton1 = New System.Windows.Forms.Button
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DetailsLabel = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DescriptionLabel = New System.Windows.Forms.Label
        Me.ReleasedDateLabel = New System.Windows.Forms.Label
        Me.ReleasedDateLabel1 = New System.Windows.Forms.Label
        Me.TitleLabel = New System.Windows.Forms.Label
        Me.TitleTextBox = New System.Windows.Forms.Label
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.AddToCollectionButton = New System.Windows.Forms.Button
        CType(Me.DVDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DVDDataGridView
        '
        Me.DVDDataGridView.AllowUserToAddRows = False
        Me.DVDDataGridView.AllowUserToDeleteRows = False
        Me.DVDDataGridView.AllowUserToResizeRows = False
        Me.DVDDataGridView.AutoGenerateColumns = False
        Me.DVDDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn19)
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn20)
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn21)
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn22)
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn23)
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn24)
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn25)
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn26)
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn27)
        Me.DVDDataGridView.Columns.Add(Me.DataGridViewTextBoxColumn28)
        Me.DVDDataGridView.DataSource = Me.DVDBindingSource
        Me.DVDDataGridView.Location = New System.Drawing.Point(13, 158)
        Me.DVDDataGridView.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.DVDDataGridView.MultiSelect = False
        Me.DVDDataGridView.Name = "DVDDataGridView"
        Me.DVDDataGridView.ReadOnly = True
        Me.DVDDataGridView.RowHeadersVisible = False
        Me.DVDDataGridView.EnableHeadersVisualStyles = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DVDDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DVDDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DVDDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DVDDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DVDDataGridView.Size = New System.Drawing.Size(277, 243)
        Me.DVDDataGridView.StandardTab = True
        Me.DVDDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn19.Name = "Title"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 224
        Me.DataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "ReleasedDate"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Year"
        Me.DataGridViewTextBoxColumn20.Name = "ReleasedDate"
        DataGridViewCellStyle2.Format = "yyyy"
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Directors"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Directors"
        Me.DataGridViewTextBoxColumn21.Name = "Directors"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Rating"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Rating"
        Me.DataGridViewTextBoxColumn22.Name = "Rating"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Actors"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Actors"
        Me.DataGridViewTextBoxColumn23.Name = "Actors"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "RunningTime"
        Me.DataGridViewTextBoxColumn24.HeaderText = "RunningTime"
        Me.DataGridViewTextBoxColumn24.Name = "RunningTime"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn25.Name = "Description"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "UPC"
        Me.DataGridViewTextBoxColumn26.HeaderText = "UPC"
        Me.DataGridViewTextBoxColumn26.Name = "UPC"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "ImageUrl"
        Me.DataGridViewTextBoxColumn27.HeaderText = "ImageUrl"
        Me.DataGridViewTextBoxColumn27.Name = "ImageUrl"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.[True]

        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "WebPageUrl"
        Me.DataGridViewTextBoxColumn28.HeaderText = "WebPageUrl"
        Me.DataGridViewTextBoxColumn28.Name = "WebPageUrl"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.[True]

        '
        'DVDBindingSource
        '
        Me.DVDBindingSource.DataSource = GetType($safeprojectname$.DVD)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.icon_magnifyingGlass
        Me.PictureBox2.Location = New System.Drawing.Point(13, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 88)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(71, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 36)
        Me.Label1.TabIndex = 51
        Me.Label1.Tag = ""
        Me.Label1.Text = "Please type in a DVD keyword and press Search:"
        '
        'SearchButton1
        '
        Me.SearchButton1.BackColor = System.Drawing.Color.Transparent
        Me.SearchButton1.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_smallBlue_search
        Me.SearchButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchButton1.FlatAppearance.BorderSize = 0
        Me.SearchButton1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Me.SearchButton1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Me.SearchButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton1.ForeColor = System.Drawing.Color.Black
        Me.SearchButton1.Location = New System.Drawing.Point(218, 59)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(70, 32)
        Me.SearchButton1.TabIndex = 1
        Me.SearchButton1.Text = "Search"
        Me.SearchButton1.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(71, 66)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(140, 21)
        Me.SearchTextBox.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(11, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 32)
        Me.Label3.TabIndex = 47
        Me.Label3.Tag = ""
        Me.Label3.Text = "Select a Title and optionally press Add to collection:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(13, 411)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "0 results found."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.panel_dvdInfo_noTxt
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.DetailsLabel)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.DescriptionLabel)
        Me.Panel2.Controls.Add(Me.ReleasedDateLabel)
        Me.Panel2.Controls.Add(Me.ReleasedDateLabel1)
        Me.Panel2.Controls.Add(Me.TitleLabel)
        Me.Panel2.Controls.Add(Me.TitleTextBox)
        Me.Panel2.Controls.Add(Me.DescriptionTextBox)
        Me.Panel2.Location = New System.Drawing.Point(320, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 414)
        Me.Panel2.TabIndex = 3
        '
        'DetailsLabel
        '
        Me.DetailsLabel.AutoSize = True
        Me.DetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsLabel.ForeColor = System.Drawing.Color.DarkGray
        Me.DetailsLabel.Location = New System.Drawing.Point(16, 27)
        Me.DetailsLabel.Name = "DetailsLabel"
        Me.DetailsLabel.Size = New System.Drawing.Size(109, 24)
        Me.DetailsLabel.TabIndex = 55
        Me.DetailsLabel.Text = "dvd details"
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Me.DVDBindingSource, "ImageUrl", True))
        Me.PictureBox1.Location = New System.Drawing.Point(323, 90)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 275)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.BackColor = System.Drawing.Color.Transparent
        Me.DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.DescriptionLabel.Location = New System.Drawing.Point(22, 193)
        Me.DescriptionLabel.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(77, 15)
        Me.DescriptionLabel.TabIndex = 40
        Me.DescriptionLabel.Text = "Description:"
        '
        'ReleasedDateLabel
        '
        Me.ReleasedDateLabel.AutoSize = True
        Me.ReleasedDateLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReleasedDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReleasedDateLabel.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.ReleasedDateLabel.Location = New System.Drawing.Point(23, 136)
        Me.ReleasedDateLabel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.ReleasedDateLabel.Name = "ReleasedDateLabel"
        Me.ReleasedDateLabel.Size = New System.Drawing.Size(35, 15)
        Me.ReleasedDateLabel.TabIndex = 38
        Me.ReleasedDateLabel.Text = "Year:"
        '
        'ReleasedDateLabel1
        '
        Me.ReleasedDateLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ReleasedDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDBindingSource, "ReleasedDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "", "yyyy"))
        Me.ReleasedDateLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReleasedDateLabel1.ForeColor = System.Drawing.Color.White
        Me.ReleasedDateLabel1.Location = New System.Drawing.Point(74, 161)
        Me.ReleasedDateLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 1)
        Me.ReleasedDateLabel1.Name = "ReleasedDateLabel1"
        Me.ReleasedDateLabel1.Size = New System.Drawing.Size(180, 29)
        Me.ReleasedDateLabel1.TabIndex = 39
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.TitleLabel.Location = New System.Drawing.Point(24, 62)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(34, 15)
        Me.TitleLabel.TabIndex = 36
        Me.TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.BackColor = System.Drawing.Color.Transparent
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.ForeColor = System.Drawing.Color.White
        Me.TitleTextBox.Location = New System.Drawing.Point(74, 75)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 1, 2)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(216, 59)
        Me.TitleTextBox.TabIndex = 37
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DVDBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(23, 218)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(266, 169)
        Me.DescriptionTextBox.TabIndex = 41
        Me.DescriptionTextBox.TabStop = False
        '
        'AddToCollectionButton
        '
        Me.AddToCollectionButton.BackColor = System.Drawing.Color.Transparent
        Me.AddToCollectionButton.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.button_addCollection
        Me.AddToCollectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddToCollectionButton.FlatAppearance.BorderSize = 0
        Me.AddToCollectionButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        Me.AddToCollectionButton.FlatAppearance.MouseDownBackColor = Color.Transparent
        Me.AddToCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddToCollectionButton.ForeColor = System.Drawing.Color.Black
        Me.AddToCollectionButton.Location = New System.Drawing.Point(13, 436)
        Me.AddToCollectionButton.Name = "AddToCollectionButton"
        Me.AddToCollectionButton.Size = New System.Drawing.Size(149, 36)
        Me.AddToCollectionButton.TabIndex = 4
        Me.AddToCollectionButton.Text = "Add to collection"
        Me.AddToCollectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddToCollectionButton.UseVisualStyleBackColor = False
        '
        'SearchOnline
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.PanelBG_Tile
        Me.Controls.Add(Me.AddToCollectionButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchButton1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DVDDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SearchOnline"
        Me.Size = New System.Drawing.Size(900, 500)
        CType(Me.DVDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchButton1 As System.Windows.Forms.Button
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DVDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents ReleasedDateLabel As System.Windows.Forms.Label
    Friend WithEvents ReleasedDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents TitleTextBox As System.Windows.Forms.Label
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddToCollectionButton As System.Windows.Forms.Button
    Friend WithEvents DVDBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents DetailsLabel As System.Windows.Forms.Label

End Class
