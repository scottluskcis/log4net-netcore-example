# Using log4net in .NET Core Example

## Overview

Example using log4net in .NET Core Console Application. See links below for examples used to put together this example. This
example also illustrates using Dependency Injection so that this can be ported over to other .NET Core projects such as .NET 
Core Web Applications. 

Primarily this example takes advantage of these NuGet packages

```powershell
dotnet add package Microsoft.Extensions.Logging
dotnet add package Microsoft.Extensions.Logging.Log4Net.AspNetCore
dotnet add package Microsoft.Extensions.DependencyInjection
```

The output of the log file is placed in `Log4NetInCoreExampleLogFile.log` in the bin folder when you run the application

## Links

* [Microsoft.Extensions.Logging.Log4Net.AspNetCore](https://github.com/huorswords/Microsoft.Extensions.Logging.Log4Net.AspNetCore)
* [Microsoft.Extensions.Logging.Log4Net.AspNetCore - CONFIG](https://github.com/huorswords/Microsoft.Extensions.Logging.Log4Net.AspNetCore/blob/develop/doc/CONFIG.md)
* [How to use Log4Net with ASP.NET Core for logging](https://dotnetthoughts.net/how-to-use-log4net-with-aspnetcore-for-logging/)
* [Logging in .Net Core Console Apps](https://www.blinkingcaret.com/2018/02/14/net-core-console-logging/)
