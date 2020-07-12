using System;
using System.Drawing;
using System.Windows.Forms;

namespace CryptoNotes
{
    public partial class NoteForm : Form
    {
        public Entry entry;
        public bool EntryCreatedOrEdited = false;
        private SearchBox searchBox;

        #region Search

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.searchBox.AllowClose();
            Properties.Settings.Default.NoteFormSize = this.Size;
        }

        #endregion Search

        public NoteForm(Entry Entry)
        {
            InitializeComponent();
            this.Size = Settings.UI.EntryFormSize;
            this.panelHeader.BackColor = Settings.UI.ColorAccent;
            this.textBoxTitle.BackColor = Settings.UI.ColorAccent;
            this.Opacity = 0;
            this.BackColor = Color.White;
            this.entry = Entry;
            this.Size = Properties.Settings.Default.NoteFormSize;
            this.richTextBox1.Font = Properties.Settings.Default.NoteFont;
            this.searchBox = new SearchBox(ref this.richTextBox1);
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
                entry.LastChange = DateTime.Now;
                EntryCreatedOrEdited = true;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.searchBox.Show();
        }

        private void EntryForm_ResizeEnd(object sender, EventArgs e)
        {
            Settings.UI.EntryFormSize = this.Size;
        }

        private void textBoxTitle_Enter(object sender, EventArgs e)
        {
            panelTitleTextBox.BackColor = Color.White;
            textBoxTitle.ForeColor = Color.White;
        }

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            panelTitleTextBox.BackColor = Color.Gainsboro;
            textBoxTitle.ForeColor = Color.Gainsboro;
        }

        #region ContextMenu

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

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

        #endregion ContextMenu

        private void buttonFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.Font;
            fd.ShowDialog();
            richTextBox1.Font = fd.Font;
            Properties.Settings.Default.NoteFont = fd.Font;
        }
    }
}