namespace Dede.App.CueText
{
    using System.Windows.Forms;

    public partial class FormMain 
        : Form
    {
        public FormMain()
        {
            this.InitializeComponent();

            this.textBoxCueTest.CueText(@"Cue TextBox");
            this.maskedTextBoxCueTest.CueText(@"Cue MaskedTextBox");
            this.comboBoxCueTest.CueText(@"Cue ComboBox");
        }
    }
}