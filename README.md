# ASP.NET Core Responsiveness

AppVeyor: [![Build status](https://ci.appveyor.com/api/projects/status/nkka5uy27pje40ra/branch/master?svg=true)](https://ci.appveyor.com/project/wangkanai/responsiveness/branch/master)

ASP.NET Core Responsiveness middleware for routing base upon request client device detection to specific view.
Being to target difference client devices with seperation of concern is crucial, due to you can mininize what is sent to the client directly from the service to only what is needed and nothing more. This increase performance and lower bandwidth usage.

### Installation - [NuGet](https://www.nuget.org/packages/Wangkanai.AspNetCore.Responsiveness/)

```powershell
PM> install-package Wangkanai.AspNetCore.Responsiveness -pre
```
### Setup and configure
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddResponsiveness();
    // Add framework services.
    services.AddMvc();    
}
```
```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
{
    app.UseResponsiveness();
    app.UseMvc(routes =>
    {
        routes.MapRoute(
            name: "default",
            template: "{controller=Home}/{action=Index}/{id?}");
    });
}
```
