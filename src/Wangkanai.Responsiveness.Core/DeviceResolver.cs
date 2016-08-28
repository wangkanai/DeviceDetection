// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Wangkanai.Responsiveness.Abstractions;

namespace Wangkanai.Responsiveness
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