// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;
using Wangkanai.AspNetCore.Responsiveness;
using System.Linq;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    public class AgentResolver : IDeviceResolver
    {
        private readonly IOptions<DeviceOptions> _options;
        private readonly IDeviceManager _manager;

        public AgentResolver(IOptions<DeviceOptions> options, IDeviceManager manager)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if(manager == null) throw  new ArgumentNullException(nameof(manager));

            _options = options;
            _manager = manager;
        }

        public IDevice Resolve(HttpContext context)
        {
            var agent = context.Request.Headers["User-Agent"]
                .FirstOrDefault()
                ?.ToLowerInvariant();

            foreach (var interpreter in PopulateUserAgents())
            {
                // How to interpret??
            }

            return _manager.CreateDesktopDevice();
        }

        private IList<IUserAgent> PopulateUserAgents()
        {
            return new List<IUserAgent>
            {
                new MobilePrefixes(),
                new MobileKeywords(),
                new TabletKeywords(),
                new CrawlerKeywords()
            };
        }
    }
}
