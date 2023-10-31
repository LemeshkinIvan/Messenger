using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Messenger
{
    static class DeviceInfo
    {
        static private string Host = System.Net.Dns.GetHostName();
        static private string IP = "Undefiend";
        static private string NameDevice = "Undefined";

        static public string getHostName()
        {
            return Host;
        }
        static private void setIP()
        {
            try
            {
                IP = System.Net.Dns.GetHostByName(Host).AddressList[1].ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        static public string getIP()
        {
            setIP();
            return IP;
        }
    }
}
