// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System.Linq;
using Microsoft.AspNetCore.Http;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class MobileAgent : IUserAgent
    {
        private string[] Keywords { get; } = new string[]
        {
            "blackberry", "webos", "ipod", "lge vx", "midp", "maemo", "mmp", "mobile",
            "netfront", "hiptop", "nintendo DS", "novarra", "openweb", "opera mobi",
            "opera mini", "palm", "psp", "phone", "smartphone", "symbian", "up.browser",
            "up.link", "wap", "windows ce"
        };

        // reference 4 chare from http://www.webcab.de/wapua.htm
        private string[] Prefixes { get; } = new string[]
        {
            "w3c ", "w3c-", "acs-", "alav", "alca", "amoi", "audi", "avan", "benq",
            "bird", "blac", "blaz", "brew", "cell", "cldc", "cmd-", "dang", "doco",
            "eric", "hipt", "htc_", "inno", "ipaq", "ipod", "jigs", "kddi", "keji",
            "leno", "lg-c", "lg-d", "lg-g", "lge-", "lg/u", "maui", "maxo", "midp",
            "mits", "mmef", "mobi", "mot-", "moto", "mwbp", "nec-", "newt", "noki",
            "palm", "pana", "pant", "phil", "play", "port", "prox", "qwap", "sage",
            "sams", "sany", "sch-", "sec-", "send", "seri", "sgh-", "shar", "sie-",
            "siem", "smal", "smar", "sony", "sph-", "symb", "t-mo", "teli", "tim-",
            "tosh", "tsm-", "upg1", "upsi", "vk-v", "voda", "wap-", "wapa", "wapi",
            "wapp", "wapr", "webc", "winw", "winw", "xda ", "xda-"
        };

        public IDevice CreateDevice(IDeviceManager manager)
        {
            return manager.CreateMobileDevice();
        }

        public bool Validate(HttpContext context)
        {
            var agent = context.Request.Headers["User-Agent"].FirstOrDefault()?.ToLowerInvariant();

            // user agent prefix detection
            if (agent != null && agent.Length >= 4 && Prefixes.Any(prefix => agent.StartsWith(prefix)))
                return true;
            // user agent keyword detection
            if (agent != null && Keywords.Any(keyword => agent.Contains(keyword)))
                return true;
            // user agent prof detection
            if (context.Request.Headers.ContainsKey("x-wap-profile") ||
                context.Request.Headers.ContainsKey("Profile"))
                return true;
            // accept-header base detection
            if (context.Request.Headers["Accept"].Any(accept => accept.ToLowerInvariant() == "wap"))
                return true;
            // opera mini special case
            if (context.Request.Headers.Any(header => header.Value.Any(value => value.Contains("OperaMini"))))
                return true;

            return false;
        }
    }
}