Imports System.IO

Public Class LESSON_FORM
    Dim lessonName As String
    Dim list_lines As New List(Of String)
    Dim listLinesIndex As Integer
    Dim engAns As String

    Private Sub LESSON_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lessonName = MainForm.ListBox_lessons.SelectedItem
        MainForm.Hide()

        Me.CenterToScreen()
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "/" & lessonName)
        Dim string_line As String

        string_line = reader.ReadLine
        While Not string_line Is Nothing
            AddNewLineToList(string_line)
            string_line = reader.ReadLine
            Debug.Print(string_line)
        End While
        reader.Close()

        list_lines = Randomize(list_lines)
        Me.Label_tests_count.Text = "Всього : " & list_lines.Count()
        listLinesIndex = 0
        StartNewLine()
    End Sub

    Private Sub StartNewLine()
        If listLinesIndex < list_lines.Count() Then
            Dim splitedLine(2) As String

            splitedLine = Split(list_lines(listLinesIndex), " - ")
            listLinesIndex += 1
            If splitedLine.Count > 1 Then
                engAns = Trim(splitedLine(0))
                Label_ua.Text = Trim(splitedLine(1))
                Me.Label_test_count.Text = "тест № " & listLinesIndex
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub TextBox_ans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ans.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If String.Compare(TextBox_ans.Text, engAns, True) = 0 Then
                TextBox_ans.Text = ""
                Label_eng.Text = ""
                StartNewLine()
            Else
                Label_eng.Text = engAns
                AddNewLineToList(engAns & " - " & Label_ua.Text)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub LESSON_FORM_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("the end")
        Application.Exit()
    End Sub

    Private Sub AddNewLineToList(string_line As String)
        If string_line Like "* - *" Or string_line Like "* —  *" Then
            string_line = Replace(string_line, "—", "-")
            list_lines.Add(string_line)
        End If
        Me.Label_tests_count.Text = "Всього : " & list_lines.Count()
    End Sub
End Class