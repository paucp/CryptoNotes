using System.IO;
using System.Security.Cryptography;

namespace CryptoNotes.Engine.Crypto
{
    public class AESStream
    {
        public static CryptoStream CreateEncryptionStream(Stream BaseStream, SingleUseAESKey singleUseKeyData)
        {
            return new CryptoStream(BaseStream, CreateAES(singleUseKeyData).CreateEncryptor(), CryptoStreamMode.Write);
        }

        public static CryptoStream CreateDecryptionStream(Stream BaseStream, SingleUseAESKey singleUseKeyData)
        {
            return new CryptoStream(BaseStream, CreateAES(singleUseKeyData).CreateDecryptor(), CryptoStreamMode.Read);
        }

        private static RijndaelManaged CreateAES(SingleUseAESKey singleUseKeyData)
        {
            RijndaelManaged AES = new RijndaelManaged();
            AES.BlockSize = Settings.AES.BlockBits;
            AES.Key = singleUseKeyData.Key;
            AES.IV = singleUseKeyData.IV;
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CBC;
            return AES;
        }
    }
}