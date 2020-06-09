Imports System.IO

Module LogInModule
    Public Sub loginmodule()
        Dim password As String = My.Forms.frmLogin.txtPassword.Text
        Dim username As String = My.Forms.frmLogin.txtUsername.Text
        Dim loginFile As String = Application.StartupPath + "\Logins"
        Dim filepath As String = Path.Combine(Application.StartupPath, "Logins")
        Dim actualuser As String
        Dim actualpass As String


        If username = "" Or password = "" Then 'Check that data has been entered in both of the text boxes BEFORE searching the file
            MsgBox("Please enter both a username and password.") 'If they entered nothing, display an error message.
        Else

            If System.IO.File.Exists(filepath + "\" + username & ".txt") Then 'Check that login file exists
                Dim loginpass As String
                loginpass = File.ReadAllText(loginFile + "\abc.txt") 'Load all the data from the file into a string called 'loginpass'
                Dim splitdata() As String = Split(loginpass, "|")
                actualuser = splitdata(0)
                actualpass = splitdata(1)

                If username = actualuser And password = actualpass Then 'If the username and password entered match the data in the file, let them log in.
                    My.Forms.frmLogin.Hide() 'Hide login form, show main form
                    frmMain.Show()
                Else
                    MsgBox("Incorrect username or password. Please try again or create an account") 'If the username and password combination is not found, display error message
                End If
            Else
                MsgBox("Your account could not be found. Please create an account using this form.") 'If the login file can't be found, inform the user that they need to create an account.
                frmSignUp.Show() 'Show the signup form to allow the user to create an account.
                My.Forms.frmLogin.Hide()
            End If
        End If
    End Sub
End Module
