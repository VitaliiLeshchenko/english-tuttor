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
        Me.SuspendLayout()
        '
        'TextBox_ans
        '
        Me.TextBox_ans.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox_ans.Location = New System.Drawing.Point(11, 467)
        Me.TextBox_ans.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox_ans.Name = "TextBox_ans"
        Me.TextBox_ans.Size = New System.Drawing.Size(776, 44)
        Me.TextBox_ans.TabIndex = 0
        '
        'Label_eng
        '
        Me.Label_eng.AutoSize = True
        Me.Label_eng.Location = New System.Drawing.Point(9, 414)
        Me.Label_eng.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_eng.Name = "Label_eng"
        Me.Label_eng.Size = New System.Drawing.Size(39, 13)
        Me.Label_eng.TabIndex = 1
        Me.Label_eng.Text = "Label1"
        '
        'Label_ua
        '
        Me.Label_ua.AutoSize = True
        Me.Label_ua.Location = New System.Drawing.Point(9, 349)
        Me.Label_ua.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_ua.Name = "Label_ua"
        Me.Label_ua.Size = New System.Drawing.Size(39, 13)
        Me.Label_ua.TabIndex = 2
        Me.Label_ua.Text = "Label2"
        '
        'LESSON_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 650)
        Me.Controls.Add(Me.Label_ua)
        Me.Controls.Add(Me.Label_eng)
        Me.Controls.Add(Me.TextBox_ans)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LESSON_FORM"
        Me.Text = "LESSON_FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_ans As TextBox
    Friend WithEvents Label_eng As Label
    Friend WithEvents Label_ua As Label
End Class
