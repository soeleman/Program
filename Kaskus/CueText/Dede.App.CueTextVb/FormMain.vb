Imports Dede.App.CueText.Modules

Public Class FormMain
    Sub New()
        InitializeComponent()

        textBoxCueTest.CueText("Cue TextBox")
        maskedTextBoxCueTest.CueText("Cue MaskedTextBox")
        comboBoxCueTest.CueText("Cue ComboBox")
    End Sub
End Class