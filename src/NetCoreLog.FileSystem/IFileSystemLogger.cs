using NetCoreLog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreLog.FileSystem
{
    public interface IFileSystemLogger : ILogger
    {
        string Path { get; set; }
    }
}
