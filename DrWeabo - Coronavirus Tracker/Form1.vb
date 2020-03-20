Imports System.Threading

Public Class FormMain

    '/
    '
    '       │ Author       : DrWeabo
    '       │ Name         : DrWeabo - Coronavirus Tracker
    '       │ Contact Me   : https://github.com/DrWeabo
    '       | Follow       : https://www.youtube.com/DrWeabo
    '       | Websites     : https://www.DrWeabo.com
    '       | This program is distributed for educational purposes only.
    '
    '\

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Welcome
        MsgBox("Welcome to DrWeabo - Coronavirus Tracker!", MsgBoxStyle.Exclamation)

        'Start Refresh
        TimerRefresh.Start

    End Sub

    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick

        'Refresh
        Thread.Sleep(1000)
        WebBrowser.Refresh

    End Sub

    Private Sub SearchYourCountry_Click(sender As Object, e As EventArgs) Handles SearchYourCountry.Click

        'Search Country
        FormSearchCountry.ShowDialog()

    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click

        'Help
        Shell("explorer.exe https://www.youtube.com/DrWeabo")

    End Sub

    Private Sub Donate_Click(sender As Object, e As EventArgs) Handles Donate.Click

        'Donate
        Shell("explorer.exe https://paypal.me/DrWeabo")

    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click

        'Quit
        Me.Close()

    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'Exit to Application
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You really want to close this application?", "Exit to Application", MessageBoxButtons.YesNo)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

    Private Sub SearchForTopCountry_Click(sender As Object, e As EventArgs) Handles SearchForTopCountry.Click

        'Search for Top Country
        FormSearchTopCountry.ShowDialog()

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Reset.Click

        'Reset all settings
        Me.Text = ("DrWeabo - Coronavirus Tracker")
        WebBrowser.Navigate("https://corona-stats.online/")

    End Sub

    Private Sub AlwaysOnTop_Click(sender As Object, e As EventArgs) Handles AlwaysOnTop.Click

        'Always on Top
        If Me.TopMost = True Then
            Me.TopMost = False
            Else
            Me.TopMost = True
        End If

    End Sub

    Private Sub Minimal_Click(sender As Object, e As EventArgs) Handles Minimal.Click

        'Minimal Mode
        Me.Text =  ("DrWeabo - Coronavirus Tracker | (MINIMAL COMPACT TABLE MODE)")
        WebBrowser.Navigate("https://corona-stats.online/?minimal=true")

    End Sub

    Private Sub Normal_Click(sender As Object, e As EventArgs) Handles Normal.Click

        'Normal Mode
        Me.Text = ("DrWeabo - Coronavirus Tracker | (NORMAL TABLE MODE)")
        WebBrowser.Navigate("https://corona-stats.online/")

    End Sub
End Class
