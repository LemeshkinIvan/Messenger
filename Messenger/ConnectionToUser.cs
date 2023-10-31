using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows;

namespace Messenger
{
    internal class TcpClientConnection
    {
        async public Task<int> Connection(string IP)
        {
            try
            {
                using TcpClient tcpClient = new TcpClient();
                await tcpClient.ConnectAsync(IP, 8888);
                MessageBox.Show("заебись");
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }
}
