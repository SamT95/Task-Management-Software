Imports System.IO
Public Class SubtaskEdit
    Private Sub SubtaskEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewSubtaskTitle.Text = GlobalVariables.globalvariables.splitdata(0)
        txtSubtaskDescEdit.Text = GlobalVariables.globalvariables.splitdata(1)

    End Sub

    Private Sub btnSubtaskSave_Click(sender As Object, e As EventArgs) Handles btnSubtaskSave.Click
        Dim filepath As String = Path.Combine(Application.StartupPath, "Subtasks")
        Dim filename As String
        Dim isComplete As String = "False"
        Dim splitdata() As String
        If txtNewSubtaskTitle.Text = "" Or txtSubtaskDescEdit.Text = "" Then
            MsgBox("Please fill both textboxes.")
        End If
        If chkboxComplete.Checked = True Then
            isComplete = "True" 'Marks the subtask as complete
        End If
        filename = Path.Combine(filepath, GlobalVariables.globalvariables.splitdata(0) & ".txt")
        File.WriteAllText(filename, String.Join("|", New String() {txtNewSubtaskTitle.Text, txtSubtaskDescEdit.Text, My.Forms.Edit_Task.txtTaskNameNew.Text, isComplete}))
        splitdata = GlobalVariables.globalvariables.allfiledata.Split("|")
        If txtNewSubtaskTitle.Text <> splitdata(2) Then 'Checks if the title has been changed
            My.Computer.FileSystem.RenameFile(filepath + "\" + GlobalVariables.globalvariables.splitdata(0) & ".txt", txtNewSubtaskTitle.Text & ".txt") 'Will edit subtask data
        End If
        MsgBox("The subtask has been updated successfully.")
        Me.Hide()
        My.Forms.SubtasksView.Show()
    End Sub

    Private Sub btnDelSubtask_Click(sender As Object, e As EventArgs) Handles btnDelSubtask.Click
        Dim taskname As String
        Dim filepath As String = Path.Combine(Application.StartupPath, "Subtasks")
        Dim filename As String
        taskname = My.Forms.SubtaskEdit.txtNewSubtaskTitle.Text
        filename = filepath + "\" + taskname & ".txt" 'Deletes the subtask that is currently being edited
        My.Computer.FileSystem.DeleteFile(filename)
        MsgBox("The subtask named " & taskname & " was deleted successfully.")
        subtaskLoad.loadsubtask()
        My.Forms.SubtaskEdit.Hide()
        My.Forms.SubtasksView.Show()
    End Sub
End Class