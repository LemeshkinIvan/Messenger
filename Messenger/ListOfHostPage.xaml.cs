using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Messenger
{
    /// <summary>
    /// Interaction logic for ListOfHostPage.xaml
    /// </summary>
    public partial class ListOfHostPage : Window
    {
        public ListOfHostPage(string IP)
        {
            InitializeComponent();
            lblTitle.Content = "List of IP you have communicated with";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MPage = new MainWindow();
            MPage.Show();
            this.Close();
        }

        private async void listOfCommunicateIP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> text = await IPListManager.readFile();
            //тупо, да
            listOfCommunicateIP.Items.Add(text.ToArray());
        }
    }
}
