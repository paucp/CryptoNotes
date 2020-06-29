using CryptoNotes.Engine.Archive;
using System.IO;
using System.Text;

namespace CryptoNotes.Engine.Crypto
{
    public class HashValidator
    {
        private byte[] Salt;
        private byte[] Hash;
        public HashValidator()
        {
            EncodingStream es = new EncodingStream(File.ReadAllBytes(Settings.Files.HashPath));
            this.Salt = es.ReadNextEntry();
            this.Hash = es.ReadNextEntry();
            es.Close();
        }
        public bool CheckCandidate(string candidate)
        {
            byte[] candidateBytes = Encoding.UTF8.GetBytes(candidate);
            byte[] candidateHash = CryptoFunctions.DeriveKey(candidateBytes, this.Salt, Settings.Hash.HashBits, Settings.Hash.HashPBKDF2Iterations);
            return CryptoFunctions.SlowEquals(this.Hash, candidateHash);
        }
    }
}
