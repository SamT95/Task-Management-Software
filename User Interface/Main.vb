Imports System.IO
Public Class frmMain
    Private Sub btnNewTask_Click(sender As Object, e As EventArgs) Handles btnNewTask.Click
        Me.Hide()
        frmNewTask.Show()
    End Sub




    Private Sub taskGridNYS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles taskGridNYS.CellClick
        Dim filename As String
        Dim filepath As String = Path.Combine(Application.StartupPath, "Tasks")
        Dim allfiledata As String
        If e.ColumnIndex = 0 Then
            filename = Path.Combine(filepath, taskGridNYS.Item(e.ColumnIndex, e.RowIndex).Value.ToString() & ".txt") 'Checks if the user clicked the title
        Else
            If e.ColumnIndex = 1 Then
                filename = Path.Combine(filepath, taskGridNYS.Item(e.ColumnIndex - 1, e.RowIndex).Value.ToString() & ".txt") 'Checks if the user clicked the description
            End If
        End If

        allfiledata = File.ReadAllText(filename)
        GlobalVariables.globalvariables.splitdata = Split(allfiledata, "|") 'Loads data into global variable so it can be loaded into the edit task form
        My.Forms.frmMain.Hide()
        My.Forms.Edit_Task.Show()
    End Sub

    Private Sub taskGridIP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles taskGridIP.CellClick
        Dim filename As String
        Dim filepath As String = Path.Combine(Application.StartupPath, "Tasks")
        Dim allfiledata As String
        If e.ColumnIndex = 0 Then
            filename = Path.Combine(filepath, taskGridIP.Item(e.ColumnIndex, e.RowIndex).Value.ToString() & ".txt") 'Checks if the user clicked the title
        Else
            If e.ColumnIndex = 1 Then
                filename = Path.Combine(filepath, taskGridIP.Item(e.ColumnIndex - 1, e.RowIndex).Value.ToString() & ".txt") 'Checks if the user clicked the description
            End If
        End If

        allfiledata = File.ReadAllText(filename)
        GlobalVariables.globalvariables.splitdata = Split(allfiledata, "|")
        My.Forms.frmMain.Hide()
        My.Forms.Edit_Task.Show()
    End Sub

    Private Sub Main_load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoad.loadform() 'Calls the module that fills the data table
        Reminders.Reminders() 'Calls the module that calculates reminders
    End Sub

    Private Sub taskGridOH_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles taskGridOH.CellClick
        Dim filename As String
        Dim filepath As String = Path.Combine(Application.StartupPath, "Tasks")
        Dim allfiledata As String
        If e.ColumnIndex = 0 Then
            filename = Path.Combine(filepath, taskGridIP.Item(e.ColumnIndex, e.RowIndex).Value.ToString() & ".txt") 'Checks if the user clicked the title
        Else
            If e.ColumnIndex = 1 Then
                filename = Path.Combine(filepath, taskGridIP.Item(e.ColumnIndex - 1, e.RowIndex).Value.ToString() & ".txt") 'Checks if the user clicked the description
            End If
        End If

        allfiledata = File.ReadAllText(filename)
        GlobalVariables.globalvariables.splitdata = Split(allfiledata, "|")
        My.Forms.frmMain.Hide()
        My.Forms.Edit_Task.Show()
    End Sub

    Private Sub taskGridC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles taskGridC.CellClick
        Dim filename As String
        Dim filepath As String = Path.Combine(Application.StartupPath, "Tasks")
        Dim allfiledata As String
        If e.ColumnIndex = 0 Then
            filename = Path.Combine(filepath, taskGridIP.Item(e.ColumnIndex, e.RowIndex).Value.ToString() & ".txt") 'Checks if the user clicked the title
        Else
            If e.ColumnIndex = 1 Then
                filename = Path.Combine(filepath, taskGridIP.Item(e.ColumnIndex - 1, e.RowIndex).Value.ToString() & ".txt") 'Checks if the user clicked the description
            End If
        End If

        allfiledata = File.ReadAllText(filename)
        GlobalVariables.globalvariables.splitdata = Split(allfiledata, "|")
        My.Forms.frmMain.Hide()
        My.Forms.Edit_Task.Show()
    End Sub
End Class
