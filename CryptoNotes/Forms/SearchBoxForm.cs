using System;
using System.Windows.Forms;

namespace CryptoNotes
{
    public partial class SearchBox : Form
    {
        private bool allowClose = false;
        private RichTextBox richTextBox;
        private bool textChanged = false;
        private int lastIndex = 0;
        private string lastKeyword;


        public void search(string keyword)
        {
            lastIndex = richTextBox.Find(keyword, 0);
            lastKeyword = keyword;
        }

        public void searchNext(string keyword)
        {
            if (lastKeyword != keyword) search(keyword);
            else
            {                
                lastIndex = richTextBox.Find(lastKeyword, lastIndex + 1, RichTextBoxFinds.None);
                if (lastIndex == -1) search(keyword);
            }
        }

        public void searchPrevious(string keyword)
        {
            if (lastKeyword != keyword)
            {
                lastIndex = richTextBox.Find(keyword, 0, RichTextBoxFinds.Reverse);
                lastKeyword = keyword;
            }
            else
            {
                lastIndex = richTextBox.Find(lastKeyword, 0, lastIndex, RichTextBoxFinds.Reverse);
                if (lastIndex == -1) searchPrevious(keyword);
            }
        }

        public void AllowClose()
        {
            this.allowClose = true;
            this.Close();
        }
        public SearchBox(ref RichTextBox richTextBox)
        {
            InitializeComponent();
            Opacity = 0;
            this.panelHeader.BackColor = Settings.UI.ColorAccent;
            this.panelPasswordTextbox.BackColor = Settings.UI.TextBoxFocusColor;
            this.richTextBox = richTextBox;
            Animation.FadeIn(this);
        }

        private void SearchBox_Shown(object sender, EventArgs e) => Animation.FadeIn(this);

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (textBoxKeyword.Text != "")
            {
                if (textChanged)
                {
                    this.textChanged = false;
                    search(textBoxKeyword.Text);
                }
                else searchNext(textBoxKeyword.Text);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxKeyword.Text != "")
            {
                searchNext(textBoxKeyword.Text);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (textBoxKeyword.Text != "")
            {
                searchPrevious(textBoxKeyword.Text);
            }
        }

        private void textBoxKeyword_TextChanged(object sender, EventArgs e)
        {
            this.textChanged = true;
        }

        private void SearchBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!this.allowClose)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}