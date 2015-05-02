Public Class home

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        work.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        calendar.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        tasks.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        social.Show()
        Me.Hide()
    End Sub

    Private Sub pbxSettings_Click(sender As Object, e As EventArgs) Handles pbxSettings.Click
        settings.Show()
        Me.Hide()
    End Sub
End Class