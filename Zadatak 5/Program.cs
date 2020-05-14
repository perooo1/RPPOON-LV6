using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger consoleLogger = new ConsoleLogger(MessageType.ALL);
            AbstractLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

            consoleLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(null);

            consoleLogger.Log("Test message ALL", MessageType.ALL);
            consoleLogger.Log("Test message ERROR", MessageType.ERROR);
            consoleLogger.Log("Test message INFO", MessageType.INFO);
            consoleLogger.Log("Test message WARNING", MessageType.WARNING);
            
        }
    }
}
