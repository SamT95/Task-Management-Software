<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubtaskEdit
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
        Me.chkboxComplete = New System.Windows.Forms.CheckBox()
        Me.lblSubtaskCompletion = New System.Windows.Forms.Label()
        Me.lblSubtaskEnd = New System.Windows.Forms.Label()
        Me.lblSubtask2 = New System.Windows.Forms.Label()
        Me.txtSubtaskDescEdit = New System.Windows.Forms.TextBox()
        Me.btnSubtaskSave = New System.Windows.Forms.Button()
        Me.btnDelSubtask = New System.Windows.Forms.Button()
        Me.txtNewSubtaskTitle = New System.Windows.Forms.TextBox()
        Me.lblSubtaskTitleEdit = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'chkboxComplete
        '
        Me.chkboxComplete.AutoSize = True
        Me.chkboxComplete.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxComplete.Location = New System.Drawing.Point(12, 233)
        Me.chkboxComplete.Name = "chkboxComplete"
        Me.chkboxComplete.Size = New System.Drawing.Size(85, 19)
        Me.chkboxComplete.TabIndex = 10
        Me.chkboxComplete.Text = "Is Complete"
        Me.chkboxComplete.UseVisualStyleBackColor = True
        '
        'lblSubtaskCompletion
        '
        Me.lblSubtaskCompletion.AutoSize = True
        Me.lblSubtaskCompletion.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtaskCompletion.Location = New System.Drawing.Point(272, 179)
        Me.lblSubtaskCompletion.Name = "lblSubtaskCompletion"
        Me.lblSubtaskCompletion.Size = New System.Drawing.Size(93, 15)
        Me.lblSubtaskCompletion.TabIndex = 9
        Me.lblSubtaskCompletion.Text = "Completion Date:"
        '
        'lblSubtaskEnd
        '
        Me.lblSubtaskEnd.AutoSize = True
        Me.lblSubtaskEnd.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtaskEnd.Location = New System.Drawing.Point(12, 179)
        Me.lblSubtaskEnd.Name = "lblSubtaskEnd"
        Me.lblSubtaskEnd.Size = New System.Drawing.Size(55, 15)
        Me.lblSubtaskEnd.TabIndex = 8
        Me.lblSubtaskEnd.Text = "End Date:"
        '
        'lblSubtask2
        '
        Me.lblSubtask2.AutoSize = True
        Me.lblSubtask2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtask2.Location = New System.Drawing.Point(9, 66)
        Me.lblSubtask2.Name = "lblSubtask2"
        Me.lblSubtask2.Size = New System.Drawing.Size(145, 15)
        Me.lblSubtask2.TabIndex = 7
        Me.lblSubtask2.Text = "Brief Description of Subtask"
        '
        'txtSubtaskDescEdit
        '
        Me.txtSubtaskDescEdit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtaskDescEdit.Location = New System.Drawing.Point(12, 93)
        Me.txtSubtaskDescEdit.Multiline = True
        Me.txtSubtaskDescEdit.Name = "txtSubtaskDescEdit"
        Me.txtSubtaskDescEdit.Size = New System.Drawing.Size(354, 72)
        Me.txtSubtaskDescEdit.TabIndex = 6
        '
        'btnSubtaskSave
        '
        Me.btnSubtaskSave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtaskSave.Location = New System.Drawing.Point(52, 273)
        Me.btnSubtaskSave.Name = "btnSubtaskSave"
        Me.btnSubtaskSave.Size = New System.Drawing.Size(95, 23)
        Me.btnSubtaskSave.TabIndex = 11
        Me.btnSubtaskSave.Text = "Save Changes"
        Me.btnSubtaskSave.UseVisualStyleBackColor = True
        '
        'btnDelSubtask
        '
        Me.btnDelSubtask.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelSubtask.Location = New System.Drawing.Point(275, 273)
        Me.btnDelSubtask.Name = "btnDelSubtask"
        Me.btnDelSubtask.Size = New System.Drawing.Size(104, 23)
        Me.btnDelSubtask.TabIndex = 12
        Me.btnDelSubtask.Text = "Remove Subtask"
        Me.btnDelSubtask.UseVisualStyleBackColor = True
        '
        'txtNewSubtaskTitle
        '
        Me.txtNewSubtaskTitle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewSubtaskTitle.Location = New System.Drawing.Point(12, 34)
        Me.txtNewSubtaskTitle.Name = "txtNewSubtaskTitle"
        Me.txtNewSubtaskTitle.Size = New System.Drawing.Size(354, 21)
        Me.txtNewSubtaskTitle.TabIndex = 13
        '
        'lblSubtaskTitleEdit
        '
        Me.lblSubtaskTitleEdit.AutoSize = True
        Me.lblSubtaskTitleEdit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtaskTitleEdit.Location = New System.Drawing.Point(9, 9)
        Me.lblSubtaskTitleEdit.Name = "lblSubtaskTitleEdit"
        Me.lblSubtaskTitleEdit.Size = New System.Drawing.Size(71, 15)
        Me.lblSubtaskTitleEdit.TabIndex = 14
        Me.lblSubtaskTitleEdit.Text = "Subtask Title"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(66, 179)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 15
        '
        'SubtaskEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 308)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblSubtaskTitleEdit)
        Me.Controls.Add(Me.txtNewSubtaskTitle)
        Me.Controls.Add(Me.btnDelSubtask)
        Me.Controls.Add(Me.btnSubtaskSave)
        Me.Controls.Add(Me.chkboxComplete)
        Me.Controls.Add(Me.lblSubtaskCompletion)
        Me.Controls.Add(Me.lblSubtaskEnd)
        Me.Controls.Add(Me.lblSubtask2)
        Me.Controls.Add(Me.txtSubtaskDescEdit)
        Me.Name = "SubtaskEdit"
        Me.Text = "SubtaskEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkboxComplete As CheckBox
    Friend WithEvents lblSubtaskCompletion As Label
    Friend WithEvents lblSubtaskEnd As Label
    Friend WithEvents lblSubtask2 As Label
    Friend WithEvents txtSubtaskDescEdit As TextBox
    Friend WithEvents btnSubtaskSave As Button
    Friend WithEvents btnDelSubtask As Button
    Friend WithEvents txtNewSubtaskTitle As TextBox
    Friend WithEvents lblSubtaskTitleEdit As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
