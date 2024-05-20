using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Logging
{
    public  interface ILogHelper
    {
        void Log(LogEntry entry);
        void Log(LogType type, Exception ex, string message);
    }
}
