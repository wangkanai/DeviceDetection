// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Http;
using Wangkanai.Detection;
using Wangkanai.Responsive.Abstractions;

namespace Wangkanai.Responsive
{
    public class ResponsiveResolver : IResponsiveResolver
    {
        private readonly IDeviceResolver _deviceResolver;

        public IDevice Device => _deviceResolver.Device;

        public ResponsiveResolver(IDeviceResolver deviceResolver)
        {
            if (deviceResolver == null) throw new ArgumentNullException(nameof(deviceResolver));

            _deviceResolver = deviceResolver;
        }
    }
}