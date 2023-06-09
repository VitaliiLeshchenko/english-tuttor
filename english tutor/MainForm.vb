﻿Imports System.Diagnostics.Eventing.Reader
Imports System.IO

Public Class MainForm

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        getFileNames_txt()
        getFileNames_csv()
    End Sub

    Private Sub getFileNames_txt()

        Dim oFSO As Object
        Dim oFolder As Object
        Dim oFile As Object

        oFSO = CreateObject("Scripting.FileSystemObject")
        oFolder = oFSO.GetFolder(Application.StartupPath)

        For Each oFile In oFolder.Files

            If Microsoft.VisualBasic.Right(oFile.Name, 3) = "txt" Then
                ListBox_lessons.Items.Add(oFile.Name)
            End If
        Next oFile
    End Sub

    Private Sub getFileNames_csv()

        Dim oFSO As Object
        Dim oFolder As Object
        Dim oFile As Object

        oFSO = CreateObject("Scripting.FileSystemObject")
        oFolder = oFSO.GetFolder(Application.StartupPath)

        For Each oFile In oFolder.Files

            If Microsoft.VisualBasic.Right(oFile.Name, 3) = "csv" Then
                ListBox_lessons.Items.Add(oFile.Name)
            End If
        Next oFile
    End Sub

    Private Sub Button_startLesson_Click(sender As Object, e As EventArgs) Handles Button_startLesson.Click
        If ListBox_lessons.SelectedItem = "" Then
            MsgBox("Вы не выбрали урок.")
        Else
            If Microsoft.VisualBasic.Right(ListBox_lessons.SelectedItem, 3) = "txt" Then
                LESSON_FORM_txt.Show()
            End If
            If Microsoft.VisualBasic.Right(ListBox_lessons.SelectedItem, 3) = "csv" Then
                LESSON_FORM_csv.Show()
            End If
        End If
    End Sub
End Class
