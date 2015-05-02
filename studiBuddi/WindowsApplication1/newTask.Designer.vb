<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newTask
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
        Me.pbxGrey = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateDue = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblInternet = New System.Windows.Forms.Label()
        Me.cmbInternet = New System.Windows.Forms.ComboBox()
        Me.btnSaveTask = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
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
        Me.lblTitle.Size = New System.Drawing.Size(243, 56)
        Me.lblTitle.TabIndex = 28
        Me.lblTitle.Text = "New Task"
        '
        'pbxGrey
        '
        Me.pbxGrey.BackColor = System.Drawing.Color.Gray
        Me.pbxGrey.Location = New System.Drawing.Point(0, 0)
        Me.pbxGrey.Name = "pbxGrey"
        Me.pbxGrey.Size = New System.Drawing.Size(520, 96)
        Me.pbxGrey.TabIndex = 27
        Me.pbxGrey.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(17, 148)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(95, 21)
        Me.lblName.TabIndex = 30
        Me.lblName.Text = "Task Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(21, 172)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(233, 20)
        Me.txtName.TabIndex = 31
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(21, 221)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(233, 20)
        Me.txtType.TabIndex = 33
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(17, 197)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(84, 21)
        Me.lblType.TabIndex = 32
        Me.lblType.Text = "Task Type"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(21, 271)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(233, 197)
        Me.txtNotes.TabIndex = 35
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(17, 247)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(141, 21)
        Me.lblNotes.TabIndex = 34
        Me.lblNotes.Text = "Additional Notes"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(303, 172)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(77, 20)
        Me.txtLength.TabIndex = 36
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(299, 148)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(121, 21)
        Me.lblLength.TabIndex = 37
        Me.lblLength.Text = "Length of Task"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(303, 220)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Subject"
        '
        'dtpDateDue
        '
        Me.dtpDateDue.Location = New System.Drawing.Point(303, 271)
        Me.dtpDateDue.Name = "dtpDateDue"
        Me.dtpDateDue.Size = New System.Drawing.Size(198, 20)
        Me.dtpDateDue.TabIndex = 40
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(299, 247)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(86, 21)
        Me.lblDate.TabIndex = 41
        Me.lblDate.Text = "Date Due"
        '
        'lblInternet
        '
        Me.lblInternet.AutoSize = True
        Me.lblInternet.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternet.Location = New System.Drawing.Point(299, 294)
        Me.lblInternet.Name = "lblInternet"
        Me.lblInternet.Size = New System.Drawing.Size(148, 21)
        Me.lblInternet.TabIndex = 43
        Me.lblInternet.Text = "Internet Required"
        '
        'cmbInternet
        '
        Me.cmbInternet.FormattingEnabled = True
        Me.cmbInternet.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbInternet.Location = New System.Drawing.Point(303, 317)
        Me.cmbInternet.Name = "cmbInternet"
        Me.cmbInternet.Size = New System.Drawing.Size(65, 21)
        Me.cmbInternet.TabIndex = 42
        '
        'btnSaveTask
        '
        Me.btnSaveTask.BackColor = System.Drawing.Color.Gray
        Me.btnSaveTask.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTask.Location = New System.Drawing.Point(303, 376)
        Me.btnSaveTask.Name = "btnSaveTask"
        Me.btnSaveTask.Size = New System.Drawing.Size(145, 43)
        Me.btnSaveTask.TabIndex = 44
        Me.btnSaveTask.Text = "Save Task"
        Me.btnSaveTask.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(303, 425)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(145, 43)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'newTask
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(520, 496)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveTask)
        Me.Controls.Add(Me.lblInternet)
        Me.Controls.Add(Me.cmbInternet)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dtpDateDue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbxGrey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newTask"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tasks"
        CType(Me.pbxGrey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pbxGrey As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblInternet As System.Windows.Forms.Label
    Friend WithEvents cmbInternet As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveTask As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
