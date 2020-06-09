Imports System.IO
Public Class Subtasks
    Private Sub Subtasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreateSubtask_Click(sender As Object, e As EventArgs) Handles btnCreateSubtask.Click
        Dim filepath As String
        Dim filename As String
        Dim maintask As String = Edit_Task.txtTaskNameNew.Text


        filepath = Path.Combine(Application.StartupPath, "Subtasks")
        If (Not Directory.Exists(filepath)) Then
            Directory.CreateDirectory(filepath)
        End If
        If txtSubtaskTitle.Text = "" Or txtSubtaskDesc.Text = "" Then
            MsgBox("Please fill both textboxes")
        Else
            filename = Path.Combine(filepath, txtSubtaskTitle.Text & ".txt") 'Sets file path
            File.WriteAllText(filename, String.Join("|", New String() {txtSubtaskTitle.Text, txtSubtaskDesc.Text, maintask, "False"})) 'Writes all data to a file
            subtaskLoad.loadsubtask() 'Calls the function to load the subtask data table
            Me.Hide()
            SubtasksView.Show()
            My.Forms.SubtasksView.lblSubtasksView.Text = "Subtasks linked to " & My.Forms.Edit_Task.txtTaskNameNew.Text 'Shows the user what task the subtasks are liniked to
            MsgBox("A subtask with the name " & txtSubtaskTitle.Text & " was created.")
        End If

    End Sub
End Class