<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.textBoxCueTest = New System.Windows.Forms.TextBox()
        Me.comboBoxCueTest = New System.Windows.Forms.ComboBox()
        Me.maskedTextBoxCueTest = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'textBoxCueTest
        '
        Me.textBoxCueTest.Location = New System.Drawing.Point(12, 40)
        Me.textBoxCueTest.Name = "textBoxCueTest"
        Me.textBoxCueTest.Size = New System.Drawing.Size(200, 20)
        Me.textBoxCueTest.TabIndex = 12
        '
        'comboBoxCueTest
        '
        Me.comboBoxCueTest.FormattingEnabled = True
        Me.comboBoxCueTest.Items.AddRange(New Object() {"One", "Two", "Three", "Four", "Five"})
        Me.comboBoxCueTest.Location = New System.Drawing.Point(12, 12)
        Me.comboBoxCueTest.Name = "comboBoxCueTest"
        Me.comboBoxCueTest.Size = New System.Drawing.Size(200, 21)
        Me.comboBoxCueTest.TabIndex = 11
        '
        'maskedTextBoxCueTest
        '
        Me.maskedTextBoxCueTest.Location = New System.Drawing.Point(12, 67)
        Me.maskedTextBoxCueTest.Name = "maskedTextBoxCueTest"
        Me.maskedTextBoxCueTest.Size = New System.Drawing.Size(200, 20)
        Me.maskedTextBoxCueTest.TabIndex = 13
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 96)
        Me.Controls.Add(Me.textBoxCueTest)
        Me.Controls.Add(Me.comboBoxCueTest)
        Me.Controls.Add(Me.maskedTextBoxCueTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cue Text Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents textBoxCueTest As System.Windows.Forms.TextBox
    Private WithEvents comboBoxCueTest As System.Windows.Forms.ComboBox
    Private WithEvents maskedTextBoxCueTest As System.Windows.Forms.MaskedTextBox

End Class
