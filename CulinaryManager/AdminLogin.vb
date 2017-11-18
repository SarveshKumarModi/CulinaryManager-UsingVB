Imports System.Data.SqlClient

Public Class AdminLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainPage.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please fil in the credentials")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please fil in the credentials")
        Else sql = "select Admin, Password from Admin where Admin = '" & TextBox1.Text & "'AND Password = '" & TextBox2.Text & "'"
            cmd = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Try
            If dr.Read = False Then
                    MessageBox.Show(“Login Failed ”)
                Else
                    MessageBox.Show(“Login successful !”)
                    Me.Hide()
                    AdminHome.Show()
                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Close()


        TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Credits.Show()
    End Sub
End Class