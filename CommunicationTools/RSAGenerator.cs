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
        private static RSACryptoServiceProvider rsa;
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;
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
        public void setPublicPrivateKey()
        {
            rsa = new RSACryptoServiceProvider(512);
            _publicKey = rsa.ExportParameters(false);
            _privateKey = rsa.ExportParameters(true);

        }
        public string getPublicKey()
        {
            return rsa.ToXmlString(false);
        }
        public string getPrivateKey()
        {
            return rsa.ToXmlString(true);
        }   
    }
}
