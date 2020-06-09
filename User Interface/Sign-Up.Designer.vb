<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUp
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
        Me.lblCreatePass = New System.Windows.Forms.Label()
        Me.lblCreateUser = New System.Windows.Forms.Label()
        Me.txtCreatePass = New System.Windows.Forms.TextBox()
        Me.lblCreateAcc = New System.Windows.Forms.Label()
        Me.btnCreateAcc = New System.Windows.Forms.Button()
        Me.txtCreateUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRetypePass = New System.Windows.Forms.Label()
        Me.txtRetypePass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCreatePass
        '
        Me.lblCreatePass.AutoSize = True
        Me.lblCreatePass.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatePass.Location = New System.Drawing.Point(10, 108)
        Me.lblCreatePass.Name = "lblCreatePass"
        Me.lblCreatePass.Size = New System.Drawing.Size(54, 15)
        Me.lblCreatePass.TabIndex = 13
        Me.lblCreatePass.Text = "Password"
        '
        'lblCreateUser
        '
        Me.lblCreateUser.AutoSize = True
        Me.lblCreateUser.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateUser.Location = New System.Drawing.Point(8, 60)
        Me.lblCreateUser.Name = "lblCreateUser"
        Me.lblCreateUser.Size = New System.Drawing.Size(55, 15)
        Me.lblCreateUser.TabIndex = 12
        Me.lblCreateUser.Text = "Username"
        '
        'txtCreatePass
        '
        Me.txtCreatePass.Location = New System.Drawing.Point(108, 105)
        Me.txtCreatePass.Name = "txtCreatePass"
        Me.txtCreatePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCreatePass.Size = New System.Drawing.Size(125, 20)
        Me.txtCreatePass.TabIndex = 11
        '
        'lblCreateAcc
        '
        Me.lblCreateAcc.AutoSize = True
        Me.lblCreateAcc.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAcc.Location = New System.Drawing.Point(60, 20)
        Me.lblCreateAcc.Name = "lblCreateAcc"
        Me.lblCreateAcc.Size = New System.Drawing.Size(148, 21)
        Me.lblCreateAcc.TabIndex = 10
        Me.lblCreateAcc.Text = "Create an Account"
        '
        'btnCreateAcc
        '
        Me.btnCreateAcc.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAcc.Location = New System.Drawing.Point(87, 217)
        Me.btnCreateAcc.Name = "btnCreateAcc"
        Me.btnCreateAcc.Size = New System.Drawing.Size(100, 25)
        Me.btnCreateAcc.TabIndex = 9
        Me.btnCreateAcc.Text = "Sign Up"
        Me.btnCreateAcc.UseVisualStyleBackColor = True
        '
        'txtCreateUser
        '
        Me.txtCreateUser.Location = New System.Drawing.Point(108, 60)
        Me.txtCreateUser.Name = "txtCreateUser"
        Me.txtCreateUser.Size = New System.Drawing.Size(125, 20)
        Me.txtCreateUser.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 12)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "(Password must contain more than 8 characters and one digit)"
        '
        'lblRetypePass
        '
        Me.lblRetypePass.AutoSize = True
        Me.lblRetypePass.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetypePass.Location = New System.Drawing.Point(5, 154)
        Me.lblRetypePass.Name = "lblRetypePass"
        Me.lblRetypePass.Size = New System.Drawing.Size(93, 15)
        Me.lblRetypePass.TabIndex = 16
        Me.lblRetypePass.Text = "Retype Password"
        '
        'txtRetypePass
        '
        Me.txtRetypePass.Location = New System.Drawing.Point(108, 151)
        Me.txtRetypePass.Name = "txtRetypePass"
        Me.txtRetypePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRetypePass.Size = New System.Drawing.Size(125, 20)
        Me.txtRetypePass.TabIndex = 15
        '
        'frmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(262, 243)
        Me.Controls.Add(Me.lblRetypePass)
        Me.Controls.Add(Me.txtRetypePass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCreatePass)
        Me.Controls.Add(Me.lblCreateUser)
        Me.Controls.Add(Me.txtCreatePass)
        Me.Controls.Add(Me.lblCreateAcc)
        Me.Controls.Add(Me.btnCreateAcc)
        Me.Controls.Add(Me.txtCreateUser)
        Me.Name = "frmSignUp"
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCreatePass As Label
    Friend WithEvents lblCreateUser As Label
    Friend WithEvents txtCreatePass As TextBox
    Friend WithEvents lblCreateAcc As Label
    Friend WithEvents btnCreateAcc As Button
    Friend WithEvents txtCreateUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRetypePass As Label
    Friend WithEvents txtRetypePass As TextBox
End Class
