﻿Public Class BreakfastHandler
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
End Class