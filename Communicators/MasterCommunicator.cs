using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationTools;

namespace Communicators
{
    public class MasterCommunicator
    {
        private byte[] tdesKeys;
        private string slavePublicKey;
        private IList<string> tdesListHexaString = new List<string>();

        private string saveDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/xmls";
        private RSAGenerator rsa;
        private TDESGenerator tdes;

        public MasterCommunicator() {
            rsa = new RSAGenerator();
            tdes = new TDESGenerator();
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
                tdesListHexaString.Add(HexaByteConverter.ByteArrayToHexaString(rsa.EncryptBytes(bt)));
            }
            return tdesListHexaString.ToArray();
        }
        public string ExportXML(string type)
        {
            if (type == "encrypted_tdes")
            {
                return XMLParser.CreateTdesXml(saveDirectory, tdesListHexaString.ToArray());
            }
            throw new NotImplementedException();
        }
        public string ImportXML(string path, string type)
        {
            if (type == "public_key") {
                slavePublicKey = XMLParser.ReadXmlGeneric(path, "clavepublica");
                rsa.setPublicKeyByImporting(slavePublicKey);
                return slavePublicKey;
            }
            throw new NotImplementedException();
        }
        public string setTdesKeys()
        {
            tdesKeys = tdes.getKeys();
            return HexaByteConverter.ByteArrayToHexaString(tdesKeys);
        }
    }
}
