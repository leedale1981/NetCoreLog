using NetCoreLog.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreLog.FileSystem
{
    public class FileSystemLogger : IFileSystemLogger
    {
        public string Path { get; set; }


        public FileSystemLogger()
        {
        }

        public void Log(DateTime timeStamp, string message)
        {
            using (FileStream stream = File.OpenWrite(
                this.Path + "\\Logs\\" + timeStamp.DayOfWeek.ToString().Replace(":","") + "_LOG.txt"))
            { 
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(timeStamp.ToUniversalTime().ToString() + " - " + message);
                    writer.Flush();
                }
            }
        }

        public string ReadAll()
        {
            throw new NotImplementedException();
        }

        public string ReadLastEntry()
        {
            throw new NotImplementedException();
        }
    }
}
