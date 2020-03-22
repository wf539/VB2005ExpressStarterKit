''' <summary>
''' Host form responsible for navigating between view and search online modes of the application.  
''' </summary>
''' <remarks>View MainForm.vb file in designer to modify additional properties.  </remarks>
Public Class MainForm

    'User control objects responsible for viewing the collection and searching online
    Dim m_ListDetailsPart As ListDetails
    Dim m_SearchOnlinePart As SearchOnline

    ''' <summary>
    ''' Gets user control instance responsible for viewing the collection of movies.  
    ''' </summary>
    ''' <value>Live instance of the ListDetails user control.  </value>
    ''' <remarks>Singleton instance pattern; the object is created upon first access, and the reused for all future accesses. </remarks>
    Friend ReadOnly Property ListDetailsPart() As ListDetails
        Get
            'Initialize the variable with a new object instance if nothing exists
            If Me.m_ListDetailsPart Is Nothing Then
                'creating object
                Me.m_ListDetailsPart = New ListDetails

                'site the control on the host user control and dock fill it
                Me.TargetPanel.Controls.Add(Me.m_ListDetailsPart)
                Me.m_ListDetailsPart.Dock = DockStyle.Fill
            End If

            Return Me.m_ListDetailsPart
        End Get
    End Property

    ''' <summary>
    ''' Gets user control property responsible for viewing the collection of movies.  
    ''' </summary>
    ''' <value>Live instance of the ListDetails user control.  </value>
    ''' <remarks>Singleton instance pattern; the object is created upon first access, and the reused for all future accesses. </remarks>
    Friend ReadOnly Property SearchOnlinePart() As SearchOnline
        Get
            'Initialize the variable with a new object instance if nothing exists
            If Me.m_SearchOnlinePart Is Nothing Then
                'creating object
                Me.m_SearchOnlinePart = New SearchOnline

                'site the control on the host user control and dock fill it
                Me.TargetPanel.Controls.Add(Me.m_SearchOnlinePart)
                Me.m_SearchOnlinePart.Dock = DockStyle.Fill
            End If

            Return Me.m_SearchOnlinePart
        End Get
    End Property

    ''' <summary>Shows the ListDetails user control on first load of the application. </summary>
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ShowListDetailsPart()
    End Sub

    ''' <summary>Restores window when the tray icon is clicked. </summary>
    Private Sub NotifyIcon1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
        Me.RestoreWindow()
    End Sub

    ''' <summary>Restores window when the try icon is double clicked. </summary>
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.RestoreWindow()
    End Sub

    ''' <summary>Makes the ListDetails user control visible and hides the SearchOnline user control. </summary>
    Private Sub ViewDetailsButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewDetailsButton.Click
        Me.ShowListDetailsPart()
    End Sub

    ''' <summary>Makes the SearchOnline user control visible and hides the ListDetails user control. </summary>
    Private Sub SearchOnlineButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchOnlineButton.Click
        Me.ShowSearchOnlinePart()
    End Sub

    ''' <summary>Restores window to the normal size and ensures that it is visible.  </summary>
    Private Sub RestoreWindow()
        Me.WindowState = FormWindowState.Normal
        Me.Visible = True
    End Sub

    ''' <summary>
    ''' Displays the ListDetails user control and hides the SearchOnline user control.  
    ''' </summary>
    ''' <remarks>Enables the swapping behavior of list and search modes.  </remarks>
    Friend Sub ShowListDetailsPart()
        'performance optimization - skip hiding this control if it has not been created yet
        If Me.SearchOnlinePart IsNot Nothing Then
            Me.SearchOnlinePart.Visible = False
        End If

        Me.ListDetailsPart.Visible = True
    End Sub

    ''' <summary>
    ''' Displays the SearchOnline user control and hides the ListDetails user control.  
    ''' </summary>
    ''' <remarks>Enables the swapping behavior of list and search modes.  </remarks>
    Friend Sub ShowSearchOnlinePart()
        'performance optimization - skip hiding this control if it has not been created yet
        If Me.ListDetailsPart IsNot Nothing Then
            Me.ListDetailsPart.Visible = False
        End If

        'Show this control and hide all others
        Me.SearchOnlinePart.Visible = True
    End Sub

End Class