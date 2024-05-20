using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Logging
{
    public class LogEntry
    {
        public Dictionary<string, object> ExtraDataDictionary { get; set; } = new Dictionary<string, object>();

        public LogType Type { get; set; }

        /// <summary>
        /// Gets or sets text message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        public Exception Exception { get; set; }
    }
}
