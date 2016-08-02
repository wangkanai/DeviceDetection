using Microsoft.AspNetCore.Http;

namespace Wangkanai.AspNetCore.Responsiveness.Core.Abstractions
{
    public interface IDeviceResolver
    {
        IDevice Resolve(HttpContext context);
    }
}