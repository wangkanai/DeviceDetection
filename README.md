# ASP.NET Core Responsiveness

[![Build status](https://ci.appveyor.com/api/projects/status/nkka5uy27pje40ra/branch/master?svg=true)](https://ci.appveyor.com/project/wangkanai/responsiveness/branch/master) [![NuGet Pre Release](https://img.shields.io/nuget/vpre/Wangkanai.Responsiveness.svg?maxAge=2592000)](https://www.nuget.org/packages/Wangkanai.Responsiveness/) **Pre-Release** (Still in development)

![ASP.NET Core Responsiveness](https://raw.githubusercontent.com/wangkanai/Responsiveness/master/asset/asp.net-core-responsiveness.png)

ASP.NET Core Responsiveness middleware for routing base upon request client device detection to specific view.
Being to target difference client devices with seperation of concern is crucial, due to you can mininize what is sent to the client directly from the service to only what is needed and nothing more. This increase performance and lower bandwidth usage.

### Installation - [NuGet](https://www.nuget.org/packages/Wangkanai.Responsiveness/)

```powershell
PM> install-package Wangkanai.Responsiveness -pre
```
### Implement a strategy to select the device for each request
#### Configuring Responsiveness
Responsiveness is configured in the `ConfigureServices` method:
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddResponsiveness();
    // Add framework services.
    services.AddMvc()
        .AddViewResponsiveness();    
}
```
* `AddResponsiveness` Adds the responsiveness services to the services container.
* `AddViewResponsiveness` Adds support for device view files. In this sample view responsiveness is based on the view file suffix. For example "mobile" in the *index.mobile.cshtml* file.

#### Responsiveness Middleware

The current device on a request is set in the responsiveness middleware. The responsiveness middleware is enabled in the `Configure` method of *Startup.cs* file.
```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
{
    app.UseResponsiveness(new RequestResponsivenessOptions{
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

* [ASP.NET Core Browser (Wangkanai.Browser)](https://github.com/wangkanai/Browser)

