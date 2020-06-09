Imports System.IO
Public Class frmNewTask
    Private Sub btnCreateNewTask_Click(sender As Object, e As EventArgs) Handles btnCreateNewTask.Click
        Dim filepath As String
        Dim filename As String


        filepath = Path.Combine(Application.StartupPath, "Tasks")
        If (Not Directory.Exists(filepath)) Then
            Directory.CreateDirectory(filepath)
        End If

        If txtDescription.Text = "" Or txtTaskName.Text = "" Then
            MsgBox("Please create a title and description for this task.")
        Else
            If dtpEnd.Value.Date < Now.Date Then
                MsgBox("The end date cannot be a date in the past. Please choose a suitable end date.")

            Else
                If dtpEnd.Value.Date < dtpStart.Value.Date Then
                    MsgBox("The end date cannot be before the starting date.")
                Else
                    'The file name will have the the task name in it to make it easier to retrieve
                    filename = Path.Combine(filepath, txtTaskName.Text & ".txt")
                    If cbPriority.SelectedItem Is Nothing Then 'If they do not choose a priority, it is set to the default medium
                        cbPriority.Text = "Medium"
                    End If

                    If cbReminder.SelectedItem Is Nothing Then 'If they do not choose to receive reminders or not, they will not receive reminders unless priority is high
                        If cbPriority.SelectedItem = "High" Then
                            cbReminder.SelectedItem = "Yes"
                        Else
                            cbReminder.SelectedItem = "No" 'If priority is not high then do not send reminders.
                        End If
                    End If
                    'Write the title, description, dates, priority and reminder choice to the file
                    File.WriteAllText(filename, String.Join("|", New String() {txtTaskName.Text, txtDescription.Text, cbPriority.Text, cbReminder.Text, dtpStart.Text, dtpEnd.Text}))
                    MsgBox("A task with the name " & txtTaskName.Text & " was created")
                    Me.Hide()
                    My.Forms.frmMain.Show()
                    formLoad.loadform()


                End If
                End If
            End If


    End Sub

    Private Sub frmNewTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
