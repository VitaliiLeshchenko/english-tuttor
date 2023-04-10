Imports System.IO

Module MainModule

    Sub Work(lesson)

        MainForm.Hide()
        LESSON_FORM.Show()

        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "/" & lesson)
        Dim string_line As String
        Dim splitedLine(2) As String

        string_line = reader.ReadLine
        While Not string_line Is Nothing

            splitedLine = Split(string_line, " - ")
            LESSON_FORM.Label_ua.Text = splitedLine(1)

            While LESSON_FORM.TextBox_ans.Text <> splitedLine(0)

                Application.DoEvents()
                'If LESSON_FORM.TextBox_ans.Text = "exit" Then
                'Exit Sub
                'End If

            End While


            string_line = reader.ReadLine
        End While








        reader.Close()

        MsgBox("the lesson end")
        Application.Exit()
    End Sub




End Module
