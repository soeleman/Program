namespace Dede.App.CueText
{
    using System;

    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxCueTest;
        private System.Windows.Forms.ComboBox comboBoxCueTest;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCueTest;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(
            Boolean disposing)
        {
            if (disposing && 
                (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCueTest = new System.Windows.Forms.TextBox();
            this.comboBoxCueTest = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCueTest = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxCueTest
            // 
            this.textBoxCueTest.Location = new System.Drawing.Point(12, 40);
            this.textBoxCueTest.Name = "textBoxCueTest";
            this.textBoxCueTest.Size = new System.Drawing.Size(200, 20);
            this.textBoxCueTest.TabIndex = 6;
            // 
            // comboBoxCueTest
            // 
            this.comboBoxCueTest.FormattingEnabled = true;
            this.comboBoxCueTest.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five"});
            this.comboBoxCueTest.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCueTest.Name = "comboBoxCueTest";
            this.comboBoxCueTest.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCueTest.TabIndex = 5;
            // 
            // maskedTextBoxCueTest
            // 
            this.maskedTextBoxCueTest.Location = new System.Drawing.Point(12, 67);
            this.maskedTextBoxCueTest.Name = "maskedTextBoxCueTest";
            this.maskedTextBoxCueTest.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxCueTest.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 98);
            this.Controls.Add(this.textBoxCueTest);
            this.Controls.Add(this.comboBoxCueTest);
            this.Controls.Add(this.maskedTextBoxCueTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cue Text Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}