using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EcryptionManagers
{
    public class TdesManager
    {
        private TripleDESCryptoServiceProvider desCryptoProvider;

        public TdesManager()
        {
            desCryptoProvider = new TripleDESCryptoServiceProvider();
        }
        public byte[] setKeys(byte[] key)
        {
            desCryptoProvider.Key = key;
            return desCryptoProvider.Key;
        }
        public byte[] setIv(byte[] IV)
        {
            desCryptoProvider.IV = IV;
            return desCryptoProvider.IV;
        }
        public byte[] getKeys()
        {
            return desCryptoProvider.Key;
        }
        public byte[] getIv()
        {
            return desCryptoProvider.IV;
        }
        public byte[] Encrypt(byte[] toEncrypt)
        {
            return desCryptoProvider.CreateEncryptor().TransformFinalBlock(toEncrypt, 0, toEncrypt.Length);
        }
        public byte[] Decrypt(byte[] toDecrypt)
        {
            return desCryptoProvider.CreateDecryptor().TransformFinalBlock(toDecrypt, 0, toDecrypt.Length);
        }
    }
}
