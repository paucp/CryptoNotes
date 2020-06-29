namespace CryptoNotes.Engine.Crypto
{
    public struct SingleUseAESKey
    {
        public byte[] Key { get; private set; }
        public byte[] Salt { get; private set; }
        public byte[] IV { get; private set; }

        public SingleUseAESKey(byte[] Key, byte[] Salt, byte[] IV)
        {
            this.Key = Key;
            this.Salt = Salt;
            this.IV = IV;
        }
    }
}