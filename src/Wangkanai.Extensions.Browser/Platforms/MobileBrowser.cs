// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Wangkanai.Extensions.Browser.Platforms
{
    internal class MobileBrowser : DeviceBrowser
    {
        private readonly string[] _keywords = {
            "blackberry", "webos", "ipod", "lge vx", "midp", "maemo", "mmp", "mobile",
            "netfront", "hiptop", "nintendo DS", "novarra", "openweb", "opera mobi",
            "opera mini", "palm", "psp", "phone", "smartphone", "symbian", "up.browser",
            "up.link", "wap", "windows ce"
        };

        // reference 4 chare from http://www.webcab.de/wapua.htm
        private readonly string[] _prefixes = {
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

        public override bool IsValid(HttpRequest request)
        {
            var agent = request.Headers["User-Agent"].FirstOrDefault()?.ToLowerInvariant();

            // user agent keyword detection
            if (agent != null && _keywords.Any(keyword => agent.Contains(keyword)))
                return true;
            // user agent prefix detection
            if (agent?.Length >= 4 && _prefixes.Any(prefix => agent.StartsWith(prefix)))
                return true;
            // user agent prof detection
            if (request.Headers.ContainsKey("x-wap-profile") || request.Headers.ContainsKey("Profile"))
                return true;
            // accept-header base detection
            if (request.Headers["Accept"].Any(accept => accept.ToLowerInvariant() == "wap"))
                return true;
            // opera mini special case
            if (request.Headers.Any(header => header.Value.Any(value => value.Contains("OperaMini"))))
                return true;

            return false;
        }
    }
}