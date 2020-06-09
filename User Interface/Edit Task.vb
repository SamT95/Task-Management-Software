Imports System.IO
Public Class Edit_Task

    Private Sub btnSubtasks_Click(sender As Object, e As EventArgs) Handles btnSubtasks.Click
        Me.Hide()
        Subtasks.Show()
    End Sub

    Private Sub btnDelTask_Click(sender As Object, e As EventArgs) Handles btnDelTask.Click
        Dim taskname As String
        Dim filepath As String = Path.Combine(Application.StartupPath, "Tasks")
        Dim filename As String
        taskname = My.Forms.Edit_Task.txtTaskNameNew.Text
        filename = filepath + "\" + taskname & ".txt"
        My.Computer.FileSystem.DeleteFile(filename) 'Deletes the file that the user is currently editing
        MsgBox("The task named " & taskname & " was deleted successfully.")
        My.Forms.Edit_Task.Hide()
        My.Forms.frmMain.Show()
        formLoad.loadform()
    End Sub

    Private Sub Edit_Task_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTaskNameNew.Text = GlobalVariables.globalvariables.splitdata(0)
        txtDescriptionNew.Text = GlobalVariables.globalvariables.splitdata(1)
        cbPriorityNew.SelectedItem = GlobalVariables.globalvariables.splitdata(2) 'Loads data into the edit task form
        cbReminderNew.SelectedItem = GlobalVariables.globalvariables.splitdata(3)
        dtpStartDateNew.Value = GlobalVariables.globalvariables.splitdata(4)
        dtpEndNew.Value = GlobalVariables.globalvariables.splitdata(5)
    End Sub

    Private Sub btnViewSubtasks_Click(sender As Object, e As EventArgs) Handles btnViewSubtasks.Click
        Me.Hide()
        SubtasksView.Show()
        subtaskLoad.loadsubtask()
        My.Forms.SubtasksView.lblSubtasksView.Text = "Subtasks linked to " & My.Forms.Edit_Task.txtTaskNameNew.Text 'Changes the label to reflect which task is being viewed
    End Sub

    Private Sub btnUpdateTask_Click(sender As Object, e As EventArgs) Handles btnUpdateTask.Click
        Dim filepath As String = Path.Combine(Application.StartupPath, "Tasks")
        Dim filename As String
        Dim allfileinfo As String
        Dim newfileinfo As String
        Dim splitfileinfo() As String
        Dim subfilepath As String = Path.Combine(Application.StartupPath, "Subtasks")
        Dim dirinfo As New DirectoryInfo(subfilepath)
        If txtTaskNameNew.Text = "" Or txtDescriptionNew.Text = "" Then
            MsgBox("Please fill all textboxes")
        Else
            If dtpEndNew.Value.Date < Now.Date Then
                MsgBox("The end date cannot be a date in the past. Please choose a suitable end date.")

            Else
                If dtpEndNew.Value.Date < dtpStartDateNew.Value.Date Then
                    MsgBox("The end date cannot be before the starting date.")
                Else
                    'The file name will have the the task name in it to make it easier to retrieve
                    filename = Path.Combine(filepath, GlobalVariables.globalvariables.splitdata(0) & ".txt") 'Sets filepath to the current task
                    If cbPriorityNew.SelectedItem Is Nothing Then 'If they do not choose a priority, it is set to the default medium
                        cbPriorityNew.Text = "Medium"
                    End If

                    If cbReminderNew.SelectedItem Is Nothing Then 'If they do not choose to receive reminders or not, they will not receive reminders unless priority is high
                        If cbPriorityNew.SelectedItem = "High" Then
                            cbReminderNew.SelectedItem = "Yes"
                        Else
                            cbReminderNew.SelectedItem = "No" 'If priority is not high then do not send reminders.
                        End If
                    End If
                    'Write the title, description, dates, priority and reminder choice to the file
                    File.WriteAllText(filename, String.Join("|", New String() {txtTaskNameNew.Text, txtDescriptionNew.Text, cbPriorityNew.Text, cbReminderNew.Text, dtpStartDateNew.Text, dtpEndNew.Text}))
                    My.Computer.FileSystem.RenameFile(filepath + "\" + GlobalVariables.globalvariables.splitdata(0) & ".txt", txtTaskNameNew.Text & ".txt") 'Renames the file to the new title
                    For Each fileinfo As FileInfo In dirinfo.GetFiles() 'Repeats for each file in the folder
                        allfileinfo = File.ReadAllText(fileinfo.FullName)
                        splitfileinfo = allfileinfo.Split("|")
                        If splitfileinfo(2) = GlobalVariables.globalvariables.splitdata(0) Then 'If the name of the task does not change
                            splitfileinfo(2) = txtTaskNameNew.Text
                            newfileinfo = String.Join("|", splitfileinfo)
                            System.IO.File.WriteAllText(fileinfo.FullName, String.Join("|", New String() {newfileinfo})) 'Will update the data in the file
                        End If
                    Next
                    MsgBox("The task has been updated successfully.")
                    Me.Hide()
                    frmMain.Show()
                    formLoad.loadform()
                End If
            End If
        End If

    End Sub
End Class