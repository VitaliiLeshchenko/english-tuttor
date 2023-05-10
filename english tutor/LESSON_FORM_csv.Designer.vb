<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LESSON_FORM_csv
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label_test_count = New System.Windows.Forms.Label()
        Me.Label_tests_count = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_ua = New System.Windows.Forms.Label()
        Me.Label_eng = New System.Windows.Forms.Label()
        Me.TextBox_ans = New System.Windows.Forms.TextBox()
        Me.Label_engMeaning = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_test_count
        '
        Me.Label_test_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_test_count.Location = New System.Drawing.Point(532, 9)
        Me.Label_test_count.Name = "Label_test_count"
        Me.Label_test_count.Size = New System.Drawing.Size(126, 56)
        Me.Label_test_count.TabIndex = 11
        '
        'Label_tests_count
        '
        Me.Label_tests_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_tests_count.Location = New System.Drawing.Point(664, 9)
        Me.Label_tests_count.Name = "Label_tests_count"
        Me.Label_tests_count.Size = New System.Drawing.Size(126, 56)
        Me.Label_tests_count.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 81)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Вводьте текст доки не буде точного співпадіння." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "регістр не перевіряється."
        '
        'Label_ua
        '
        Me.Label_ua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_ua.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_ua.Location = New System.Drawing.Point(16, 92)
        Me.Label_ua.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_ua.Name = "Label_ua"
        Me.Label_ua.Size = New System.Drawing.Size(775, 100)
        Me.Label_ua.TabIndex = 8
        Me.Label_ua.Text = "Label_ua"
        '
        'Label_eng
        '
        Me.Label_eng.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_eng.Location = New System.Drawing.Point(12, 201)
        Me.Label_eng.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_eng.Name = "Label_eng"
        Me.Label_eng.Size = New System.Drawing.Size(777, 41)
        Me.Label_eng.TabIndex = 7
        '
        'TextBox_ans
        '
        Me.TextBox_ans.AcceptsReturn = True
        Me.TextBox_ans.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox_ans.Location = New System.Drawing.Point(16, 250)
        Me.TextBox_ans.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_ans.Name = "TextBox_ans"
        Me.TextBox_ans.Size = New System.Drawing.Size(776, 44)
        Me.TextBox_ans.TabIndex = 6
        '
        'Label_engMeaning
        '
        Me.Label_engMeaning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_engMeaning.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_engMeaning.Location = New System.Drawing.Point(15, 307)
        Me.Label_engMeaning.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_engMeaning.Name = "Label_engMeaning"
        Me.Label_engMeaning.Size = New System.Drawing.Size(777, 206)
        Me.Label_engMeaning.TabIndex = 12
        Me.Label_engMeaning.Text = "Label_engMeaning"
        '
        'LESSON_FORM_csv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 540)
        Me.Controls.Add(Me.Label_engMeaning)
        Me.Controls.Add(Me.Label_test_count)
        Me.Controls.Add(Me.Label_tests_count)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_ua)
        Me.Controls.Add(Me.Label_eng)
        Me.Controls.Add(Me.TextBox_ans)
        Me.Name = "LESSON_FORM_csv"
        Me.Text = "LESSON_FORM_csv"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_test_count As Label
    Friend WithEvents Label_tests_count As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_ua As Label
    Friend WithEvents Label_eng As Label
    Friend WithEvents TextBox_ans As TextBox
    Friend WithEvents Label_engMeaning As Label
End Class
