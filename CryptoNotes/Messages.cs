namespace CryptoNotes
{
    public struct Message
    {
        public Message(string text, string title = null, bool cancelButton = false)
        {
            Text = text;
            Title = title;
            CancelButton = cancelButton;
        }
        public bool CancelButton { get; }
        public string Text { get; }
        public string Title { get; }
    }

    public static class Messages
    {
        public static Message ChangesCheck = new Message("The changes aren't saved. Do you want to continue?", "Program closing", true);
        public static Message CleanupCheck = new Message("All data will be removed, including saved entries and master password, and the program will terminate. Do you want to continue?", "Continue?", true);
        public static Message DeleteAllEntriesCheck = new Message("The entries will be remain until next save. Do you want to continue?", "Continue?", true);
        public static Message DeleteEntryCheck = new Message("The entry will be remain until next save. Do you want to continue?", "Continue?", true);
        public static Message EmptyTextBox = new Message("Required field is empty.", "Error");
        public static Message PasswordsDontMatch = new Message("Passwords don't match.", "Error");
        public static Message SuccessSaving = new Message("Data saved correctly.", "");
        public static Message WrongPassword = new Message("The introduced password is wrong.", "Wrong password");
        public static Message UnsafePassword = new Message("This password is not safe and can't be used, Minimum 12 characters.", "Error");
        public static Message PasswordSet = new Message("Password set correctly.");
    }
}