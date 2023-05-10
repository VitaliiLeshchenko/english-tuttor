Imports System.IO

Public Class LESSON_FORM_csv
    Dim lessonName As String
    Dim list_lines As New List(Of String)
    Dim listLinesIndex As Integer

    Dim article As String
    Dim engAns As String
    Dim wordType As String
    Dim uaTranslation As String
    Dim engMeaning As String


    Private Sub LESSON_FORM_csc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim splitedLine(5) As String

            splitedLine = Split(list_lines(listLinesIndex), ";")
            listLinesIndex += 1
            If splitedLine.Count > 1 Then
                article = Trim(splitedLine(0))
                engAns = Trim(splitedLine(1))
                wordType = Trim(splitedLine(2))
                uaTranslation = Trim(splitedLine(3))
                engMeaning = Trim(splitedLine(4))

                Me.Label_ua.Text = uaTranslation
                Me.Label_engMeaning.Text = "(" & wordType & ") " & engMeaning
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
                AddNewLineToList(article & ";" & engAns & ";" & wordType & ";" & uaTranslation & ";" & engMeaning)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub LESSON_FORM_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("the end")
        Application.Exit()
    End Sub

    Private Sub AddNewLineToList(string_line As String)
        If Microsoft.VisualBasic.Right(string_line, 1) = "-" Then
            list_lines.Add(string_line)
        End If
        Me.Label_tests_count.Text = "Всього : " & list_lines.Count()
    End Sub




End Class