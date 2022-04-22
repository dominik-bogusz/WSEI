using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void Log(params string[] messages)
        {
            foreach (ILogger logger in loggers)
            {
                logger.Log(messages);
            }
        }

        public void Dispose()
        {
            foreach (ILogger logger in loggers)
            {
                logger.Dispose();
            }
        }
    }
}
