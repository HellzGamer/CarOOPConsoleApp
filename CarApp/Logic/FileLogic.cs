using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CarApp.Logic
{
    public class FileLogic
    {
        string line;
        public void ReadFromFile()
        {
            string result = string.Empty;
            StreamReader streamReader = new StreamReader("C:\\Users\\DeveshR\\Documents\\CarAppFiles\\CarAppTextFiles.txt");
            line = streamReader.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = streamReader.ReadLine();
            }

            streamReader.Close();
            Console.ReadLine();
        }

        public void WriteToFile(string details)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\DeveshR\\Documents\\CarAppFiles\\CarAppTextFiles.txt", true);

            sw.WriteLine(details, true);
            sw.Close();
        }
    }
}
