Imports System.IO
Module Reminders
    Sub Reminders()

        GlobalVariables.globalvariables.subtasktable.Rows.Clear()
        Dim filepath = Path.Combine(Application.StartupPath, "Tasks")
        Dim dirinfo As New DirectoryInfo(filepath)
        Dim allfileinfo As String
        Dim splitfileinfo() As String
        Dim listofTasks As String = ""
        Dim dateSubtract As String = Now.Date.AddDays(-3) 'Calculates the data 3 days ago



        For Each fileinfo As FileInfo In dirinfo.GetFiles()
            allfileinfo = File.ReadAllText(fileinfo.FullName)
            splitfileinfo = allfileinfo.Split("|")
            If splitfileinfo(3) = "Yes" Then 'Checks if reminders are turned on
                If splitfileinfo(5) >= Now.Date.AddDays(-3) Then 'Checks if the end date is 3 or less days from now
                    listofTasks = listofTasks + splitfileinfo(0) & " " 'Adds task to list of tasks
                End If
            End If
        Next
        MsgBox("The following tasks have deadlines occuring within the next 3 days: " & listofTasks)
    End Sub
End Module
