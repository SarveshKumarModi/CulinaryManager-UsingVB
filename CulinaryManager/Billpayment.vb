Imports System.Data.SqlClient

Public Class Billpayment

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sum As Integer
        Dim a As Integer
        If TextBox1.Text = "" Then
            MsgBox("PLease fill in the credentials")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please fill in the credentials")
        Else
            sql = "insert into Request(CustomerID,Foodtype,Foodnames) values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "')"
            Me.RequestTableAdapter.Fill(Me.CulinaryDBDataSet.Request)
            cmd = New SqlClient.SqlCommand(sql, conn)
            Try
                cmd.ExecuteNonQuery()
                Me.Hide()
                HomePage.Show()
                sum = Val(TextBox2.Text) * Val(TextBox4.Text)
                MsgBox("Your order will be delivered soon with the price Rs." + sum.ToString)
                Me.RequestTableAdapter.Fill(Me.CulinaryDBDataSet.Request)


            Catch ae As SqlException
                MessageBox.Show(ae.Message.ToString())
            End Try
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox2.Text = ""
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Billpayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'CulinaryDBDataSet.Request' table. You can move, or remove it, as needed.
        Me.RequestTableAdapter.Fill(Me.CulinaryDBDataSet.Request)
        conn = New SqlConnection(connectionstring)
        executesqlstmt(sql)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class