using System.Security.Cryptography;

namespace CryptoNotes.Engine.Crypto
{
    public static class CryptoFunctions
    {
        private static RNGCryptoServiceProvider CSP = new RNGCryptoServiceProvider();
        public static byte[] GenerateCryptoSecureBytes(int length)
        {
            byte[] buffer = new byte[length];
            CSP.GetBytes(buffer);
            return buffer;
        }
        public static byte[] DeriveKey(byte[] key, byte[] salt, int length, int iterations)
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(key, salt, iterations);
            return pdb.GetBytes(length);
        }
        public static bool SlowEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i]) return false;
            return true;
        }
    }
}