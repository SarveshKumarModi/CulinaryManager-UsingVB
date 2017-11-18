Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class SignUp
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainPage.Show()

    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please fill in the credentials")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please fill in the credentials")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please fill in the credentials")
        ElseIf TextBox4.Text = "" Then
            MsgBox("Please fill in the credentials")
        Else sql = "insert into Customer (CustomerID, Password, Email, Phone) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"

            cmd = New SqlClient.SqlCommand(sql, conn)

            Try
                cmd.ExecuteNonQuery()
                MsgBox("You have successfully signed up !")
                Me.Hide()
                HomePage.Show()


            Catch ae As SqlException
                MessageBox.Show(ae.Message.ToString())
            End Try
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox2.Text = ""
            TextBox1.Text = ""
        End If
    End Sub




    Private Sub TextBox4_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = CChar(ChrW(Keys.Back)) Or e.KeyChar = CChar(ChrW(Keys.Space)) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TextBox4_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Leave
        If (TextBox4.TextLength < 10 Or TextBox4.TextLength > 10) Then
            MsgBox("Mobile Number Should Be of 10 Digits", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub textbox3_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        Dim check As Boolean
        check = EmailAddressCheck(TextBox3.Text)
        If check = False Then
            MsgBox("Enter a Valid Email", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub
    Function EmailAddressCheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailaddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailaddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If
    End Function

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class