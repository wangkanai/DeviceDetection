# ASP.NET Responsiveness

ASP.NET Core client responsiveness middleware for routing base upon request client device detection to specific view.
Being to target difference client devices with seperation of concern is crucial, due to you can mininize what is sent to the client directly from the service to only what is needed and nothing more. This increase performance and lower bandwidth usage.

[![Build status](https://ci.appveyor.com/api/projects/status/nkka5uy27pje40ra/branch/master?svg=true)](https://ci.appveyor.com/project/wangkanai/responsiveness/branch/master)

### Installation

```console
PM> install-package Wangkanai.AspNetCore.Responsiveness -pre
```
### Setup and configure
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add framework services.
    services.AddMvc();
    services.AddResponsiveness();
}
```
