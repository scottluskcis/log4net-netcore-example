using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Log4NetInCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // configure services and build out service provider
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            // use dependency injection to retrieve class and do work that will log something
            var myTestClass = serviceProvider.GetService<IClassThatLogs>();
            myTestClass.DoWork();

            Console.WriteLine("check your log file for log output");

            Console.WriteLine("Press Enter to quit...");
            Console.ReadKey();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // configure logging
            services
                .AddLogging(configure => configure.AddLog4Net())
                .Configure<LoggerFilterOptions>(options => options.MinLevel = LogLevel.Debug);

            // dependency injection for test classes
            services.AddTransient<IClassThatLogs, ClassUsingILogger>();
        }
    }
}
