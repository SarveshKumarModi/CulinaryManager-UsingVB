Public Class DinnerHandler
    Private Sub DinnerHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CulinaryDBDataSet.Dinner' table. You can move, or remove it, as needed.
        Me.DinnerTableAdapter.Fill(Me.CulinaryDBDataSet.Dinner)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminHome.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainPage.Show()
    End Sub
End Class