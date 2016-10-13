using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreLog.Core;

namespace NetCoreLog.DocumentDB
{
    public class DocumentDBLogger : IDocumentDBLogger
    {
        public DocumentDBLogger(string connectionString)
        {

        }

        public void Log(DateTime timeStamp, string message)
        {
            throw new NotImplementedException();
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
