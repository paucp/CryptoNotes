using System.Text;

namespace CryptoNotes.Engine.Crypto
{
    public static class Session
    {
        public static byte[] MasterKey { get; set; }
        public static void SetMasterKey(string MasterKeyString)
        {
            MasterKey = Encoding.UTF8.GetBytes(MasterKeyString);
        }
    }
}
