Public Class work

    Private Sub pbxHome_Click(sender As Object, e As EventArgs) Handles pbxHome.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub work_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Static rex As New System.Text.RegularExpressions.Regex("\b", System.Text.RegularExpressions.RegexOptions.Compiled Or System.Text.RegularExpressions.RegexOptions.Multiline)
        lblWordCount.Text = (rex.Matches(RichTextBox1.Text).Count / 2).ToString() + " out of 0 words"
    End Sub
End Class