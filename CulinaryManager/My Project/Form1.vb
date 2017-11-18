Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        lblper.Text = ProgressBar1.Value
        If ProgressBar1.Value <= 20 Then
            lblstatus.Text = "Initializing.."
        ElseIf ProgressBar1.Value <= 50 Then
            lblstatus.Text = "Loading components..."
        ElseIf ProgressBar1.Value <= 85 Then
            lblstatus.Text = "Integrating Database...."
        ElseIf ProgressBar1.Value <= 99 Then
            lblstatus.Text = "Starting Application....."
        End If
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            MainPage.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class