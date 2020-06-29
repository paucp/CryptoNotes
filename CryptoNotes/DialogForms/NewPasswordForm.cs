using CryptoNotes.Engine.Crypto;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoNotes
{
    public partial class NewPasswordForm : Form
    {
        public bool ValidPasswordSet { get; private set; }

        public NewPasswordForm()
        {            
            InitializeComponent();
            this.ValidPasswordSet = false;
            this.panelHeader.BackColor = Settings.UI.ColorAccent;
            
        }
        private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

        private void setPasswordTask()
        {
            HashGenerator.SaveHash(textBoxPassword1.Text);
            Session.SetMasterKey(textBoxPassword1.Text);
            ValidPasswordSet = true;
            Invoke((MethodInvoker)delegate
            {
                CMessageBox.ShowDialog(Messages.PasswordSet);
                Close();
            });
        }
        private void buttonSet_Click(object sender, EventArgs e)
        {
            if(textBoxPassword1.Text == "" || textBoxPassword1.Text != textBoxPassword2.Text) CMessageBox.ShowDialog(Messages.PasswordsDontMatch);
            else if (textBoxPassword1.Text.Length < Settings.Hash.PlaintextMinimumLength) CMessageBox.ShowDialog(Messages.UnsafePassword);
            else
            {                   
                labelHeader.Text = "Password: Setting ...";
                textBoxPassword1.Enabled = false;
                textBoxPassword2.Enabled = false;
                buttonCancel.Enabled = false;
                buttonSet.Enabled = false;
                new Task(setPasswordTask).Start();
            }                
        }

        private void textBoxPassword1_Enter(object sender, EventArgs e)
        {
            panelPasswordTextBox1.BackColor = Settings.UI.TextBoxFocusColor;
        }
        private void textBoxPassword2_Enter(object sender, EventArgs e)
        {
            panelPasswordTextBox2.BackColor = Settings.UI.TextBoxFocusColor;
        }
        private void textBoxPassword1_Leave(object sender, EventArgs e)
        {
            panelPasswordTextBox1.BackColor = Color.Gainsboro;
        }
        private void textBoxPassword2_Leave(object sender, EventArgs e)
        {
            panelPasswordTextBox2.BackColor = Color.Gainsboro;
        }
    }
}