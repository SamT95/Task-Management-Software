<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Task
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
        Me.lblCompletionDate = New System.Windows.Forms.Label()
        Me.lblCompletionDateTag = New System.Windows.Forms.Label()
        Me.dtpEndNew = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDateNew = New System.Windows.Forms.Label()
        Me.cbPriorityNew = New System.Windows.Forms.ComboBox()
        Me.lblPriorityNew = New System.Windows.Forms.Label()
        Me.txtDescriptionNew = New System.Windows.Forms.TextBox()
        Me.lblDescriptionNew = New System.Windows.Forms.Label()
        Me.txtTaskNameNew = New System.Windows.Forms.TextBox()
        Me.lblTaskNameNew = New System.Windows.Forms.Label()
        Me.cbReminderNew = New System.Windows.Forms.ComboBox()
        Me.lblRemindersNew = New System.Windows.Forms.Label()
        Me.btnUpdateTask = New System.Windows.Forms.Button()
        Me.btnSubtasks = New System.Windows.Forms.Button()
        Me.btnViewSubtasks = New System.Windows.Forms.Button()
        Me.btnDelTask = New System.Windows.Forms.Button()
        Me.btnPutonHold = New System.Windows.Forms.Button()
        Me.lblStartDateNew = New System.Windows.Forms.Label()
        Me.dtpStartDateNew = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblCompletionDate
        '
        Me.lblCompletionDate.AutoSize = True
        Me.lblCompletionDate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletionDate.Location = New System.Drawing.Point(357, 209)
        Me.lblCompletionDate.Name = "lblCompletionDate"
        Me.lblCompletionDate.Size = New System.Drawing.Size(28, 15)
        Me.lblCompletionDate.TabIndex = 27
        Me.lblCompletionDate.Text = "N/A"
        '
        'lblCompletionDateTag
        '
        Me.lblCompletionDateTag.AutoSize = True
        Me.lblCompletionDateTag.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletionDateTag.Location = New System.Drawing.Point(357, 187)
        Me.lblCompletionDateTag.Name = "lblCompletionDateTag"
        Me.lblCompletionDateTag.Size = New System.Drawing.Size(90, 15)
        Me.lblCompletionDateTag.TabIndex = 26
        Me.lblCompletionDateTag.Text = "Completion Date"
        '
        'dtpEndNew
        '
        Me.dtpEndNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndNew.Location = New System.Drawing.Point(176, 203)
        Me.dtpEndNew.Name = "dtpEndNew"
        Me.dtpEndNew.Size = New System.Drawing.Size(148, 21)
        Me.dtpEndNew.TabIndex = 25
        '
        'lblEndDateNew
        '
        Me.lblEndDateNew.AutoSize = True
        Me.lblEndDateNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDateNew.Location = New System.Drawing.Point(173, 187)
        Me.lblEndDateNew.Name = "lblEndDateNew"
        Me.lblEndDateNew.Size = New System.Drawing.Size(52, 15)
        Me.lblEndDateNew.TabIndex = 23
        Me.lblEndDateNew.Text = "End Date"
        '
        'cbPriorityNew
        '
        Me.cbPriorityNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPriorityNew.FormattingEnabled = True
        Me.cbPriorityNew.Items.AddRange(New Object() {"High", "Medium", "Low"})
        Me.cbPriorityNew.Location = New System.Drawing.Point(364, 41)
        Me.cbPriorityNew.Name = "cbPriorityNew"
        Me.cbPriorityNew.Size = New System.Drawing.Size(101, 23)
        Me.cbPriorityNew.TabIndex = 21
        '
        'lblPriorityNew
        '
        Me.lblPriorityNew.AutoSize = True
        Me.lblPriorityNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriorityNew.Location = New System.Drawing.Point(361, 25)
        Me.lblPriorityNew.Name = "lblPriorityNew"
        Me.lblPriorityNew.Size = New System.Drawing.Size(45, 15)
        Me.lblPriorityNew.TabIndex = 20
        Me.lblPriorityNew.Text = "Priority"
        '
        'txtDescriptionNew
        '
        Me.txtDescriptionNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescriptionNew.Location = New System.Drawing.Point(12, 110)
        Me.txtDescriptionNew.Multiline = True
        Me.txtDescriptionNew.Name = "txtDescriptionNew"
        Me.txtDescriptionNew.Size = New System.Drawing.Size(453, 52)
        Me.txtDescriptionNew.TabIndex = 19
        '
        'lblDescriptionNew
        '
        Me.lblDescriptionNew.AutoSize = True
        Me.lblDescriptionNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionNew.Location = New System.Drawing.Point(9, 83)
        Me.lblDescriptionNew.Name = "lblDescriptionNew"
        Me.lblDescriptionNew.Size = New System.Drawing.Size(130, 15)
        Me.lblDescriptionNew.TabIndex = 18
        Me.lblDescriptionNew.Text = "Brief Description of Task"
        '
        'txtTaskNameNew
        '
        Me.txtTaskNameNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaskNameNew.Location = New System.Drawing.Point(10, 42)
        Me.txtTaskNameNew.Name = "txtTaskNameNew"
        Me.txtTaskNameNew.Size = New System.Drawing.Size(223, 21)
        Me.txtTaskNameNew.TabIndex = 17
        '
        'lblTaskNameNew
        '
        Me.lblTaskNameNew.AutoSize = True
        Me.lblTaskNameNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskNameNew.Location = New System.Drawing.Point(7, 25)
        Me.lblTaskNameNew.Name = "lblTaskNameNew"
        Me.lblTaskNameNew.Size = New System.Drawing.Size(61, 15)
        Me.lblTaskNameNew.TabIndex = 16
        Me.lblTaskNameNew.Text = "Task Name"
        '
        'cbReminderNew
        '
        Me.cbReminderNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReminderNew.FormattingEnabled = True
        Me.cbReminderNew.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbReminderNew.Location = New System.Drawing.Point(20, 265)
        Me.cbReminderNew.Name = "cbReminderNew"
        Me.cbReminderNew.Size = New System.Drawing.Size(101, 23)
        Me.cbReminderNew.TabIndex = 29
        '
        'lblRemindersNew
        '
        Me.lblRemindersNew.AutoSize = True
        Me.lblRemindersNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemindersNew.Location = New System.Drawing.Point(17, 249)
        Me.lblRemindersNew.Name = "lblRemindersNew"
        Me.lblRemindersNew.Size = New System.Drawing.Size(81, 15)
        Me.lblRemindersNew.TabIndex = 28
        Me.lblRemindersNew.Text = "Set Reminders?"
        '
        'btnUpdateTask
        '
        Me.btnUpdateTask.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTask.Location = New System.Drawing.Point(16, 303)
        Me.btnUpdateTask.Name = "btnUpdateTask"
        Me.btnUpdateTask.Size = New System.Drawing.Size(120, 25)
        Me.btnUpdateTask.TabIndex = 30
        Me.btnUpdateTask.Text = "Save Changes"
        Me.btnUpdateTask.UseVisualStyleBackColor = True
        '
        'btnSubtasks
        '
        Me.btnSubtasks.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtasks.Location = New System.Drawing.Point(348, 265)
        Me.btnSubtasks.Name = "btnSubtasks"
        Me.btnSubtasks.Size = New System.Drawing.Size(120, 25)
        Me.btnSubtasks.TabIndex = 31
        Me.btnSubtasks.Text = "Create Subtasks"
        Me.btnSubtasks.UseVisualStyleBackColor = True
        '
        'btnViewSubtasks
        '
        Me.btnViewSubtasks.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSubtasks.Location = New System.Drawing.Point(348, 303)
        Me.btnViewSubtasks.Name = "btnViewSubtasks"
        Me.btnViewSubtasks.Size = New System.Drawing.Size(120, 25)
        Me.btnViewSubtasks.TabIndex = 32
        Me.btnViewSubtasks.Text = "View Subtasks"
        Me.btnViewSubtasks.UseVisualStyleBackColor = True
        '
        'btnDelTask
        '
        Me.btnDelTask.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelTask.Location = New System.Drawing.Point(192, 303)
        Me.btnDelTask.Name = "btnDelTask"
        Me.btnDelTask.Size = New System.Drawing.Size(120, 25)
        Me.btnDelTask.TabIndex = 33
        Me.btnDelTask.Text = "Remove Task"
        Me.btnDelTask.UseVisualStyleBackColor = True
        '
        'btnPutonHold
        '
        Me.btnPutonHold.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPutonHold.Location = New System.Drawing.Point(192, 265)
        Me.btnPutonHold.Name = "btnPutonHold"
        Me.btnPutonHold.Size = New System.Drawing.Size(120, 25)
        Me.btnPutonHold.TabIndex = 34
        Me.btnPutonHold.Text = "Put on Hold"
        Me.btnPutonHold.UseVisualStyleBackColor = True
        '
        'lblStartDateNew
        '
        Me.lblStartDateNew.AutoSize = True
        Me.lblStartDateNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDateNew.Location = New System.Drawing.Point(17, 187)
        Me.lblStartDateNew.Name = "lblStartDateNew"
        Me.lblStartDateNew.Size = New System.Drawing.Size(56, 15)
        Me.lblStartDateNew.TabIndex = 35
        Me.lblStartDateNew.Text = "Start Date"
        '
        'dtpStartDateNew
        '
        Me.dtpStartDateNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDateNew.Location = New System.Drawing.Point(20, 203)
        Me.dtpStartDateNew.Name = "dtpStartDateNew"
        Me.dtpStartDateNew.Size = New System.Drawing.Size(148, 21)
        Me.dtpStartDateNew.TabIndex = 36
        '
        'Edit_Task
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(490, 350)
        Me.Controls.Add(Me.dtpStartDateNew)
        Me.Controls.Add(Me.lblStartDateNew)
        Me.Controls.Add(Me.btnPutonHold)
        Me.Controls.Add(Me.btnDelTask)
        Me.Controls.Add(Me.btnViewSubtasks)
        Me.Controls.Add(Me.btnSubtasks)
        Me.Controls.Add(Me.btnUpdateTask)
        Me.Controls.Add(Me.cbReminderNew)
        Me.Controls.Add(Me.lblRemindersNew)
        Me.Controls.Add(Me.lblCompletionDate)
        Me.Controls.Add(Me.lblCompletionDateTag)
        Me.Controls.Add(Me.dtpEndNew)
        Me.Controls.Add(Me.lblEndDateNew)
        Me.Controls.Add(Me.cbPriorityNew)
        Me.Controls.Add(Me.lblPriorityNew)
        Me.Controls.Add(Me.txtDescriptionNew)
        Me.Controls.Add(Me.lblDescriptionNew)
        Me.Controls.Add(Me.txtTaskNameNew)
        Me.Controls.Add(Me.lblTaskNameNew)
        Me.Name = "Edit_Task"
        Me.Text = "Edit Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCompletionDate As Label
    Friend WithEvents lblCompletionDateTag As Label
    Friend WithEvents dtpEndNew As DateTimePicker
    Friend WithEvents lblEndDateNew As Label
    Friend WithEvents cbPriorityNew As ComboBox
    Friend WithEvents lblPriorityNew As Label
    Friend WithEvents txtDescriptionNew As TextBox
    Friend WithEvents lblDescriptionNew As Label
    Friend WithEvents txtTaskNameNew As TextBox
    Friend WithEvents lblTaskNameNew As Label
    Friend WithEvents cbReminderNew As ComboBox
    Friend WithEvents lblRemindersNew As Label
    Friend WithEvents btnUpdateTask As Button
    Friend WithEvents btnSubtasks As Button
    Friend WithEvents btnViewSubtasks As Button
    Friend WithEvents btnDelTask As Button
    Friend WithEvents btnPutonHold As Button
    Friend WithEvents lblStartDateNew As Label
    Friend WithEvents dtpStartDateNew As DateTimePicker
End Class
