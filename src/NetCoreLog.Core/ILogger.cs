using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreLog.Core
{
    public interface ILogger
    {
        void Log(DateTime timeStamp, string message);
        string ReadAll();
        string ReadLastEntry();
    }
}
