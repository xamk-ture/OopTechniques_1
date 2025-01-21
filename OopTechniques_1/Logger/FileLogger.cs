using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTechniques_1.Logger
{
    public class FileLogger
    {
        public void WriteToFile(string message)
        {
            File.AppendAllText("log.txt", message + "\n");
        }
    }
}
