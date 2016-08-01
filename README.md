# DeviceDetection
ASP.NET Core middleware for routing to specific area base client request device

### Installation

```console
PM> install-package Wangkanai.AspNetCore.DeviceDetection -pre
```
### Setup
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add framework services.
    services.AddMvc();
    services.AddDeviceDetection();
}
```