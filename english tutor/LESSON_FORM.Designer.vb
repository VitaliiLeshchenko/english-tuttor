<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LESSON_FORM
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
        Me.TextBox_ans = New System.Windows.Forms.TextBox()
        Me.Label_eng = New System.Windows.Forms.Label()
        Me.Label_ua = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_tests_count = New System.Windows.Forms.Label()
        Me.Label_test_count = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_ans
        '
        Me.TextBox_ans.AcceptsReturn = True
        Me.TextBox_ans.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox_ans.Location = New System.Drawing.Point(11, 571)
        Me.TextBox_ans.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_ans.Name = "TextBox_ans"
        Me.TextBox_ans.Size = New System.Drawing.Size(776, 44)
        Me.TextBox_ans.TabIndex = 0
        '
        'Label_eng
        '
        Me.Label_eng.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_eng.Location = New System.Drawing.Point(7, 513)
        Me.Label_eng.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_eng.Name = "Label_eng"
        Me.Label_eng.Size = New System.Drawing.Size(777, 41)
        Me.Label_eng.TabIndex = 1
        '
        'Label_ua
        '
        Me.Label_ua.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_ua.Location = New System.Drawing.Point(9, 472)
        Me.Label_ua.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_ua.Name = "Label_ua"
        Me.Label_ua.Size = New System.Drawing.Size(777, 41)
        Me.Label_ua.TabIndex = 2
        Me.Label_ua.Text = "Label_ua"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 81)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Вводьте текст доки не буде точного співпадіння." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "регістр не перевіряється."
        '
        'Label_tests_count
        '
        Me.Label_tests_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_tests_count.Location = New System.Drawing.Point(660, 9)
        Me.Label_tests_count.Name = "Label_tests_count"
        Me.Label_tests_count.Size = New System.Drawing.Size(126, 56)
        Me.Label_tests_count.TabIndex = 4
        '
        'Label_test_count
        '
        Me.Label_test_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_test_count.Location = New System.Drawing.Point(528, 9)
        Me.Label_test_count.Name = "Label_test_count"
        Me.Label_test_count.Size = New System.Drawing.Size(126, 56)
        Me.Label_test_count.TabIndex = 5
        '
        'LESSON_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 650)
        Me.Controls.Add(Me.Label_test_count)
        Me.Controls.Add(Me.Label_tests_count)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_ua)
        Me.Controls.Add(Me.Label_eng)
        Me.Controls.Add(Me.TextBox_ans)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LESSON_FORM"
        Me.Text = "LESSON_FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_ans As TextBox
    Friend WithEvents Label_eng As Label
    Friend WithEvents Label_ua As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_tests_count As Label
    Friend WithEvents Label_test_count As Label
End Class
