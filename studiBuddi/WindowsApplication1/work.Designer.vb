<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class work
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbxHome = New System.Windows.Forms.PictureBox()
        Me.pbxGrey = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWordCount = New System.Windows.Forms.Label()
        CType(Me.pbxHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGrey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Gray
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Location = New System.Drawing.Point(11, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(258, 56)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "Text Editor"
        '
        'pbxHome
        '
        Me.pbxHome.BackColor = System.Drawing.Color.Gray
        Me.pbxHome.Image = Global.WindowsApplication1.My.Resources.Resources.home
        Me.pbxHome.Location = New System.Drawing.Point(1271, 0)
        Me.pbxHome.Name = "pbxHome"
        Me.pbxHome.Size = New System.Drawing.Size(96, 96)
        Me.pbxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxHome.TabIndex = 26
        Me.pbxHome.TabStop = False
        '
        'pbxGrey
        '
        Me.pbxGrey.BackColor = System.Drawing.Color.Gray
        Me.pbxGrey.Location = New System.Drawing.Point(0, 0)
        Me.pbxGrey.Name = "pbxGrey"
        Me.pbxGrey.Size = New System.Drawing.Size(1367, 96)
        Me.pbxGrey.TabIndex = 24
        Me.pbxGrey.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(775, 192)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(144, 13)
        Me.lblName.TabIndex = 27
        Me.lblName.Text = "Write a motherfucking essay."
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(775, 223)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(43, 13)
        Me.lblSubject.TabIndex = 28
        Me.lblSubject.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(775, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Due 3/5/2015"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(775, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "1000 words"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(96, 192)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(491, 480)
        Me.RichTextBox1.TabIndex = 31
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(775, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Notes"
        '
        'lblWordCount
        '
        Me.lblWordCount.AutoSize = True
        Me.lblWordCount.Location = New System.Drawing.Point(506, 675)
        Me.lblWordCount.Name = "lblWordCount"
        Me.lblWordCount.Size = New System.Drawing.Size(81, 13)
        Me.lblWordCount.TabIndex = 33
        Me.lblWordCount.Text = "x out of y words"
        '
        'work
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.lblWordCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbxHome)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbxGrey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "work"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "work"
        CType(Me.pbxHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGrey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxHome As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pbxGrey As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWordCount As System.Windows.Forms.Label
End Class
