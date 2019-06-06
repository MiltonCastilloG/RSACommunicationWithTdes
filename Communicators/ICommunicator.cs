using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicators
{
    interface ICommunicator
    {
        string[] GeneratePublicPrivateKey();
        string ExportXML();
        string ImportXML();

    }
}
