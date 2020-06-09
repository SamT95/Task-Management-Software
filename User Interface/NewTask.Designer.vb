<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewTask
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
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.btnCreateNewTask = New System.Windows.Forms.Button()
        Me.txtTaskName = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.cbPriority = New System.Windows.Forms.ComboBox()
        Me.lblReminders = New System.Windows.Forms.Label()
        Me.cbReminder = New System.Windows.Forms.ComboBox()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblCompletionDateTag = New System.Windows.Forms.Label()
        Me.lblCompletionDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTaskName
        '
        Me.lblTaskName.AutoSize = True
        Me.lblTaskName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskName.Location = New System.Drawing.Point(10, 26)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(61, 15)
        Me.lblTaskName.TabIndex = 0
        Me.lblTaskName.Text = "Task Name"
        '
        'btnCreateNewTask
        '
        Me.btnCreateNewTask.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewTask.Location = New System.Drawing.Point(208, 342)
        Me.btnCreateNewTask.Name = "btnCreateNewTask"
        Me.btnCreateNewTask.Size = New System.Drawing.Size(94, 23)
        Me.btnCreateNewTask.TabIndex = 1
        Me.btnCreateNewTask.Text = "Create Task"
        Me.btnCreateNewTask.UseVisualStyleBackColor = True
        '
        'txtTaskName
        '
        Me.txtTaskName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaskName.Location = New System.Drawing.Point(13, 43)
        Me.txtTaskName.Name = "txtTaskName"
        Me.txtTaskName.Size = New System.Drawing.Size(223, 21)
        Me.txtTaskName.TabIndex = 2
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(12, 84)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(130, 15)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Brief Description of Task"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(15, 111)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(453, 52)
        Me.txtDescription.TabIndex = 4
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriority.Location = New System.Drawing.Point(364, 26)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(45, 15)
        Me.lblPriority.TabIndex = 5
        Me.lblPriority.Text = "Priority"
        '
        'cbPriority
        '
        Me.cbPriority.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPriority.FormattingEnabled = True
        Me.cbPriority.Items.AddRange(New Object() {"High", "Medium", "Low"})
        Me.cbPriority.Location = New System.Drawing.Point(367, 42)
        Me.cbPriority.Name = "cbPriority"
        Me.cbPriority.Size = New System.Drawing.Size(101, 23)
        Me.cbPriority.TabIndex = 6
        '
        'lblReminders
        '
        Me.lblReminders.AutoSize = True
        Me.lblReminders.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminders.Location = New System.Drawing.Point(12, 274)
        Me.lblReminders.Name = "lblReminders"
        Me.lblReminders.Size = New System.Drawing.Size(81, 15)
        Me.lblReminders.TabIndex = 8
        Me.lblReminders.Text = "Set Reminders?"
        '
        'cbReminder
        '
        Me.cbReminder.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReminder.FormattingEnabled = True
        Me.cbReminder.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbReminder.Location = New System.Drawing.Point(15, 290)
        Me.cbReminder.Name = "cbReminder"
        Me.cbReminder.Size = New System.Drawing.Size(101, 23)
        Me.cbReminder.TabIndex = 9
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(19, 202)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(56, 15)
        Me.lblStartDate.TabIndex = 10
        Me.lblStartDate.Text = "Start Date"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(166, 202)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(52, 15)
        Me.lblEndDate.TabIndex = 11
        Me.lblEndDate.Text = "End Date"
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Location = New System.Drawing.Point(15, 218)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(148, 21)
        Me.dtpStart.TabIndex = 12
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Location = New System.Drawing.Point(169, 218)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(148, 21)
        Me.dtpEnd.TabIndex = 13
        '
        'lblCompletionDateTag
        '
        Me.lblCompletionDateTag.AutoSize = True
        Me.lblCompletionDateTag.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletionDateTag.Location = New System.Drawing.Point(350, 202)
        Me.lblCompletionDateTag.Name = "lblCompletionDateTag"
        Me.lblCompletionDateTag.Size = New System.Drawing.Size(90, 15)
        Me.lblCompletionDateTag.TabIndex = 14
        Me.lblCompletionDateTag.Text = "Completion Date"
        '
        'lblCompletionDate
        '
        Me.lblCompletionDate.AutoSize = True
        Me.lblCompletionDate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletionDate.Location = New System.Drawing.Point(350, 224)
        Me.lblCompletionDate.Name = "lblCompletionDate"
        Me.lblCompletionDate.Size = New System.Drawing.Size(28, 15)
        Me.lblCompletionDate.TabIndex = 15
        Me.lblCompletionDate.Text = "N/A"
        '
        'frmNewTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(502, 391)
        Me.Controls.Add(Me.lblCompletionDate)
        Me.Controls.Add(Me.lblCompletionDateTag)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.cbReminder)
        Me.Controls.Add(Me.lblReminders)
        Me.Controls.Add(Me.cbPriority)
        Me.Controls.Add(Me.lblPriority)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtTaskName)
        Me.Controls.Add(Me.btnCreateNewTask)
        Me.Controls.Add(Me.lblTaskName)
        Me.Name = "frmNewTask"
        Me.Text = "NewTask"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTaskName As Label
    Friend WithEvents btnCreateNewTask As Button
    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblPriority As Label
    Friend WithEvents cbPriority As ComboBox
    Friend WithEvents lblReminders As Label
    Friend WithEvents cbReminder As ComboBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblCompletionDateTag As Label
    Friend WithEvents lblCompletionDate As Label
End Class
