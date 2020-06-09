Imports System.IO
Public Class SubtasksView
    Private Sub btnReturnToTask_Click(sender As Object, e As EventArgs) Handles btnReturnToTask.Click
        Me.Hide()
        My.Forms.frmMain.Show()
    End Sub

    Private Sub subtaskTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles subtaskTable.CellClick
        Dim filename As String
        Dim filepath As String = Path.Combine(Application.StartupPath, "Subtasks")
        If e.ColumnIndex = 0 Then
            filename = Path.Combine(filepath, subtaskTable.Item(e.ColumnIndex, e.RowIndex).Value.ToString() & ".txt") 'Checks if the title was clicked
        Else
            If e.ColumnIndex = 1 Then
                filename = Path.Combine(filepath, subtaskTable.Item(e.ColumnIndex - 1, e.RowIndex).Value.ToString() & ".txt") 'Checks if the description was clicked
            End If
        End If

        GlobalVariables.globalvariables.allfiledata = File.ReadAllText(filename)
        GlobalVariables.globalvariables.splitdata = Split(GlobalVariables.globalvariables.allfiledata, "|") 'Loads the data into the subtask edit form
        My.Forms.SubtasksView.Hide()
        My.Forms.SubtaskEdit.Show()
    End Sub

    Private Sub SubtasksView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subtaskLoad.loadsubtask() 'Loads data into subtask task table
    End Sub
End Class