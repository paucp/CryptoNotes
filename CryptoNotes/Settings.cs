using System.Drawing;
using System.Windows.Forms;

namespace CryptoNotes
{
    public static class Settings
    {
        //UI SETTINGS
        public static class UI
        {
            public const string SearchIconText = "";
            public const int CMessageBoxMaxLineLength = 50;
            public const int AnimationInterval = 3;
            public static readonly Color SaveColorAccent = Color.FromArgb(96, 125, 170);
            public static readonly Color ColorAccent = Color.FromArgb(96, 125, 139);
            public static readonly Color TextBoxFocusColor = Color.FromArgb(200, 96, 125, 170);
            public static Size EntryFormSize = new Size(new Point(800, 600));
        }

        //HASH SETTINGS
        public static class Hash
        {
            public const int PlaintextMinimumLength = 10;
            public const int HashPBKDF2Iterations = 4097;
            public const int HashBytes = 1024;
            public const int SaltBytes = 256;
        }

        //AES SETTINGS
        public static class AES
        {
            public const int AESPBKDF2Iterations = 2048;
            public const int KeyBytes = 32;
            public const int BlockBits = 128;
            public const int IVBytes = 16;
            public const int SaltBytes = 256;
        }

        //FILE SETTINGS
        public static class Files
        {
            public static readonly string UserDataFolderPath = Application.StartupPath + @"\UserData\";
            public static readonly string HashPath = UserDataFolderPath + "hash.pm";
            public static readonly string ArchivePath = UserDataFolderPath + "archive.pm";
        }
    }
}