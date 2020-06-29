using System;
using System.Windows.Forms;

namespace CryptoNotes
{
    public enum CMEssageBoxResult
    {
        Accept = 0,
        Cancel = 1
    }

    public partial class CMessageBox : Form
    {
        public CMEssageBoxResult Result = CMEssageBoxResult.Cancel;
        private const int minWidth = 315;

        public CMessageBox()
        {
            InitializeComponent();
            Opacity = 0;
            panelHeader.BackColor = Settings.UI.ColorAccent;
            labelTitle.Text = null;
            labelText.Text = null;
        }
        private string SplitLargeString(string value)
        {
            string temp = value;
            int index = temp.IndexOf(" ", Settings.UI.CMessageBoxMaxLineLength) + 1;
            temp = temp.Substring(0, index) + '\n' + temp.Substring(index, value.Length - index);
            return temp;
        }
        public CMEssageBoxResult ShowCDialog(string message, string Title, bool ShowCancelButton = false)
        {
            if (message.Length > Settings.UI.CMessageBoxMaxLineLength)
                message = SplitLargeString(message);
            labelText.Text = message;
            labelTitle.Text = Title;
            if (labelText.Width > (minWidth - 50))
                Width = (labelText.Width + 100);
            if (!ShowCancelButton) buttonCancel.Dispose();
            ShowDialog();
            return Result;
        }
        public static bool ShowDialog(Message Message) => ShowDialog(Message.Text, Message.Title, Message.CancelButton);

        public static bool ShowDialog(string Text, string Title = null, bool ShowCancelButton = false)
         => new CMessageBox().ShowCDialog(Text, Title, ShowCancelButton) == CMEssageBoxResult.Accept;

        private void buttonCancel_Click(object sender, EventArgs e)
            => Close();

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Result = CMEssageBoxResult.Accept;
            Close();
        }
        private void CMessageBox_Shown(object sender, EventArgs e) => Animation.FadeIn(this, 10);
    }
}