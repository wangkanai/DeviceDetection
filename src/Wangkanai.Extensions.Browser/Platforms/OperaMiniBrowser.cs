using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Wangkanai.Extensions.Browser.Platforms
{
    internal class OperaMiniBrowser : DeviceBrowser
    {
        public override bool IsValid(HttpRequest request)
        {
            // opera mini special case
            if (!request.Headers.Any(header => header.Value.Any(value => value.Contains("OperaMini"))))                return false;

            DeviceInfo = DeviceBuilder.Mobile();
            return true;
        }
    }
}