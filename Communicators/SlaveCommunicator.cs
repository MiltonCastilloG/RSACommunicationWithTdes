using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationTools;

namespace Communicators
{
    public class SlaveCommunicator : ICommunicator
    {

        RSAGenerator rsa = new RSAGenerator();
        XMLParser xmlParser = new CommunicationTools.XMLParser();
        string saveDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/xmls";
        public string getPublicKey() { return rsa.getPublicKey(); }
        public string getPrivateKey() { return rsa.getPrivateKey(); }
        public void GeneratePublicPrivateKey()
        {
            rsa.setPublicPrivateKey();
        }
        public string ExportXML(string type)
        {
            if (type == "PublicKey")
                return xmlParser.CreatePublicKeyXml(saveDirectory, rsa.getPublicKey());
            throw new NotImplementedException();
        }
        public string ImportXML()
        {
            throw new NotImplementedException();
        }
    }
}
