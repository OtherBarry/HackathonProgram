﻿Public Class tasks

    Private Sub pbxHome_Click(sender As Object, e As EventArgs) Handles pbxHome.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub btnNewTask_Click(sender As Object, e As EventArgs) Handles btnNewTask.Click
        newTask.Show()
        Me.Hide()
    End Sub
End Class