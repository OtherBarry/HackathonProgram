﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        'tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnNewTask)
        Me.Controls.Add(Me.pbxHome)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbxGrey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tasks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tasks"
        CType(Me.pbxHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGrey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxHome As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pbxGrey As System.Windows.Forms.PictureBox
    Friend WithEvents btnNewTask As System.Windows.Forms.Button
End Class
