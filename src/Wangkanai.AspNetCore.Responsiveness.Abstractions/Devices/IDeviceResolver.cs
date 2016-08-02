using Microsoft.AspNetCore.Http;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Core.Abstractions
{
    public interface IDeviceResolver
    {
        IDevice Resolve(HttpContext context);
    }
}