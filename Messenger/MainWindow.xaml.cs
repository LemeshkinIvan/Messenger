using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Messenger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string endPoint;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DevicePage userDP = new DevicePage();
            userDP.Show();
            this.Close();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (endPointTb.Text == null)
            {
                MessageBox.Show("IP endpoint is undefiend");
            }
            else
            {
                endPoint = endPointTb.Text;
                int isWriting = await IPListManager.writtingToFile(endPoint);

                if (isWriting != 0)
                {
                    MessageBox.Show("");
                    //return;
                }
                // проверить на бред
                //connect to other user IP
                TcpClientConnection conn = new TcpClientConnection();
                int res = await conn.Connection(endPoint);

                //if (res == 1)
                {
                    MessengerPage space = new MessengerPage();
                    space.Show();
                    this.Close();
                }
            }       
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListOfHostPage lPage = new ListOfHostPage(endPoint);
            lPage.Show();
            this.Close();
        }
    }
}