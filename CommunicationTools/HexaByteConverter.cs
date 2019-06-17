using System;

namespace CommunicationTools
{
    public static class HexaByteConverter
    {
        public static string ToHexa(byte[] bt)
        {
            return BitConverter.ToString(bt).Replace("-", string.Empty);
        }
        public static byte[] ToByte(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}
