using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicators
{
    interface ICommunicator
    {
        void GeneratePublicPrivateKey();
        string getPrivateKey();
        string getPublicKey();
        string ExportXML(string type);
        string ImportXML();

    }
}
