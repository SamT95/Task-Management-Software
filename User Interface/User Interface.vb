Imports System.IO
Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call LogInModule.loginmodule() 'Calls the function to let the user log in
    End Sub
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        frmSignUp.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
