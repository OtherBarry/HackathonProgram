Public Class newTask

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnNewTask_Click(sender As Object, e As EventArgs) Handles btnSaveTask.Click
        Dim context = New TaskList()
        Dim task1 As New taskDatabase()
        With task1
            .ID = x
            .name = txtName.Text
            .type = txtType.Text
            .length = txtLength.Text
            .duedate = dtpDateDue.Value
        End With
        idnum = TextBox1.Text
        context.Tasks.Add(task1)

        context.SaveChanges()

        context.Dispose()
    End Sub

End Class