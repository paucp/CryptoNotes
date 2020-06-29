using System;
using System.Drawing;
using System.Windows.Forms;

namespace CryptoNotes
{
    public partial class EntryForm : Form
    {
        public Entry entry;
        public bool EntryCreatedOrEdited = false;
        private SearchBox searchBox;
        private string lastKeyword;
        private int lastIndex = 0;

        #region Search
        public void search(string  keyword)
        {
            lastIndex = richTextBox1.Find(keyword, 0);
            lastKeyword = keyword;
        }
        public void searchNext(string keyword)
        {
            if (lastKeyword != keyword) search(keyword);
            else
            {
                lastIndex = richTextBox1.Find(lastKeyword, lastIndex + 1, RichTextBoxFinds.None);
                if (lastIndex == -1)
                    search(keyword);
            }
        }
        public void searchPrevious(string keyword)
        {
            if (lastKeyword != keyword)
            {
                lastIndex = richTextBox1.Find(keyword, 0, RichTextBoxFinds.Reverse);
                lastKeyword = keyword;
            }
            else
            {
                lastIndex = richTextBox1.Find(lastKeyword, 0, lastIndex, RichTextBoxFinds.Reverse);
                if (lastIndex == -1) searchPrevious(keyword);
            }
        }
        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.searchBox.Close();
        }
        #endregion
        public EntryForm(Entry Entry)
        {
            InitializeComponent();
            this.panelHeader.BackColor = Settings.UI.ColorAccent;
            this.textBoxTitle.BackColor = Settings.UI.ColorAccent;
            this.Opacity = 0;
            this.BackColor = Color.White;
            this.entry = Entry;
            searchBox = new SearchBox(this);
            Animation.FadeIn(this);
        }

        public void ShowData(Entry data)
        {
            textBoxTitle.Text = data.Title;
            richTextBox1.Text = data.Text;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "" || richTextBox1.Text == "") CMessageBox.ShowDialog(Messages.EmptyTextBox);
            else
            {
                entry.Title = textBoxTitle.Text;
                entry.Text = richTextBox1.Text;
                EntryCreatedOrEdited = true;
                Close();
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            panelTitleTextBox.BackColor = Color.Gainsboro;
        }
        private void textBoxTitle_Enter(object sender, EventArgs e)
        {
            panelTitleTextBox.BackColor = Color.White;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchBox.Show();
        }

        #region ContextMenu
        private void textBoxContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            undoToolStripMenuItem.Enabled = richTextBox1.CanUndo;
            redoToolStripMenuItem.Enabled = richTextBox1.CanRedo;
            cutToolStripMenuItem.Enabled = richTextBox1.SelectedText != "";
            copyToolStripMenuItem.Enabled = richTextBox1.SelectedText != "";
            pasteToolStripMenuItem.Enabled = richTextBox1.CanPaste(DataFormats.GetFormat(DataFormats.Text));
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        #endregion

    }
}