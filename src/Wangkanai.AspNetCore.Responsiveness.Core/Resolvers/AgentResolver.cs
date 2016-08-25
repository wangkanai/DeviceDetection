// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    public class AgentResolver : IDeviceResolver
    {
        private readonly IOptions<DeviceOptions> _options;
        private readonly IDeviceManager _manager;

        public AgentResolver(IOptions<DeviceOptions> options, IDeviceManager manager)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (manager == null) throw new ArgumentNullException(nameof(manager));

            _options = options;
            _manager = manager;
        }
        private IList<IUserAgent> PopulateUserAgents()
        {
            return new List<IUserAgent>
            {
                new DesktopAgent(),
                new TabletAgent(),
                new MobileAgent(),                
                new CrawlerAgent()
            };
        }
        public IDevice Resolve(HttpContext context)
        {
            return Resolve(context, PopulateUserAgents());
        }

        private IDevice Resolve(HttpContext context, IList<IUserAgent> agents)
        {
            foreach (var interpretor in agents)
                if (interpretor.Validate(context))
                    return interpretor.CreateDevice(_manager);

            return _manager.CreateDesktopDevice();
        }
    }
}
