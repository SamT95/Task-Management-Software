Imports System.IO
Module subtaskLoad
    Sub loadsubtask()
        My.Forms.SubtasksView.subtaskTable.DataSource = Nothing
        My.Forms.SubtasksView.subtaskTable.Rows.Clear()
        GlobalVariables.globalvariables.subtasktable.Rows.Clear()
        Dim filepath = Path.Combine(Application.StartupPath, "Subtasks")
        Dim dirinfo As New DirectoryInfo(filepath) 'Gets the number of files in the folder
        Dim allfileinfo As String
        Dim splitfileinfo() As String
        If GlobalVariables.globalvariables.subtasktable.Columns.Count = 0 Then
            With GlobalVariables.globalvariables.subtasktable
                .Columns.Add("Title", System.Type.GetType("System.String"))
                .Columns.Add("Description", System.Type.GetType("System.String")) 'Adds columns to the data table
            End With
        End If

        My.Forms.SubtasksView.subtaskTable.DataSource = Nothing
        My.Forms.SubtasksView.subtaskTable.Rows.Clear()
        GlobalVariables.globalvariables.subtasktable.Rows.Clear()

        For Each fileinfo As FileInfo In dirinfo.GetFiles() 'Loops for each task in the subtask folder
            allfileinfo = File.ReadAllText(fileinfo.FullName)
            splitfileinfo = allfileinfo.Split("|")
            If splitfileinfo(2) = My.Forms.Edit_Task.txtTaskNameNew.Text Then
                Dim row = GlobalVariables.globalvariables.subtasktable.NewRow()
                row("Title") = splitfileinfo(0)
                row("Description") = splitfileinfo(1)
                GlobalVariables.globalvariables.subtasktable.Rows.Add(row) 'Adds rows to data table
            End If
        Next
        If Not GlobalVariables.globalvariables.subtasktable.Rows.Count = 0 Then
            My.Forms.SubtasksView.subtaskTable.DataSource = GlobalVariables.globalvariables.subtasktable 'Loads data into data able
        End If
    End Sub
End Module
