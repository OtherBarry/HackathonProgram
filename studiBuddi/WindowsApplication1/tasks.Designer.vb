<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tasks
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
        Me.btnNewTask = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAssignment = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.pbxHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGrey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Size = New System.Drawing.Size(146, 56)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "Tasks"
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
        'btnNewTask
        '
        Me.btnNewTask.BackColor = System.Drawing.Color.Gray
        Me.btnNewTask.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTask.Location = New System.Drawing.Point(12, 102)
        Me.btnNewTask.Name = "btnNewTask"
        Me.btnNewTask.Size = New System.Drawing.Size(145, 43)
        Me.btnNewTask.TabIndex = 27
        Me.btnNewTask.Text = "New Task"
        Me.btnNewTask.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PictureBox1.Location = New System.Drawing.Point(92, 196)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 480)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PictureBox2.Location = New System.Drawing.Point(775, 196)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(491, 480)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(209, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 38)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Upcoming Tasks"
        '
        'lblAssignment
        '
        Me.lblAssignment.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAssignment.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblAssignment.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblAssignment.ForeColor = System.Drawing.Color.White
        Me.lblAssignment.Location = New System.Drawing.Point(775, 209)
        Me.lblAssignment.Name = "lblAssignment"
        Me.lblAssignment.Size = New System.Drawing.Size(491, 38)
        Me.lblAssignment.TabIndex = 30
        Me.lblAssignment.Text = "Latest Assignment"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblSubject.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.Color.White
        Me.lblSubject.Location = New System.Drawing.Point(778, 264)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(85, 24)
        Me.lblSubject.TabIndex = 31
        Me.lblSubject.Text = "Subject"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(778, 300)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(110, 24)
        Me.lblDate.TabIndex = 32
        Me.lblDate.Text = "Due Date"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblLength.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.ForeColor = System.Drawing.Color.White
        Me.lblLength.Location = New System.Drawing.Point(778, 340)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(81, 24)
        Me.lblLength.TabIndex = 33
        Me.lblLength.Text = "Length"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(778, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 24)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Completion -  87.5%"
        '
        'tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnNewTask)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblAssignment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbxHome)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbxGrey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tasks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tasks"
        CType(Me.pbxHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGrey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxHome As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pbxGrey As System.Windows.Forms.PictureBox
    Friend WithEvents btnNewTask As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAssignment As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
