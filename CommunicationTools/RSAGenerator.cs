using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CommunicationTools
{
    public class RSAGenerator
    {
        private RSACryptoServiceProvider rsa;
        //  private RSAParameters _privateKey;
        //  private RSAParameters _publicKey;

        public RSAGenerator()
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
        public byte[] EncryptBytes(byte[] toEncrypt)
        {
            return rsa.Encrypt(toEncrypt, true);
        }
        public byte[] DecryptBytes(byte[] toDecrypt)
        {
            return rsa.Decrypt(toDecrypt, true);
        }
    }
}
