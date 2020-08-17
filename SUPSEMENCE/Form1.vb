Imports MySql.Data.MySqlClient

Public Class Form1
    Dim currentPage As Form = Nothing

    Private Async Sub Form1_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        Await DBConnection.StartConnectionAsync()
        NavigateTo(FormSpeculations, ButtonProductions)
    End Sub
    Private Async Sub Form1_FormClosedAsync(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Await DBConnection.StopConnectionAsync()
    End Sub

    Private Sub ButtonProductions_Click(sender As Object, e As EventArgs) Handles ButtonProductions.Click
        NavigateTo(FormSpeculations, ButtonProductions)
    End Sub
    Private Sub ButtonCommandes_Click(sender As Object, e As EventArgs) Handles ButtonCommandes.Click
        NavigateTo(FormCommandes, ButtonCommandes)
    End Sub

    Private Sub ButtonParam_Click(sender As Object, e As EventArgs) Handles ButtonParam.Click
        NavigateTo(FormParametres, ButtonParam)
    End Sub

    Private Sub ButtonStats_Click(sender As Object, e As EventArgs) Handles ButtonStats.Click
        NavigateTo(FormRapports, ButtonStats)
    End Sub

    Private Sub NavigateTo(newPage As Form, markerButton As Button)

        If currentPage Is newPage Then
            Return
        End If
        If currentPage IsNot Nothing Then
            currentPage.Close()
        End If

        currentPage = newPage
        newPage.TopLevel = False
        newPage.FormBorderStyle = FormBorderStyle.None
        newPage.Dock = DockStyle.Fill
        BodyPanel.Controls.Add(newPage)
        BodyPanel.Tag = newPage
        newPage.BringToFront()
        newPage.Show()

        CurrentPageMarker.Visible = False
        CurrentPageMarker.Location = New Point(0, markerButton.Location.Y)
        CurrentPageMarker.Visible = True

    End Sub
End Class
