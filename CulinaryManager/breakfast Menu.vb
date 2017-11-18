Imports System.Data.SqlClient
Public Class breakfast
    Private Sub BreakfastHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CulinaryDBDataSet.Breakfast' table. You can move, or remove it, as needed.
        Me.BreakfastTableAdapter.Fill(Me.CulinaryDBDataSet.Breakfast)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

        AdminHome.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainPage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "insert into Breakfast values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        cmd = New SqlCommand(sql, conn)

        Try

            cmd.ExecuteNonQuery()
            MsgBox("iItem details added successfully")
            Me.BreakfastTableAdapter.Fill(Me.CulinaryDBDataSet.Breakfast)


        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "delete from Breakfast where Breakfast='" & TextBox1.Text & "'"
        cmd = New SqlCommand(sql, conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data deleted sucessfully")
            Me.BreakfastTableAdapter.Fill(Me.CulinaryDBDataSet.Breakfast)

        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try
        TextBox2.Text = ""
        TextBox1.Text = ""
        Me.BreakfastTableAdapter.Fill(Me.CulinaryDBDataSet.Breakfast)
        DataGridView1.Refresh()
    End Sub
End Class