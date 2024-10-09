using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TechShop.exceptions
{
   

    public class Logger
    {
        public void LogError(string message)
        {
            try
            {
                File.AppendAllText("error_log.txt", $"{DateTime.Now}: {message}\n");
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("Failed to write to log file: " + ioEx.Message);
            }
        }
    }

}
