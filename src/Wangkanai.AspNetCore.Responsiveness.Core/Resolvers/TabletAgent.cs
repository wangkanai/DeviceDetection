// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class TabletAgent : IUserAgent
    {
        private string[] Keywords { get; } = new string[]
        {
            "tablet", "ipad", "playbook", "hp-tablet", "kindle"
        };

        public IDevice CreateDevice(IDeviceManager _manager)
        {
            return _manager.CreateTabletDevice();
        }

        public bool Validate(HttpContext context)
        {
            var agent = context.Request.Headers["User-Agent"].FirstOrDefault()?.ToLowerInvariant();

            if (agent == null) return false;            
            if (!Keywords.Any(keyword => agent.Contains(keyword))) return false;
            if (!agent.Contains("ipad") && agent.Contains("mobile")) return false;

            return true;
        }
    }
}