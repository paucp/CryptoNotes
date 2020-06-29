using CryptoNotes.Engine.Crypto;
using System.Collections.Generic;
using System.IO;

namespace CryptoNotes.Engine.Archive
{
    public static class ArchiveWriter
    {
        public static void WriteArchive(List<Entry> entries, byte[] MasterKey)
        {           
            byte[] IV = CryptoFunctions.GenerateCryptoSecureBytes(Settings.AES.IVBytes);
            byte[] Salt = CryptoFunctions.GenerateCryptoSecureBytes(Settings.AES.SaltBytes);
            byte[] Key = CryptoFunctions.DeriveKey(MasterKey, Salt, Settings.AES.KeyBytes, Settings.AES.AESPBKDF2Iterations);
            SingleUseAESKey singleUseKey = new SingleUseAESKey(Key, Salt, IV);

            Stream FileOutputStream = new FileStream(Settings.Files.ArchivePath, (FileMode)FileAccess.Write);
            Stream AESStream = Crypto.AESStream.CreateEncryptionStream(FileOutputStream, singleUseKey);
            EncodingStream EncoderStream = new EncodingStream(AESStream);

            FileOutputStream.Write(IV, 0, IV.Length);
            FileOutputStream.Write(Salt, 0, Salt.Length);
            EncoderStream.WriteHeader(entries.Count);
            foreach(Entry e in entries)
            {
                EncoderStream.WriteString(e.Title);
                EncoderStream.WriteString(e.Text);
            }

            EncoderStream.Close();
            AESStream.Close();
            FileOutputStream.Close();
        }
    }
}