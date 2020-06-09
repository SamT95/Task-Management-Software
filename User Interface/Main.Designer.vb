<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabpgMain = New System.Windows.Forms.TabPage()
        Me.taskGridC = New System.Windows.Forms.DataGridView()
        Me.taskGridOH = New System.Windows.Forms.DataGridView()
        Me.taskGridIP = New System.Windows.Forms.DataGridView()
        Me.taskGridNYS = New System.Windows.Forms.DataGridView()
        Me.btnNewTask = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabpgMain.SuspendLayout()
        CType(Me.taskGridC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.taskGridOH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.taskGridIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.taskGridNYS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabpgMain)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(865, 508)
        Me.TabControl1.TabIndex = 0
        '
        'tabpgMain
        '
        Me.tabpgMain.BackColor = System.Drawing.Color.AliceBlue
        Me.tabpgMain.Controls.Add(Me.taskGridC)
        Me.tabpgMain.Controls.Add(Me.taskGridOH)
        Me.tabpgMain.Controls.Add(Me.taskGridIP)
        Me.tabpgMain.Controls.Add(Me.taskGridNYS)
        Me.tabpgMain.Controls.Add(Me.btnNewTask)
        Me.tabpgMain.Controls.Add(Me.Label4)
        Me.tabpgMain.Controls.Add(Me.Label3)
        Me.tabpgMain.Controls.Add(Me.Label2)
        Me.tabpgMain.Controls.Add(Me.Label1)
        Me.tabpgMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabpgMain.Location = New System.Drawing.Point(4, 24)
        Me.tabpgMain.Name = "tabpgMain"
        Me.tabpgMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpgMain.Size = New System.Drawing.Size(857, 480)
        Me.tabpgMain.TabIndex = 0
        Me.tabpgMain.Text = "View Tasks"
        '
        'taskGridC
        '
        Me.taskGridC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taskGridC.Location = New System.Drawing.Point(638, 72)
        Me.taskGridC.Name = "taskGridC"
        Me.taskGridC.ReadOnly = True
        Me.taskGridC.Size = New System.Drawing.Size(200, 384)
        Me.taskGridC.TabIndex = 16
        '
        'taskGridOH
        '
        Me.taskGridOH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taskGridOH.Location = New System.Drawing.Point(429, 72)
        Me.taskGridOH.Name = "taskGridOH"
        Me.taskGridOH.ReadOnly = True
        Me.taskGridOH.Size = New System.Drawing.Size(200, 384)
        Me.taskGridOH.TabIndex = 15
        '
        'taskGridIP
        '
        Me.taskGridIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taskGridIP.Location = New System.Drawing.Point(220, 72)
        Me.taskGridIP.Name = "taskGridIP"
        Me.taskGridIP.ReadOnly = True
        Me.taskGridIP.Size = New System.Drawing.Size(200, 384)
        Me.taskGridIP.TabIndex = 13
        '
        'taskGridNYS
        '
        Me.taskGridNYS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.taskGridNYS.Location = New System.Drawing.Point(11, 72)
        Me.taskGridNYS.Name = "taskGridNYS"
        Me.taskGridNYS.Size = New System.Drawing.Size(200, 384)
        Me.taskGridNYS.TabIndex = 12
        '
        'btnNewTask
        '
        Me.btnNewTask.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTask.Location = New System.Drawing.Point(350, 6)
        Me.btnNewTask.Name = "btnNewTask"
        Me.btnNewTask.Size = New System.Drawing.Size(121, 23)
        Me.btnNewTask.TabIndex = 10
        Me.btnNewTask.Text = "Create New Task"
        Me.btnNewTask.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(706, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Completed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(286, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "In Progress"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Not Yet Started"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(506, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "On Hold"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(857, 480)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Edit Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 510)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMain"
        Me.Text = "Main Form"
        Me.TabControl1.ResumeLayout(False)
        Me.tabpgMain.ResumeLayout(False)
        Me.tabpgMain.PerformLayout()
        CType(Me.taskGridC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.taskGridOH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.taskGridIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.taskGridNYS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tabpgMain As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewTask As Button
    Friend WithEvents taskGridNYS As DataGridView
    Friend WithEvents taskGridC As DataGridView
    Friend WithEvents taskGridOH As DataGridView
    Friend WithEvents taskGridIP As DataGridView
End Class
