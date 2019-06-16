using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationTools;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using EcryptionManagers;

namespace Communicators
{
    public class SlaveCommunicator : ICommunicator
    {
        private string[] tdesKeysString;
        private byte[] tdesKeyByte;
        private string encryptedMessage;
        private string iv;

        private string saveDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/xmls";
        private RsaManager rsa;
        private TdesManager tdes;

        public SlaveCommunicator() {
            tdes = new TdesManager();
            tdesKeyByte = new byte[24];
        }
        public void GeneratePublicPrivateKey()
        {
            rsa = new RsaManager();
        }
        public string getPublicKey() {
            return rsa.getPublicKey();
        }
        public string getPrivateKey() {
            return rsa.getPrivateKey();
        }
        
        public string ExportXML(string type)
        {
            if (type == "public_key")
                return XmlParser.CreatePublicKeyXml(saveDirectory, rsa.getPublicKey());
            else if (type == "message")
                return XmlParser.CreateMessageXml(saveDirectory, encryptedMessage);
            throw new NotImplementedException();
        }
        public string ImportXML(string path, string type)
        {
            if (type == "encrypted_tdes")
            {
                string[] xmlResponse = XmlParser.ReadXmlTdes(path);
                this.tdesKeysString = xmlResponse.ToList().Take(3).ToArray();
                this.iv = xmlResponse[3];
                return tdesKeysString[0]+ tdesKeysString[1]+tdesKeysString[2];
            }
            throw new NotImplementedException();
        }
        public string DecryptTdesKey()
        {
            int count = 0;
            foreach (string s in tdesKeysString)
            {
                rsa.Decrypt(HexaByteConverter.ToByte(s)).CopyTo(tdesKeyByte, count);
                count += 8;
            }
            this.tdes.setKeys(tdesKeyByte);
            this.tdes.setIv(rsa.Decrypt(HexaByteConverter.ToByte(iv)));
            return HexaByteConverter.ToHexa(tdesKeyByte);
        }
        public string EncryptWithTdes(string message)
        {
            byte[] messageByte = new ASCIIEncoding().GetBytes(message);
            encryptedMessage = HexaByteConverter.ToHexa(tdes.Encrypt(messageByte));
            return encryptedMessage;
        }
    }
}
