// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class MobileKeywords : IUserAgent
    {
        public string[] Keywords { get; } = new string[]
        {
            "blackberry", "webos", "ipod", "lge vx", "midp", "maemo", "mmp", "mobile",
            "netfront", "hiptop", "nintendo DS", "novarra", "openweb", "opera mobi",
            "opera mini", "palm", "psp", "phone", "smartphone", "symbian", "up.browser",
            "up.link", "wap", "windows ce"
        };
        public KeywordType Type { get; } = KeywordType.Keywords;

        public IDevice CreateDevice(IDeviceManager _manager)
        {
            throw new NotImplementedException();
        }

        public bool Validate(string agent)
        {
            throw new NotImplementedException();
        }
    }
}