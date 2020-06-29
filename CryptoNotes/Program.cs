using System;
using System.IO;
using System.Windows.Forms;

namespace CryptoNotes
{
    internal class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool runMainProgram = false;
            if (!File.Exists(Settings.Files.HashPath)) {
                NewPasswordForm npf = new NewPasswordForm();
                npf.ShowDialog();
                runMainProgram = npf.ValidPasswordSet;
            }
            else
            {
                CheckPasswordForm cpf = new CheckPasswordForm();
                cpf.ShowDialog();
                runMainProgram = cpf.ValidLogin;

            }
            if (runMainProgram) Application.Run(new MainForm());
        }
    }
}