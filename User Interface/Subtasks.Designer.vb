<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Subtasks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSubtaskDesc = New System.Windows.Forms.TextBox()
        Me.btnCreateSubtask = New System.Windows.Forms.Button()
        Me.lblSubtask = New System.Windows.Forms.Label()
        Me.lblSubtaskEnd = New System.Windows.Forms.Label()
        Me.lblSubtaskCompletion = New System.Windows.Forms.Label()
        Me.txtSubtaskTitle = New System.Windows.Forms.TextBox()
        Me.lblSubtaskTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSubtaskDesc
        '
        Me.txtSubtaskDesc.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtaskDesc.Location = New System.Drawing.Point(12, 126)
        Me.txtSubtaskDesc.Multiline = True
        Me.txtSubtaskDesc.Name = "txtSubtaskDesc"
        Me.txtSubtaskDesc.Size = New System.Drawing.Size(354, 72)
        Me.txtSubtaskDesc.TabIndex = 0
        '
        'btnCreateSubtask
        '
        Me.btnCreateSubtask.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateSubtask.Location = New System.Drawing.Point(125, 258)
        Me.btnCreateSubtask.Name = "btnCreateSubtask"
        Me.btnCreateSubtask.Size = New System.Drawing.Size(109, 23)
        Me.btnCreateSubtask.TabIndex = 1
        Me.btnCreateSubtask.Text = "Create Subtask"
        Me.btnCreateSubtask.UseVisualStyleBackColor = True
        '
        'lblSubtask
        '
        Me.lblSubtask.AutoSize = True
        Me.lblSubtask.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtask.Location = New System.Drawing.Point(9, 95)
        Me.lblSubtask.Name = "lblSubtask"
        Me.lblSubtask.Size = New System.Drawing.Size(145, 15)
        Me.lblSubtask.TabIndex = 2
        Me.lblSubtask.Text = "Brief Description of Subtask"
        '
        'lblSubtaskEnd
        '
        Me.lblSubtaskEnd.AutoSize = True
        Me.lblSubtaskEnd.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtaskEnd.Location = New System.Drawing.Point(12, 219)
        Me.lblSubtaskEnd.Name = "lblSubtaskEnd"
        Me.lblSubtaskEnd.Size = New System.Drawing.Size(55, 15)
        Me.lblSubtaskEnd.TabIndex = 3
        Me.lblSubtaskEnd.Text = "End Date:"
        '
        'lblSubtaskCompletion
        '
        Me.lblSubtaskCompletion.AutoSize = True
        Me.lblSubtaskCompletion.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtaskCompletion.Location = New System.Drawing.Point(202, 219)
        Me.lblSubtaskCompletion.Name = "lblSubtaskCompletion"
        Me.lblSubtaskCompletion.Size = New System.Drawing.Size(93, 15)
        Me.lblSubtaskCompletion.TabIndex = 4
        Me.lblSubtaskCompletion.Text = "Completion Date:"
        '
        'txtSubtaskTitle
        '
        Me.txtSubtaskTitle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtaskTitle.Location = New System.Drawing.Point(12, 54)
        Me.txtSubtaskTitle.Name = "txtSubtaskTitle"
        Me.txtSubtaskTitle.Size = New System.Drawing.Size(354, 21)
        Me.txtSubtaskTitle.TabIndex = 5
        '
        'lblSubtaskTitle
        '
        Me.lblSubtaskTitle.AutoSize = True
        Me.lblSubtaskTitle.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtaskTitle.Location = New System.Drawing.Point(12, 21)
        Me.lblSubtaskTitle.Name = "lblSubtaskTitle"
        Me.lblSubtaskTitle.Size = New System.Drawing.Size(71, 15)
        Me.lblSubtaskTitle.TabIndex = 6
        Me.lblSubtaskTitle.Text = "Subtask Title"
        '
        'Subtasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 296)
        Me.Controls.Add(Me.lblSubtaskTitle)
        Me.Controls.Add(Me.txtSubtaskTitle)
        Me.Controls.Add(Me.lblSubtaskCompletion)
        Me.Controls.Add(Me.lblSubtaskEnd)
        Me.Controls.Add(Me.lblSubtask)
        Me.Controls.Add(Me.btnCreateSubtask)
        Me.Controls.Add(Me.txtSubtaskDesc)
        Me.Name = "Subtasks"
        Me.Text = "Subtasks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSubtaskDesc As TextBox
    Friend WithEvents btnCreateSubtask As Button
    Friend WithEvents lblSubtask As Label
    Friend WithEvents lblSubtaskEnd As Label
    Friend WithEvents lblSubtaskCompletion As Label
    Friend WithEvents txtSubtaskTitle As TextBox
    Friend WithEvents lblSubtaskTitle As Label
End Class
