using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTechniques_1.Logger
{
    // Poorly Implemented Logger Classes
    public class ConsoleLogger
    {
        public void WriteToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
