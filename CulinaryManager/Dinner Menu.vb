Imports System.Data.SqlClient
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "delete from Dinner where Dinner='" & TextBox1.Text & "'"
        cmd = New SqlCommand(sql, conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data deleted sucessfully")
            Me.DinnerTableAdapter.Fill(Me.CulinaryDBDataSet.Dinner)

        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try
        TextBox2.Text = ""
        TextBox1.Text = ""

        Dim cm As CurrencyManager = DirectCast(BindingContext(DinnerBindingSource.DataSource), CurrencyManager)
        cm.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "insert into Dinner values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        cmd = New SqlCommand(sql, conn)

        Try

            cmd.ExecuteNonQuery()
            MsgBox("Item details added successfully")
            Me.DinnerTableAdapter.Fill(Me.CulinaryDBDataSet.Dinner)

        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString())
        End Try
        DataGridView1.Refresh()
        Dim cm As CurrencyManager = DirectCast(BindingContext(DinnerBindingSource.DataSource), CurrencyManager)

        cm.Refresh()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 
        DataGridView1.RefreshEdit()
    End Sub
End Class