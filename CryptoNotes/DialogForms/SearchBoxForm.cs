using System;
using System.Windows.Forms;

namespace CryptoNotes
{
    public partial class SearchBox : Form
    {
        private EntryForm entryForm;
        private bool textChanged = false;

        public SearchBox(EntryForm entryForm)
        {
            InitializeComponent();
            Opacity = 0;
            this.panelHeader.BackColor = Settings.UI.ColorAccent;
            this.panelPasswordTextbox.BackColor = Settings.UI.TextBoxFocusColor;
            this.entryForm = entryForm;
        }

        private void SearchBox_Shown(object sender, EventArgs e) => Animation.FadeIn(this);

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (textBoxKeyword.Text != "")
            {
                if (textChanged)
                {
                    this.textChanged = false;
                    this.entryForm.search(textBoxKeyword.Text);
                }
                else this.entryForm.searchNext(textBoxKeyword.Text);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxKeyword.Text != "")
            {
                this.entryForm.searchNext(textBoxKeyword.Text);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (textBoxKeyword.Text != "")
            {
                this.entryForm.searchPrevious(textBoxKeyword.Text);
            }
        }

        private void textBoxKeyword_TextChanged(object sender, EventArgs e)
        {
            this.textChanged = true;
        }
    }
}