Public Class HomePage
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CulinaryDBDataSet.Dinner' table. You can move, or remove it, as needed.
        Me.DinnerTableAdapter.Fill(Me.CulinaryDBDataSet.Dinner)
        'TODO: This line of code loads data into the 'CulinaryDBDataSet.Lunch' table. You can move, or remove it, as needed.
        Me.LunchTableAdapter.Fill(Me.CulinaryDBDataSet.Lunch)
        'TODO: This line of code loads data into the 'CulinaryDBDataSet.Breakfast' table. You can move, or remove it, as needed.
        Me.BreakfastTableAdapter.Fill(Me.CulinaryDBDataSet.Breakfast)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Billpayment.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainPage.Show()
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount = 1
    End Sub
End Class