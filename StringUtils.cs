using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialCommMonitor
{
    class StringUtils
    {
        public static String bytes2HexString(byte[] buff)
        {
            return BitConverter.ToString(buff, 0).ToLower(); ;
        }

        public static byte[] hexString2Bytes(String s)
        {
            var inputByteArray = new byte[s.Length / 2];
            for (var x = 0; x < inputByteArray.Length; x++)
            {
                var i = Convert.ToInt32(s.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            return inputByteArray;
        }

        public static String bytes2ASCIIString(byte[] buff)
        {
            return System.Text.Encoding.Default.GetString(buff);
        }

        public static String getNowDateString()
        {
            return DateTime.Now.ToString();
        }
    }
}
