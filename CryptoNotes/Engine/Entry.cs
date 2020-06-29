using System;

namespace CryptoNotes
{
    public struct Entry
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime LastChange { get; set; }

        public Entry(string Title, string Text, DateTime LastChange)
        {
            this.Title = Title;
            this.Text = Text;
            this.LastChange = LastChange;
        }
    }
}