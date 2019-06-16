using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcryptionManagers
{
    interface IEncryptionManager
    {
        byte[] Encrypt(byte[] toEncrypt);
        byte[] Decrypt(byte[] toDecrypt);
    }
}