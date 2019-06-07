using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationTools;

namespace Communicators
{
    public class MasterCommunicator : ICommunicator
    {
        RSAGenerator rsa = new RSAGenerator();
        public string getPublicKey() { return rsa.getPublicKey(); }
        public string getPrivateKey() { return rsa.getPrivateKey(); }
        public void GeneratePublicPrivateKey()
        {
            throw new NotImplementedException();
        }
        public string ExportXML(string type)
        {
            throw new NotImplementedException();
        }
        public string ImportXML()
        {
            throw new NotImplementedException();
        }
    }
}
