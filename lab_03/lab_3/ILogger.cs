using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    interface ILogger : IDisposable
    {
        void Log(params String[] messages);
    }
}
