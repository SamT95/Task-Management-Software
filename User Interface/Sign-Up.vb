Imports System.IO
Public Class frmSignUp
    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        Dim password As String = txtCreatePass.Text
        Dim username As String = txtCreateUser.Text
        Dim loginFile As String = Application.StartupPath + "\logins\login.txt"
        Const numbers = "0123456789"
        Dim filepath As String = Path.Combine(Application.StartupPath, "Logins")
        Dim filename As String

        If txtCreatePass.Text = "" Or txtCreateUser.Text = "" Or txtRetypePass.Text = "" Then
            MsgBox("Please fill every textbox")
        Else
            If Not (txtCreatePass.Text.IndexOfAny(numbers.ToArray)) > -1 Or txtCreatePass.Text.Length < 8 Then 'Checks if any of the characters in CreatePass match an array of numbers. 
                MsgBox("The password must contain at least one digit and be longer than 8 characters.") 'Also checks if the entered password is longer than 8 characters
            Else
                If txtCreatePass.Text <> txtRetypePass.Text Then
                    MsgBox("The two password you entered did not match. Please enter both again.")
                    txtRetypePass.Clear()
                    txtCreatePass.Clear()
                Else
                    If File.Exists(filepath + "\" & username & ".txt") Then
                        MsgBox("An account with this username already exists. Please choose another username") 'Checks if account with that username already exists
                    Else

                        filename = Path.Combine(filepath, username & ".txt")
                        If (Not Directory.Exists(filepath)) Then
                            Directory.CreateDirectory(filepath)
                            System.IO.File.Create(filepath + username)
                            File.WriteAllText(filename, String.Join("|", New String() {username, password})) 'Writes username and pasword to file
                            MsgBox("An account with the username " & username & " has been created.")
                            Me.Hide()
                            frmLogin.Show()
                        Else
                            System.IO.File.Create(filepath + username)
                            File.WriteAllText(filename, String.Join("|", New String() {username, password}))
                            MsgBox("An account with the username " & username & " has been created.")
                            Me.Hide()
                            frmLogin.Show()
                        End If
                    End If
                End If
            End If
        End If

    End Sub
End Class