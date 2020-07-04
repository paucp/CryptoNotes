using CryptoNotes.Engine.Archive;
using CryptoNotes.Engine.Crypto;
using CryptoNotes.Engine.Search;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CryptoNotes
{
    public partial class MainForm : Form
    {
        private bool ArchiveSaved;
        private List<Entry> EntryList;
        private List<Entry> EntryListBackup;
        private AutoCompleteStringCollection TitleList;
        private SearchManager SearchMan;

        public MainForm()
        {
            InitializeComponent();
            this.ArchiveSaved = true;
            this.TitleList = new AutoCompleteStringCollection();
            this.EntryList = new List<Entry>();
            this.Opacity = 0;
            this.textBoxSearch.AutoCompleteCustomSource = TitleList;
            this.panel1.BackColor = Settings.UI.ColorAccent;
            this.labelSearchIcon.Text = Settings.UI.SearchIconText; 
            this.Size = Properties.Settings.Default.MainSize;
            this.listView.Columns[0].Width = 400 + (this.Width - 600);
            this.listView.HideSelection = true;
            if (File.Exists(Settings.Files.ArchivePath))
                LoadEntryList(ArchiveReader.ReadArchive(Session.MasterKey));
            SearchMan = new Engine.Search.SearchManager(ref EntryList);

            Animation.FadeIn(this);
        }
        private void LoadEntryList(List<Entry> entries)
        {
            this.EntryList = new List<Entry>();
            listView.BeginUpdate();
            listView.Items.Clear();
            foreach (Entry pass in entries.ToList()) AddEntry(pass);
            UpdateNameList();
            listView.EndUpdate();
        }

        private void AddEntry(Entry entry)
        {
            ListViewItem item = new ListViewItem(entry.Title);
            item.SubItems.Add(entry.LastChange.ToShortDateString() + " " + entry.LastChange.ToShortTimeString());
            EntryList.Add(entry);
            listView.Items.Add(item);
        }

        private void changeSavedStatus(bool isSavedNew)
        {
            this.ArchiveSaved = isSavedNew;
            this.buttonSave.Enabled = !isSavedNew;
            this.buttonUndo.Enabled = !isSavedNew;
            if (!isSavedNew)
            {
                this.buttonSave.BackColor = Settings.UI.SaveColorAccent;
                this.EntryListBackup = EntryList.ToList();
            }
            else
            {
                this.buttonSave.BackColor = Color.WhiteSmoke;
            }
        }

        private void SaveChanges()
        {
            changeSavedStatus(true);
            ArchiveWriter.WriteArchive(this.EntryList, Session.MasterKey);
            CMessageBox.ShowDialog(Messages.SuccessSaving);
        }

        private void UpdateEntry(int index)
        {
            changeSavedStatus(false);
            var entry = EntryList[index];
            ListViewItem item = new ListViewItem(entry.Title);
            item.SubItems.Add(entry.LastChange.ToShortDateString() + " " + entry.LastChange.ToShortTimeString());
            listView.Items[index] = item;
        }

        private void UpdateNameList()
        {
            foreach (Entry data in EntryList)
                TitleList.Add(data.Title);
        }

        #region Interface

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            listView.Columns[0].Width = 400 + (this.Width - 600);
        }

        private void materialListView1_MouseDoubleClick(object sender, MouseEventArgs e)
            => buttonEdit_Click(sender, null);

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NoteForm NewPassword = new NoteForm(new Entry());
            NewPassword.ShowDialog();
            if (NewPassword.EntryCreatedOrEdited)
            {
                changeSavedStatus(false);
                AddEntry(NewPassword.entry);
                UpdateNameList();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CMessageBox.ShowDialog(Messages.DeleteEntryCheck))
            {
                changeSavedStatus(false);
                int index = listView.SelectedIndices[0];
                EntryList.RemoveAt(index);
                listView.Items.RemoveAt(index);
                UpdateNameList();
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (CMessageBox.ShowDialog(Messages.DeleteAllEntriesCheck))
            {
                changeSavedStatus(false);
                EntryList.Clear();
                listView.Items.Clear();
                UpdateNameList();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = listView.SelectedIndices[0];
            NoteForm editEntryForm = new NoteForm(new Entry());
            editEntryForm.ShowData(EntryList[index]);
            editEntryForm.ShowDialog();
            if (editEntryForm.EntryCreatedOrEdited)
            {
                changeSavedStatus(false);
                EntryList[index] = editEntryForm.entry;
                UpdateEntry(index);
                UpdateNameList();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) => SaveChanges();

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(!ArchiveSaved && !CMessageBox.ShowDialog(Messages.ChangesCheck))
            {
                e.Cancel = true;
            }
           else
            {
                Properties.Settings.Default.MainSize = this.Size;
                Properties.Settings.Default.Save();
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = listView.SelectedItems.Count != 0;
            buttonEdit.Enabled = enable;
            buttonDelete.Enabled = enable;
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            List<Entry> tmp = EntryListBackup;
            this.EntryListBackup = EntryList;
            LoadEntryList(tmp);
        }

        #endregion Interface

        #region ContextMenu

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
          => buttonAdd_Click(null, null);

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
            => buttonDelete_Click(null, null);

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
            => buttonEdit_Click(null, null);

        private void materialContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool enable = listView.SelectedItems.Count != 0;
            deleteToolStripMenuItem.Enabled = enable;
            editToolStripMenuItem.Enabled = enable;
        }

        #endregion ContextMenu

        #region Search

        public void ReleaseSearchBoxFocus()
        {
            panelSearchTextbox.Height = 1;
            panelSearchTextbox.BackColor = Color.Gainsboro;
        }

        public void SetSearchBoxFocus()
        {
            textBoxSearch.Text = "";
            panelSearchTextbox.Height = 2;
            panelSearchTextbox.BackColor = Settings.UI.TextBoxFocusColor;
        }

        private void materialListView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && SearchMan.CanSearchLastString)
                SelectItem(SearchMan.SearchIndexWithLastString());
        }

        private void SelectItem(int index)
        {
            if (index != -1)
            {
                listView.Select();
                listView.Focus();
                listView.Items[index].Focused = true;
                listView.Items[index].Selected = true;
                listView.Items[index].EnsureVisible();
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
            => SetSearchBoxFocus();

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxSearch.Text != "")
                SelectItem(SearchMan.SearchIndex(textBoxSearch.Text));
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
                    => ReleaseSearchBoxFocus();

        #endregion Search
    }
}