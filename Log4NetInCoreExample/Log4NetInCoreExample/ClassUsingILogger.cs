using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Log4NetInCoreExample
{
    public class ClassUsingILogger : IClassThatLogs
    {
        private readonly ILogger _logger;

        public ClassUsingILogger(ILogger<ClassUsingILogger> logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.LogInformation($"Hello from the {nameof(ClassUsingILogger)} class");
        }
    }
}
