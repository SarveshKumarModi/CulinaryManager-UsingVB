Imports System.Data.SqlClient
Public Class LunchHandler
    Private Sub LunchHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CulinaryDBDataSet.Lunch' table. You can move, or remove it, as needed.
        Me.LunchTableAdapter.Fill(Me.CulinaryDBDataSet.Lunch)


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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "insert into Lunch values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        cmd = New SqlCommand(sql, conn)

        Try

            cmd.ExecuteNonQuery()
            MsgBox("Item details added successfully")
            Me.LunchTableAdapter.Fill(Me.CulinaryDBDataSet.Lunch)

        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString())
        End Try
        DataGridView1.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "delete from Lunch where Lunch='" & TextBox1.Text & "'"
        cmd = New SqlCommand(sql, conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data deleted sucessfully")
            Me.LunchTableAdapter.Fill(Me.CulinaryDBDataSet.Lunch)

        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try
        TextBox2.Text = ""
        TextBox1.Text = ""

        Dim cm As CurrencyManager = DirectCast(BindingContext(LunchBindingSource.DataSource), CurrencyManager)

        cm.Refresh()
    End Sub
End Class