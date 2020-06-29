using CryptoNotes.Engine.Crypto;
using System;
using System.Collections.Generic;
using System.IO;

namespace CryptoNotes.Engine.Archive
{
    public static class ArchiveReader
    {
        public static List<Entry> ReadArchive(byte[] MasterKey)
        {
            Stream FileInputStream = File.OpenRead(Settings.Files.ArchivePath);

            byte[] IV = new byte[Settings.AES.IVBytes];
            byte[] Salt = new byte[Settings.AES.SaltBytes];

            FileInputStream.Read(IV, 0, IV.Length);
            FileInputStream.Read(Salt, 0, Salt.Length);

            byte[] Key = CryptoFunctions.DeriveKey(MasterKey, Salt, Settings.AES.KeyBytes, Settings.AES.AESPBKDF2Iterations);

            SingleUseAESKey singleUseKey = new SingleUseAESKey(Key, Salt, IV);

            Stream AESStream = Crypto.AESStream.CreateDecryptionStream(FileInputStream, singleUseKey);
            EncodingStream DecoderStream = new EncodingStream(AESStream);

            int EntriesCount = DecoderStream.ReadHeader();
            List<Entry> Entries = new List<Entry>(EntriesCount);
            for (int i = 0; i < EntriesCount; i++)
            {
                string Title = DecoderStream.ReadNextString();
                string Text = DecoderStream.ReadNextString();
                DateTime LastChange = Convert.ToDateTime(DecoderStream.ReadNextString());
                Entries.Add(new Entry(Title, Text, LastChange));
            }

            DecoderStream.Close();
            AESStream.Close();
            FileInputStream.Close();

            return Entries;
        }
    }
}