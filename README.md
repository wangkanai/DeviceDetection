# ASP.NET Core Responsive

[![Build status](https://ci.appveyor.com/api/projects/status/cbx1xvcln7xaccs5?svg=true)](https://ci.appveyor.com/project/wangkanai/responsive) 
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Wangkanai.Responsive.svg?maxAge=2592000)](https://www.nuget.org/packages/Wangkanai.Responsive/) **Pre-Release** (Still in development)

![ASP.NET Core Responsive](https://raw.githubusercontent.com/wangkanai/Responsive/dev/asset/asp.net-core-responsive.png)

ASP.NET Core Responsive middleware for routing base upon request client device detection to specific view.
Being to target difference client devices with seperation of concern is crucial, due to you can mininize what is sent to the client directly from the service to only what is needed and nothing more. This increase performance and lower bandwidth usage.

### Installation - [NuGet](https://www.nuget.org/packages/Wangkanai.Responsive/)

```powershell
PM> install-package Wangkanai.Responsive -pre
```
### Implement a strategy to select the device for each request
#### Configuring Responsive
Responsive is configured in the `ConfigureServices` method:
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add responsive services.
    services.AddResponsive()
        .AddViewSuffix()
        .AddViewSubfolder();

    // Add framework services.
    services.AddMvc();  
}
```
* `AddResponsive` Adds the Responsive services to the services container.
* `AddViewSuffix` Adds support for device view files  to `Suffix`. In this sample view Responsive is based on the view file suffix. 

  Ex *views/[controller]/[action]/index.mobile.cshtml*
* `AddViewSubfolder` Adds support for device view files to `Subfolder`. In this sample view Responsive is based on the view file subfolder. 

  Ex *views/[controller]/[action]/mobile/index.cshtml*

#### Responsive Middleware

The current device on a request is set in the Responsive middleware. The Responsive middleware is enabled in the `Configure` method of *Startup.cs* file.
```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
{
    app.UseResponsive(new RequestResponsiveOptions{
        SupportedDevices = new[]
        {
            DeviceType.Desktop,
            DeviceType.Mobile
        }        
    });

    app.UseMvc(routes =>
    {
        routes.MapRoute(
            name: "default",
            template: "{controller=Home}/{action=Index}/{id?}");
    });
}
```

#### Related projects

* [ASP.NET Core Detection (Wangkanai.Detection)](https://github.com/wangkanai/Detection)

