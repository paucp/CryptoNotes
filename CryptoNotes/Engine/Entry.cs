namespace CryptoNotes
{
    public struct Entry
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public Entry(string Title, string Text)
        {
            this.Title = Title;
            this.Text = Text;
        }
    }
}