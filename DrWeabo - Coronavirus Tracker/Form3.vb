Public Class FormSearchTopCountry
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        'Search Top Country
        'Example https://corona-stats.online?top= <amount>
        FormMain.Text = ("DrWeabo - Coronavirus Tracker | Top Country [" & TextBoxSearch.Text & "]")
        FormMain.WebBrowser.Navigate("https://corona-stats.online?top=" & TextBoxSearch.Text)
        Me.Close

    End Sub

    Private Sub FormSearchTopCountry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Add
        Me.AcceptButton = ButtonSearch

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Cancel Search
        Me.Close

    End Sub
End Class