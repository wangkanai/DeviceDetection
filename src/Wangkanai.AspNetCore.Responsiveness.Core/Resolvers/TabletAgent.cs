// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Http;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class TabletAgent : IUserAgent
    {
        public string[] Keywords { get; } = new string[]
        {
            "ipad", "playbook", "hp-tablet", "kindle"
        };

        public IDevice CreateDevice(IDeviceManager _manager)
        {
            return _manager.CreateTabletDevice();
        }

        public bool Validate(HttpContext context)
        {
            // not yet implemented
            return false;
        }
    }
}