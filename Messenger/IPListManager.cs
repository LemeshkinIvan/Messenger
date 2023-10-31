using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace Messenger
{
    static class IPListManager
    {
        private static string Path = "listIp.txt";
        async static public Task<int> writtingToFile(string IP)
        {
            // to db later
            try
            {
                using (StreamWriter writer = new StreamWriter(Path, true))
                {
                    await writer.WriteLineAsync(IP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }

            return 0;
        }
        async static public Task<List<string>> readFile()
        {
            List<string> text = new List<string>();

            using (StreamReader reader = new StreamReader(Path))
            {
                try
                {
                    string? line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        text.Add(line);
                    }
                }
                catch (Exception ex)
                {
                    text.Add(ex.Message);
                    return text;
                }

                return text;
            }
        }
    }
}
