using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoNotes.Engine.Search
{
    public class SearchManager
    {
        public bool CanSearchLastString => LastKeyword != null;

        private List<Entry> Entries;
        private int ElapsedTime = 0;
        private int LastSearchIndex = -1;
        private string LastKeyword;

        public SearchManager(ref List<Entry> entries)
        {
            Entries = entries;
            Task.Run(() => AutoResetSearch());
        }

        public int SearchIndexWithLastString()
            => SearchIndex(LastKeyword);

        public int SearchIndex(string keyword)
        {
            if (keyword == null) return -1;
            else
            {
                keyword = keyword.ToLower();
                LastSearchIndex = Entries.FindIndex(LastSearchIndex + 1, x => keyword.Contains(x.Title.ToLower()) || x.Title.ToLower().Contains(keyword));
                ElapsedTime = 0;
                LastKeyword = keyword;
                if (LastSearchIndex == -1 && LastKeyword == keyword) return SearchIndex(keyword);
                else return LastSearchIndex;
            }
        }

        private void AutoResetSearch()
        {
            while (true)
            {
                Thread.Sleep(100);
                ElapsedTime += 100;
                if (ElapsedTime == 4000 && LastSearchIndex != -1)
                {
                    LastSearchIndex = -1;
                    LastKeyword = null;
                }
            }
        }
    }
}