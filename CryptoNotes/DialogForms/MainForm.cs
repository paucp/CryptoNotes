using CryptoNotes.Engine.Archive;
using CryptoNotes.Engine.Crypto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CryptoNotes
{
    public partial class MainForm : Form
    {
        private List<Entry> EntryList = new List<Entry>();
        private bool IsSaved = true;
        private AutoCompleteStringCollection NameList = new AutoCompleteStringCollection();
        private Engine.Search.SearchManager SearchMan;

        public MainForm()
        {
            InitializeComponent();
            this.Opacity = 0;
            panel1.BackColor = Settings.UI.ColorAccent;           
            textBoxSearch.AutoCompleteCustomSource = NameList;
            labelSearchIcon.Text = Settings.UI.SearchIconText;
        }

        private void changeSavedStatus(bool newStatus)
        {
            this.IsSaved = newStatus;
            if (newStatus)
            {
                buttonSave.Font = new Font(buttonSave.Font, FontStyle.Regular);
                buttonSave.BackColor = Color.Gainsboro;
                buttonSave.ForeColor = Color.Black;
            }
            else
            {
                buttonSave.Font = new Font(buttonSave.Font, FontStyle.Bold);
                buttonSave.BackColor = Settings.UI.SaveColorAccent;
                buttonSave.ForeColor = Color.White;
            }
        }
        private void AddEntry(Entry pass)
        {
            ListViewItem item = new ListViewItem(pass.Title);
            EntryList.Add(pass);
            materialListView1.Items.Add(item);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(Settings.Files.ArchivePath))
            {
                var tempList = ArchiveReader.ReadArchive(Session.MasterKey);
                Invoke((MethodInvoker)delegate
                {
                    materialListView1.BeginUpdate();
                   foreach (Entry pass in tempList) AddEntry(pass);
                    materialListView1.EndUpdate();
                    UpdateNameList();
                });
            }
            Animation.FadeIn(this);
            SearchMan = new Engine.Search.SearchManager(ref EntryList);
        }
        private void materialListView1_MouseDoubleClick(object sender, MouseEventArgs e)
            => buttonEdit_Click(sender, null);

        private void SaveChanges()
        {
            ArchiveWriter.WriteArchive(this.EntryList, Session.MasterKey);
            changeSavedStatus(true);
            CMessageBox.ShowDialog(Messages.SuccessSaving);
        }

        private void UpdateItem(int index)
        {
            var pass = EntryList[index];
            ListViewItem item = new ListViewItem(pass.Title);
            materialListView1.Items[index] = item;
        }

        private void UpdateNameList()
        {
            foreach (Entry data in EntryList) NameList.Add(data.Title);
        }

        #region Interface
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EntryForm NewPassword = new EntryForm(new Entry());
            NewPassword.ShowDialog();
            if (!NewPassword.EntryCreatedOrEdited)
                return;
            AddEntry(NewPassword.entry);
            changeSavedStatus(false);
            UpdateNameList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0 || !CMessageBox.ShowDialog(Messages.DeleteEntryCheck)) return;
            int index = materialListView1.SelectedIndices[0];
            EntryList.RemoveAt(index);
            materialListView1.Items.RemoveAt(index);
            UpdateNameList();
            changeSavedStatus(false);
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (CMessageBox.ShowDialog(Messages.DeleteAllEntriesCheck))
            {
                EntryList.Clear();
                materialListView1.Items.Clear();
                UpdateNameList();
                changeSavedStatus(false);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = materialListView1.SelectedIndices[0];
            EntryForm editEntryForm = new EntryForm(new Entry());
            editEntryForm.ShowData(EntryList[index]);
            editEntryForm.ShowDialog();
            if (!editEntryForm.EntryCreatedOrEdited)
                return;
            EntryList[index] = editEntryForm.entry;
            UpdateItem(index);
            changeSavedStatus(false);
            UpdateNameList();
        }

        private void buttonSave_Click(object sender, EventArgs e) => SaveChanges();
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        => e.Cancel = (!IsSaved && !CMessageBox.ShowDialog(Messages.ChangesCheck));

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = materialListView1.SelectedItems.Count != 0;
            buttonEdit.Enabled = enable;
            buttonDelete.Enabled = enable;
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
            bool enable = materialListView1.SelectedItems.Count != 0;
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
                materialListView1.Select();
                materialListView1.Focus();
                materialListView1.Items[index].Focused = true;
                materialListView1.Items[index].Selected = true;
                materialListView1.Items[index].EnsureVisible();
            }
        }
        private void textBoxSearch_Enter(object sender, EventArgs e)
            => SetSearchBoxFocus();
        private void textBoxSearch_Leave(object sender, EventArgs e)
            => ReleaseSearchBoxFocus();
        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxSearch.Text != "") 
                SelectItem(SearchMan.SearchIndex(textBoxSearch.Text));
        }
        #endregion Search
    }
}