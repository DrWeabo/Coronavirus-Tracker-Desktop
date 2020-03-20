Public Class FormSearchCountry
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        'Search Country
        'Example https://corona-stats.online/ <country>
        FormMain.Text = ("DrWeabo - Coronavirus Tracker | Country [" & TextBoxSearch.Text & "]")
        FormMain.WebBrowser.Navigate("https://corona-stats.online/" & TextBoxSearch.Text)
        Me.Close

    End Sub

    Private Sub FormSearchCountry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Add
        Me.AcceptButton = ButtonSearch

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Cancel Search
        Me.Close

    End Sub
End Class