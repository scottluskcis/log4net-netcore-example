using log4net;

namespace Log4NetInCoreExample
{
    public class ClassThatUsesLogManager : IClassThatLogs
    {
        // traditional way of logging with log4net
        private readonly ILog _logger = LogManager.GetLogger("LogRepository", typeof(ClassThatUsesLogManager));

        public void DoWork()
        {
            _logger.Info($"Information message using {nameof(ILog)} and {nameof(LogManager)} in class {nameof(ClassThatUsesLogManager)}");
        } 
    }
}
