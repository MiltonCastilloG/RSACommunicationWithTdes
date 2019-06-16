using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EcryptionManagers
{
    public class RsaManager : IEncryptionManager
    {
        private RSACryptoServiceProvider rsa;

        public RsaManager()
        {
            rsa = new RSACryptoServiceProvider(512);
        }
        public void setPublicKeyByImporting(string publicKeyString)
        {
            rsa.FromXmlString(publicKeyString);
        }
        public string getPublicKey()
        {
            return rsa.ToXmlString(false);
        }
        public string getPrivateKey()
        {
            return rsa.ToXmlString(true);
        }
        public byte[] Encrypt(byte[] toEncrypt)
        {
            return rsa.Encrypt(toEncrypt, true);
        }
        public byte[] Decrypt(byte[] toDecrypt)
        {
            return rsa.Decrypt(toDecrypt, true);
        }
    }
}
