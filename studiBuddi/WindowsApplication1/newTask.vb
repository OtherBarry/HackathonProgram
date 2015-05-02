Public Class newTask

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tasks.Show()
        Me.Close()
    End Sub

    Private Sub btnNewTask_Click(sender As Object, e As EventArgs) Handles btnSaveTask.Click
        TaskCount += 1
        Dim context = New TaskList()
        Dim task As New taskDatabase()
        With task
            .ID = TaskCount
            .name = txtName.Text
            .type = txtType.Text
            .length = txtLength.Text
            .duedate = dtpDateDue.Value
            .internet = cmbInternet.SelectedItem
            .notes = txtNotes.Text
            .subject = cmbSubject.SelectedItem
        End With

        context.Tasks.Add(task)

        context.SaveChanges()

        tasks.lblAssignment.Text = context.Tasks.Find(TaskCount).name
        tasks.lblDate.Text = "Due: " + context.Tasks.Find(TaskCount).duedate.ToString
        tasks.lblLength.Text = "Task Length: " + (context.Tasks.Find(TaskCount).length).ToString
        tasks.lblSubject.Text = "Subject: " + context.Tasks.Find(TaskCount).subject

        context.Dispose()
        tasks.Show()
        Me.Close()
    End Sub
End Class