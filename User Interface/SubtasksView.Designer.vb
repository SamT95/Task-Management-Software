<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubtasksView
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
        Me.lblSubtasksView = New System.Windows.Forms.Label()
        Me.btnReturnToTask = New System.Windows.Forms.Button()
        Me.subtaskTable = New System.Windows.Forms.DataGridView()
        CType(Me.subtaskTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSubtasksView
        '
        Me.lblSubtasksView.AutoSize = True
        Me.lblSubtasksView.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtasksView.Location = New System.Drawing.Point(13, 13)
        Me.lblSubtasksView.Name = "lblSubtasksView"
        Me.lblSubtasksView.Size = New System.Drawing.Size(149, 15)
        Me.lblSubtasksView.TabIndex = 1
        Me.lblSubtasksView.Text = "Subtasks linked to: task name"
        '
        'btnReturnToTask
        '
        Me.btnReturnToTask.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnToTask.Location = New System.Drawing.Point(109, 424)
        Me.btnReturnToTask.Name = "btnReturnToTask"
        Me.btnReturnToTask.Size = New System.Drawing.Size(210, 36)
        Me.btnReturnToTask.TabIndex = 13
        Me.btnReturnToTask.Text = "Return to task view form"
        Me.btnReturnToTask.UseVisualStyleBackColor = True
        '
        'subtaskTable
        '
        Me.subtaskTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.subtaskTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subtaskTable.Location = New System.Drawing.Point(16, 122)
        Me.subtaskTable.Name = "subtaskTable"
        Me.subtaskTable.ReadOnly = True
        Me.subtaskTable.Size = New System.Drawing.Size(405, 255)
        Me.subtaskTable.TabIndex = 14
        '
        'SubtasksView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 472)
        Me.Controls.Add(Me.subtaskTable)
        Me.Controls.Add(Me.btnReturnToTask)
        Me.Controls.Add(Me.lblSubtasksView)
        Me.Name = "SubtasksView"
        Me.Text = "SubtasksView"
        CType(Me.subtaskTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubtasksView As Label
    Friend WithEvents btnReturnToTask As Button
    Friend WithEvents subtaskTable As DataGridView
End Class
