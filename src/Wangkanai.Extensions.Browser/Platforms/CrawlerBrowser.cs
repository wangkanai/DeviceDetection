using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Wangkanai.Extensions.Browser.Platforms
{
    internal class CrawlerBrowser : DeviceBrowser
    {
        private readonly string[] _keywords = {
            "bot","slurp", "spider"
        };

        public override bool IsValid(HttpRequest request)
        {
            var agent = request.Headers["User-Agent"].FirstOrDefault()?.ToLowerInvariant();

            if (agent == null) return false;
            if (!_keywords.Any(keyword => agent.Contains(keyword))) return false;

            DeviceInfo = DeviceBuilder.Crawler();
            return true;            
        }
    }
}