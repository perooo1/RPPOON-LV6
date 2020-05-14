using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5
{
    class FileLogger : AbstractLogger
    {
        private string fileName;
        
        public FileLogger(MessageType messageType, string fileName) : base(messageType)
        {
            this.fileName = fileName;
        }

        protected override void WriteMessage(string message, MessageType type)
        {
            using(System.IO.StreamWriter writer = File.AppendText(fileName))
            {
                writer.WriteLine(type + ": " + DateTime.Now);
                writer.WriteLine(new string('=', message.Length));
                writer.WriteLine(message);
                writer.WriteLine(new string('=', message.Length) + "\n");
            }
            
        }

    }
}
