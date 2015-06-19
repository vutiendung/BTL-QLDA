using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApplication2
{
    class startUp
    {
        public static string GetHardDisk_ID()
        {
            string str = string.Empty;
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass("Win32_DiskDrive").GetInstances().GetEnumerator();
                if (enumerator.MoveNext())
                    str = enumerator.Current.Properties["Signature"].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str;
        }
        public static string GetCPU_ID()
        {
            string str1 = string.Empty;
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass("Win32_Processor").GetInstances().GetEnumerator();
                if (enumerator.MoveNext())
                    str1 = enumerator.Current.Properties["ProcessorId"].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str1;
        }
        public static string GetBIOS_ID()
        {
            string str = string.Empty;
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass("Win32_BIOS").GetInstances().GetEnumerator();
                if (enumerator.MoveNext())
                    str = enumerator.Current.Properties["SerialNumber"].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str;
        }

        public static string Get_Infor()
        {
            string str1 = string.Empty;
            string str2;
            try
            {
                string cpuId = startUp.GetCPU_ID();
                string hardDiskId = startUp.GetHardDisk_ID();
                string biosId = startUp.GetBIOS_ID();
                string str3 = startUp.MD5Str(cpuId);
                string str4 = startUp.MD5Str(hardDiskId);
                string str5 = startUp.MD5Str(biosId);
                if (str3.Length > 5)
                    str3 = str3.Substring(0, 5).ToUpper();
                if (str4.Length > 5)
                    str4 = str4.Substring(0, 5).ToUpper();
                if (str5.Length > 5)
                    str5 = str5.Substring(0, 5).ToUpper();
                str2 = str3 + "-" + str4 + "-" + str5;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str2;
        }
        private static string MD5Str(string raw)
        {
            MD5 md5 = MD5.Create();
            StringBuilder stringBuilder = new StringBuilder();
            byte[] bytes = new ASCIIEncoding().GetBytes(raw);
            foreach (byte num in md5.ComputeHash(bytes))
                stringBuilder.Append(num.ToString("x2"));
            return stringBuilder.ToString();
        }
    }
}
