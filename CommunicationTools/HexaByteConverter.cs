using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTools
{
    public static class HexaByteConverter
    {
        public static string ByteArrayToHexaString(byte[] bt)
        {
            return BitConverter.ToString(bt).Replace("-", string.Empty);
        }
        public static byte[] HexaStringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}
