using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunicationTools;
using EcryptionManagers;

namespace Communicators
{
    public class MasterCommunicator
    {
        private byte[] tdesKeys;
        private string slavePublicKey;
        private string encryptedMessage;
        private IList<string> tdesListHexaString = new List<string>();

        private string saveDirectory = Environment.CurrentDirectory + "/xml";
        private RsaManager rsa;
        private TdesManager tdes;

        public MasterCommunicator() {
            rsa = new RsaManager();
            tdes = new TdesManager();
        }
        
        public string getPublicKey() {
            return rsa.getPublicKey();
        }
        public string getPrivateKey() {
            return rsa.getPrivateKey();
        }
        public string[] EncryptTdesWithPublicKey()
        {
            IList<byte[]> tdesList = new List<byte[]>();
            tdesList.Add(tdesKeys.Take(8).ToArray());
            tdesList.Add(tdesKeys.Skip(8).Take(8).ToArray());
            tdesList.Add(tdesKeys.Skip(16).Take(8).ToArray());
            foreach (byte[] bt in tdesList)
            {
                tdesListHexaString.Add(HexaByteConverter.ToHexa(rsa.Encrypt(bt)));
            }
            return tdesListHexaString.ToArray();
        }
        public string ExportXML(string type)
        {
            if (type == "encrypted_tdes")
            {
                return XmlParser.CreateTdesXml(saveDirectory, tdesListHexaString.ToArray(), HexaByteConverter.ToHexa(rsa.Encrypt(tdes.getIv())));
            }
            throw new NotImplementedException();
        }
        public string ImportXML(string path, string type)
        {
            if (type == "public_key") {
                slavePublicKey = XmlParser.ReadXmlGeneric(path, "clavepublica");
                rsa.setPublicKeyByImporting(slavePublicKey);
                return slavePublicKey;
            }
            else if (type == "message") {
                encryptedMessage = XmlParser.ReadXmlGeneric(path, "textoe");
                return encryptedMessage;
            }
            throw new NotImplementedException();
        }
        public string setTdesKeys()
        {
            tdesKeys = tdes.getKeys();
            return HexaByteConverter.ToHexa(tdesKeys);
        }
        public string DecryptMessage()
        {
            byte[] byteMessage = HexaByteConverter.ToByte(encryptedMessage);
            return new ASCIIEncoding().GetString(tdes.Decrypt(byteMessage));
        }
    }
}
