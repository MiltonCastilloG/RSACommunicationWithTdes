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
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(512);
        private string _privateKey;
        private string _publicKey;
        private string stringSerializer(RSAParameters key)
        {
            string keyString;
            {
                var sw = new System.IO.StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, key);
                //get the string from the stream
                keyString = sw.ToString();
            }
            return keyString;

        }
        public string setPublicKey()
        {
            RSAParameters publicKey = rsa.ExportParameters(false);
            _publicKey = this.stringSerializer(publicKey);
            return _publicKey;
        }
        public string setPrivateKey()
        {
            RSAParameters privateKey = rsa.ExportParameters(true);
            _privateKey = this.stringSerializer(privateKey);
            return _privateKey;

        }
        public string getPublicKey()
        {
            return _publicKey;
        }
        public string getPrivateKey()
        {
            return _privateKey;
        }

    }
}
