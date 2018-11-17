// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;
using Wangkanai.Detection;

namespace Wangkanai.Responsive
{
    public class ResolverManager : DeviceManager, IDeviceManager
    {
        private readonly DeviceType _resolved;

        public ResolverManager(IDeviceResolver resolver, ResponsiveOptions options)
            : base(options)
        {
            if (resolver == null) throw new ArgumentNullException(nameof(resolver));

            this._resolved = resolver.Device.Type;
        }
        public ResolverManager(DeviceType resolved, ResponsiveOptions options)
            : base(options)
        {
            this._resolved = resolved;
        }

        public DeviceType Device => Override(_resolved);
    }
}
