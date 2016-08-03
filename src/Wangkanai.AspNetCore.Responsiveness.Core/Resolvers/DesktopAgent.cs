using System.Linq;
using Microsoft.AspNetCore.Http;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class DesktopAgent : IUserAgent
    {
        private string[] Keywords { get; } = new string[] {};
        public IDevice CreateDevice(IDeviceManager _manager)
        {
            return _manager.CreateDesktopDevice();
        }
        public bool Validate(HttpContext context)
        {
            var agent = context.Request.Headers["User-Agent"].FirstOrDefault()?.ToLowerInvariant();

            if (agent == null) return false;

            //waiting for logic
            return false;
        }
    }
}