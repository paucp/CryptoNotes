using CryptoNotes.Engine.Archive;
using System.IO;
using System.Text;

namespace CryptoNotes.Engine.Crypto
{
    public class HashGenerator
    {
        public static void SaveHash(string Password)
        {
            byte[] Key = Encoding.UTF8.GetBytes(Password);
            byte[] Salt = CryptoFunctions.GenerateCryptoSecureBytes(Settings.Hash.SaltBytes);
            byte[] Hash = CryptoFunctions.DeriveKey(Key, Salt, Settings.Hash.HashBits, Settings.Hash.HashPBKDF2Iterations);
            EncodingStream es = new EncodingStream(File.Open(Settings.Files.HashPath, FileMode.CreateNew));
            es.WriteEntry(Salt);
            es.WriteEntry(Hash);
            es.Close();
        }
    }
}
