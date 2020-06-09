Imports System.IO
Module formLoad
    Public Sub loadform()
        My.Forms.frmMain.taskGridOH.DataSource = Nothing
        My.Forms.frmMain.taskGridNYS.DataSource = Nothing 'Clears all the data grid views
        My.Forms.frmMain.taskGridIP.DataSource = Nothing
        My.Forms.frmMain.taskGridC.DataSource = Nothing
        GlobalVariables.globalvariables.NYSDatatable.Rows.Clear()
        GlobalVariables.globalvariables.IPDatatable.Rows.Clear() 'Clears all the data grid views
        GlobalVariables.globalvariables.CDatatable.Rows.Clear()
        If Not GlobalVariables.globalvariables.IPDatatable.Rows.Count = 0 Then
            GlobalVariables.globalvariables.IPDatatable.Rows.Clear()
        End If
        If Not GlobalVariables.globalvariables.NYSDatatable.Rows.Count = 0 Then
            GlobalVariables.globalvariables.NYSDatatable.Rows.Clear()
        End If
        Dim filepath = Path.Combine(Application.StartupPath, "Tasks")
        Dim subfilepath = Path.Combine(Application.StartupPath, "Subtasks")
        Dim dirinfo As New DirectoryInfo(filepath)
        Dim subdirinfo As New DirectoryInfo(subfilepath)
        Dim allfileinfo As String
        Dim allsubfileinfo As String
        Dim splitfileinfo() As String
        Dim subsplitfileinfo() As String
        Dim noofsubtasks As Integer = 0
        Dim completedsubtasks As Integer = 0
        If GlobalVariables.globalvariables.IPDatatable.Columns.Count = 0 Then
            With GlobalVariables.globalvariables.IPDatatable
                .Columns.Add("Title", System.Type.GetType("System.String"))
                .Columns.Add("Description", System.Type.GetType("System.String")) 'Adds the title and description columns to the data grid view
            End With
        End If
        If GlobalVariables.globalvariables.NYSDatatable.Columns.Count = 0 Then
            With GlobalVariables.globalvariables.NYSDatatable
                .Columns.Add("Title", System.Type.GetType("System.String"))
                .Columns.Add("Description", System.Type.GetType("System.String")) 'Adds the title and description columns to the data grid view
            End With
        End If
        If GlobalVariables.globalvariables.CDatatable.Columns.Count = 0 Then
            With GlobalVariables.globalvariables.CDatatable
                .Columns.Add("Title", System.Type.GetType("System.String"))
                .Columns.Add("Description", System.Type.GetType("System.String")) 'Adds the title and description columns to the data grid view
            End With
        End If


        For Each fileinfo As FileInfo In dirinfo.GetFiles()
            allfileinfo = File.ReadAllText(fileinfo.FullName)
            splitfileinfo = allfileinfo.Split("|")
            noofsubtasks = 0
            completedsubtasks = 0
            Dim IProw = GlobalVariables.globalvariables.IPDatatable.NewRow()
            Dim NYSrow = GlobalVariables.globalvariables.NYSDatatable.NewRow() 'Declares the new rows of the data table
            Dim CRow = GlobalVariables.globalvariables.CDatatable.NewRow()
            For Each subtaskcount As FileInfo In subdirinfo.GetFiles()
                allsubfileinfo = File.ReadAllText(subtaskcount.FullName) 'Reads all text from each file
                subsplitfileinfo = allsubfileinfo.Split("|")
                If subsplitfileinfo(2) = splitfileinfo(0) Then 'Checks if the subtasks is linked to the current task
                    noofsubtasks = noofsubtasks + 1
                    If subsplitfileinfo(3) = "True" Then
                        completedsubtasks = completedsubtasks + 1
                    End If
                End If
            Next
            If noofsubtasks <> 0 And completedsubtasks <> 0 Then
                If noofsubtasks = completedsubtasks Then
                    CRow("Title") = splitfileinfo(0)
                    CRow("Description") = splitfileinfo(1)
                    GlobalVariables.globalvariables.CDatatable.Rows.Add(CRow) 'Adds rows to data table
                Else
                    If splitfileinfo(4) <= Now.Date Then
                        IProw("Title") = splitfileinfo(0)
                        IProw("Description") = splitfileinfo(1)
                        GlobalVariables.globalvariables.IPDatatable.Rows.Add(IProw) 'Adds rows to data table
                    Else
                        If splitfileinfo(4) > Now.Date Then
                            NYSrow("Title") = splitfileinfo(0)
                            NYSrow("Description") = splitfileinfo(1)
                            GlobalVariables.globalvariables.NYSDatatable.Rows.Add(NYSrow) 'Adds rows to data table
                        End If
                    End If
                End If
            Else
                If splitfileinfo(4) <= Now.Date Then
                    IProw("Title") = splitfileinfo(0)
                    IProw("Description") = splitfileinfo(1)
                    GlobalVariables.globalvariables.IPDatatable.Rows.Add(IProw) 'Adds rows to data table
                Else
                    If splitfileinfo(4) > Now.Date Then
                        NYSrow("Title") = splitfileinfo(0)
                        NYSrow("Description") = splitfileinfo(1)
                        GlobalVariables.globalvariables.NYSDatatable.Rows.Add(NYSrow) 'Adds rows to data table
                    End If
                End If
            End If
        Next
        If Not GlobalVariables.globalvariables.IPDatatable.Rows.Count = 0 Then
            My.Forms.frmMain.taskGridIP.DataSource = GlobalVariables.globalvariables.IPDatatable
        End If
        If Not GlobalVariables.globalvariables.NYSDatatable.Rows.Count = 0 Then
            My.Forms.frmMain.taskGridNYS.DataSource = GlobalVariables.globalvariables.NYSDatatable 'Loads data into data tables
        End If
        If Not GlobalVariables.globalvariables.CDatatable.Rows.Count = 0 Then
            My.Forms.frmMain.taskGridC.DataSource = GlobalVariables.globalvariables.CDatatable
        End If
    End Sub
End Module
