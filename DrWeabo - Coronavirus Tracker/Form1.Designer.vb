<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchYourCountry = New System.Windows.Forms.ToolStripMenuItem()
        Me.Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.Donate = New System.Windows.Forms.ToolStripMenuItem()
        Me.Quit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchForTopCountry = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reset = New System.Windows.Forms.ToolStripMenuItem()
        Me.Others = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.Minimal = New System.Windows.Forms.ToolStripMenuItem()
        Me.Normal = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout
        Me.SuspendLayout
        '
        'WebBrowser
        '
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser.Location = New System.Drawing.Point(0, 24)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.ScriptErrorsSuppressed = true
        Me.WebBrowser.Size = New System.Drawing.Size(1188, 708)
        Me.WebBrowser.TabIndex = 0
        Me.WebBrowser.Url = New System.Uri("https://corona-stats.online/", System.UriKind.Absolute)
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Interval = 60000
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Black
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu, Me.Edit, Me.Others})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1188, 24)
        Me.MenuStrip.TabIndex = 1
        '
        'Menu
        '
        Me.Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchYourCountry, Me.Help, Me.Donate, Me.Quit})
        Me.Menu.ForeColor = System.Drawing.Color.Lime
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(50, 20)
        Me.Menu.Text = "&Menu"
        '
        'SearchYourCountry
        '
        Me.SearchYourCountry.BackColor = System.Drawing.Color.Black
        Me.SearchYourCountry.ForeColor = System.Drawing.Color.Lime
        Me.SearchYourCountry.Image = CType(resources.GetObject("SearchYourCountry.Image"),System.Drawing.Image)
        Me.SearchYourCountry.Name = "SearchYourCountry"
        Me.SearchYourCountry.Size = New System.Drawing.Size(182, 22)
        Me.SearchYourCountry.Text = "&Search Your Country"
        '
        'Help
        '
        Me.Help.BackColor = System.Drawing.Color.Black
        Me.Help.ForeColor = System.Drawing.Color.Lime
        Me.Help.Image = CType(resources.GetObject("Help.Image"),System.Drawing.Image)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(182, 22)
        Me.Help.Text = "&Help"
        '
        'Donate
        '
        Me.Donate.BackColor = System.Drawing.Color.Black
        Me.Donate.ForeColor = System.Drawing.Color.Lime
        Me.Donate.Image = CType(resources.GetObject("Donate.Image"),System.Drawing.Image)
        Me.Donate.Name = "Donate"
        Me.Donate.Size = New System.Drawing.Size(182, 22)
        Me.Donate.Text = "&Donate"
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Black
        Me.Quit.ForeColor = System.Drawing.Color.Lime
        Me.Quit.Image = CType(resources.GetObject("Quit.Image"),System.Drawing.Image)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(182, 22)
        Me.Quit.Text = "&Quit"
        '
        'Edit
        '
        Me.Edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchForTopCountry, Me.Reset})
        Me.Edit.ForeColor = System.Drawing.Color.Lime
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(39, 20)
        Me.Edit.Text = "&Edit"
        '
        'SearchForTopCountry
        '
        Me.SearchForTopCountry.BackColor = System.Drawing.Color.Black
        Me.SearchForTopCountry.ForeColor = System.Drawing.Color.Lime
        Me.SearchForTopCountry.Image = CType(resources.GetObject("SearchForTopCountry.Image"),System.Drawing.Image)
        Me.SearchForTopCountry.Name = "SearchForTopCountry"
        Me.SearchForTopCountry.Size = New System.Drawing.Size(195, 22)
        Me.SearchForTopCountry.Text = "&Search for Top Country"
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.Black
        Me.Reset.ForeColor = System.Drawing.Color.Lime
        Me.Reset.Image = CType(resources.GetObject("Reset.Image"),System.Drawing.Image)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(195, 22)
        Me.Reset.Text = "&Reset"
        '
        'Others
        '
        Me.Others.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysOnTop, Me.Minimal, Me.Normal})
        Me.Others.ForeColor = System.Drawing.Color.Lime
        Me.Others.Name = "Others"
        Me.Others.Size = New System.Drawing.Size(54, 20)
        Me.Others.Text = "&Others"
        '
        'AlwaysOnTop
        '
        Me.AlwaysOnTop.BackColor = System.Drawing.Color.Black
        Me.AlwaysOnTop.ForeColor = System.Drawing.Color.Lime
        Me.AlwaysOnTop.Image = CType(resources.GetObject("AlwaysOnTop.Image"),System.Drawing.Image)
        Me.AlwaysOnTop.Name = "AlwaysOnTop"
        Me.AlwaysOnTop.Size = New System.Drawing.Size(182, 22)
        Me.AlwaysOnTop.Text = "&Always on Top"
        '
        'Minimal
        '
        Me.Minimal.BackColor = System.Drawing.Color.Black
        Me.Minimal.ForeColor = System.Drawing.Color.Lime
        Me.Minimal.Image = CType(resources.GetObject("Minimal.Image"),System.Drawing.Image)
        Me.Minimal.Name = "Minimal"
        Me.Minimal.Size = New System.Drawing.Size(182, 22)
        Me.Minimal.Text = "&Minimal Table Mode"
        '
        'Normal
        '
        Me.Normal.BackColor = System.Drawing.Color.Black
        Me.Normal.ForeColor = System.Drawing.Color.Lime
        Me.Normal.Image = CType(resources.GetObject("Normal.Image"),System.Drawing.Image)
        Me.Normal.Name = "Normal"
        Me.Normal.Size = New System.Drawing.Size(182, 22)
        Me.Normal.Text = "&Normal Table Mode"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 732)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormMain"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DrWeabo - Coronavirus Tracker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(false)
        Me.MenuStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents WebBrowser As WebBrowser
    Friend WithEvents TimerRefresh As Timer
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents Menu As ToolStripMenuItem
    Friend WithEvents SearchYourCountry As ToolStripMenuItem
    Friend WithEvents Help As ToolStripMenuItem
    Friend WithEvents Donate As ToolStripMenuItem
    Friend WithEvents Quit As ToolStripMenuItem
    Friend WithEvents Edit As ToolStripMenuItem
    Friend WithEvents SearchForTopCountry As ToolStripMenuItem
    Friend WithEvents Reset As ToolStripMenuItem
    Friend WithEvents Others As ToolStripMenuItem
    Friend WithEvents AlwaysOnTop As ToolStripMenuItem
    Friend WithEvents Minimal As ToolStripMenuItem
    Friend WithEvents Normal As ToolStripMenuItem
End Class
