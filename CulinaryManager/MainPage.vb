Imports System.Data.SqlClient

Public Class MainPage
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Credits.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        AdminLogin.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        SignUp.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please fill in the credentials")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please fill in the credentials")
        Else
            sql = "select CustomerID, Password from Customer where CustomerID = '" & TextBox1.Text & "'AND Password = '" & TextBox2.Text & "'"
            cmd = New SqlCommand(Sql, conn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            Try
                If dr.Read = False Then
                    MessageBox.Show(“Login Failed !!”)
                Else
                    MessageBox.Show(“Login Successful”)
                    Me.Hide()
                    HomePage.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            dr.Close()

            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connectionstring)
        executesqlstmt(Sql)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
