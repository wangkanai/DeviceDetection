// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Wangkanai.AspNetCore.Responsiveness.Abstractions;

namespace Wangkanai.AspNetCore.Responsiveness
{
    public class DeviceResolver : IDeviceResolver
    {
        private ResponsivenessFactory _factory;
        public DeviceResolver(ResponsivenessFactory factory)
        {
            if(factory == null) throw new ArgumentNullException(nameof(factory));

            _factory = factory;
        }
    }
}