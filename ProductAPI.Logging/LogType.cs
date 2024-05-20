using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Logging
{
    public enum LogType
    {
        /// <summary>
        /// This is debug information.
        /// </summary>
        Debug,

        /// <summary>
        /// THis is general information.
        /// </summary>
        Info,

        /// <summary>
        /// This is a warning.
        /// </summary>
        Warning,

        /// <summary>
        /// This is an error.
        /// </summary>
        Error
    }
}
