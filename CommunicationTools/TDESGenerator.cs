using System;
using System.Text;
using System.Security.Cryptography;

namespace CommunicationTools
{
    public class TDESGenerator
    {
        private static TripleDESCryptoServiceProvider desCryptoProvider;

        public TDESGenerator() {
            desCryptoProvider = new TripleDESCryptoServiceProvider();
        }
        public byte[] setKeys(byte[] key)
        {
            desCryptoProvider.Key = key;
            return desCryptoProvider.Key;
        }
        public byte[] setIV(byte[] IV)
        {
            desCryptoProvider.IV = IV;
            return desCryptoProvider.IV;
        }
        public byte[] getKeys() {
            return desCryptoProvider.Key;
        }
        public byte[] getInitializationVector()
        {
            return desCryptoProvider.IV;
        }
        public byte[] Encrypt(byte[] source)
        {
            desCryptoProvider.Mode = CipherMode.ECB;
            return desCryptoProvider.CreateEncryptor().TransformFinalBlock(source, 0, source.Length);
        }
        public byte[] Decrypt(byte[] encodedByte)
        {
            desCryptoProvider.Mode = CipherMode.ECB;
            return desCryptoProvider.CreateDecryptor().TransformFinalBlock(encodedByte, 0, encodedByte.Length);
        }
    }
}
