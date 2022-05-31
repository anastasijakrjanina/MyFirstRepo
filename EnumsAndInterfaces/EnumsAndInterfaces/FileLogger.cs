using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndInterfaces
{
        public class FileLogger : ILogger
        {
            public void Log(string message)
            {
                File.AppendAllText("logs.txt", message + Environment.NewLine);
            }
        }
    
}
