using CryptoNotes.Engine.Crypto;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoNotes
{
    public partial class CheckPasswordForm : Form
    {
        public bool ValidLogin { get; private set; }
        private HashValidator validator;

        public CheckPasswordForm()
        {
            InitializeComponent();
            Opacity = 0;
            this.panelHeader.BackColor = Settings.UI.ColorAccent;
            this.panelPasswordTextbox.BackColor = Settings.UI.TextBoxFocusColor;
            this.ValidLogin = false;
            this.validator = new HashValidator();
            Animation.FadeIn(this);
        }

        private void buttonCleanup_Click(object sender, EventArgs e)
        {
            if (CMessageBox.ShowDialog(Messages.CleanupCheck))
            {
                File.Delete(Settings.Files.ArchivePath);
                File.Delete(Settings.Files.HashPath);
                Environment.Exit(0);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "") return;
            new Task(() => CheckPassword(textBoxPassword.Text)).Start();
            labelHeader.Text = "Password: Checking . . .";
        }

        private void CheckPassword(string keyCandidate)
        {
            LockUI(false);
            if (keyCandidate.Length < Settings.Hash.PlaintextMinimumLength || !validator.CheckCandidate(keyCandidate))
            {
                ShowErrorMessage();
                LockUI(true);
            }
            else
            {
                Session.SetMasterKey(keyCandidate);
                this.ValidLogin = true;
                Invoke((MethodInvoker)delegate
                {
                    Close();
                });
            }
        }

        private void CheckPasswordForm_Shown(object sender, EventArgs e)
        {
        }

        private void LockUI(bool flag)
        {
            Invoke((MethodInvoker)delegate
            {
                textBoxPassword.Enabled = flag;
                buttonLogin.Enabled = flag;
                buttonCleanup.Enabled = flag;
            });
        }

        private void ShowErrorMessage()
        {
            Invoke((MethodInvoker)delegate
            {
                CMessageBox.ShowDialog(Messages.WrongPassword);
                labelHeader.Text = "Password:";
            });
        }
    }
}