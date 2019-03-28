using System;
using System.IO;
using Microsoft.Extensions.Configuration;
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
            // NOTE: there are two approaches you can use for configuration of log4net
            // 1. use the log4net.config XML file
            // 2. use appsettings.json with the ConfigurationBuilder

            // add configuration from appsettings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var loggingOptions = config.GetSection("Log4NetCore")
                .Get<Log4NetProviderOptions>();

            // add logging
            services.AddLogging(configure => configure.AddLog4Net(loggingOptions));

            // dependency injection for test classes
            services.AddTransient<IClassThatLogs, ClassUsingILogger>();
        }
    }
}
