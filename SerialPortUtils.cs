using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialCommMonitor
{
    class SerialPortUtils
    {
        public static string[] GetPort()
        {
            try
            {
                RegistryKey hklm = Registry.LocalMachine;

                RegistryKey software11 = hklm.OpenSubKey("HARDWARE");

                //打开"HARDWARE"子健
                RegistryKey software = software11.OpenSubKey("DEVICEMAP");

                RegistryKey sitekey = software.OpenSubKey("SERIALCOMM");
#if TEST
        OutputDebugString(sitekey.ToString());
#endif
                //获取当前子健
                String[] Str2 = sitekey.GetValueNames();

                //获得当前子健下面所有健组成的字符串数组
                int ValueCount = sitekey.ValueCount;
                //获得当前子健存在的健值
                int i;
                string[] rtn = new string[ValueCount];
                for (i = 0; i < ValueCount; i++)
                {
                    rtn[i] = (string)sitekey.GetValue(Str2[i]);
                }
                return rtn;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
#if TEST
        OutputDebugString(e.Message);
#endif
                return null;
            }
        }
    }
}
