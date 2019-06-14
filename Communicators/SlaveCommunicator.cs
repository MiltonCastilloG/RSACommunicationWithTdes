using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationTools;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Communicators
{
    public class SlaveCommunicator : ICommunicator
    {
        private string[] tdesKeysString;
        private byte[] tdesKeyByte;

        private string saveDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/xmls";
        private RSAGenerator rsa;
        private TDESGenerator tdes;

        public SlaveCommunicator() {
            tdes = new TDESGenerator();
            tdesKeyByte = new byte[24];
        }
        public void GeneratePublicPrivateKey()
        {
            rsa = new RSAGenerator();
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
                return XMLParser.CreatePublicKeyXml(saveDirectory, rsa.getPublicKey());
            throw new NotImplementedException();
        }
        public string ImportXML(string path, string type)
        {
            if (type == "encrypted_tdes")
            {
                tdesKeysString = XMLParser.ReadXmlTdes(path);
                return tdesKeysString[0]+ tdesKeysString[1]+tdesKeysString[2];
            }
            throw new NotImplementedException();
        }
        public string DecryptTdesKey()
        {
            int count = 0;
            foreach (string s in tdesKeysString)
            {
                rsa.DecryptBytes(HexaByteConverter.HexaStringToByteArray(s)).CopyTo(tdesKeyByte, count);
                count += 8;
            }
            return HexaByteConverter.ByteArrayToHexaString(tdesKeyByte);
        }
        public string EncryptWithTdes(string message) {
            byte[] messageByte = new ASCIIEncoding().GetBytes(message);
            return HexaByteConverter.ByteArrayToHexaString(tdes.Encrypt(messageByte));
        }
    }
}
