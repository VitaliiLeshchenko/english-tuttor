<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox_lessons = New System.Windows.Forms.ListBox()
        Me.Button_startLesson = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox_lessons
        '
        Me.ListBox_lessons.FormattingEnabled = True
        Me.ListBox_lessons.Location = New System.Drawing.Point(15, 104)
        Me.ListBox_lessons.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox_lessons.Name = "ListBox_lessons"
        Me.ListBox_lessons.Size = New System.Drawing.Size(500, 407)
        Me.ListBox_lessons.TabIndex = 0
        '
        'Button_startLesson
        '
        Me.Button_startLesson.Location = New System.Drawing.Point(386, 639)
        Me.Button_startLesson.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_startLesson.Name = "Button_startLesson"
        Me.Button_startLesson.Size = New System.Drawing.Size(129, 54)
        Me.Button_startLesson.TabIndex = 1
        Me.Button_startLesson.Text = "startLesson"
        Me.Button_startLesson.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 78)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "В папку із цим файлом покладіть .txt файли" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "наповнення в цих файлах має бути та" &
    "ким:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "англійський текст - переклад" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "наприклад" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "english text - англійський текст"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 704)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_startLesson)
        Me.Controls.Add(Me.ListBox_lessons)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_lessons As ListBox
    Friend WithEvents Button_startLesson As Button
    Friend WithEvents Label1 As Label
End Class
