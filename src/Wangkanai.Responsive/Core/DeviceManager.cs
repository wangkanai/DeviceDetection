// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection;

namespace Wangkanai.Responsive
{
    public abstract class DeviceManager
    {
        protected readonly ResponsiveOptions _options;

        public DeviceManager(ResponsiveOptions options)
        {
            _options = options;
        }
        protected DeviceType Override(DeviceType type)
        {
            if (type == DeviceType.Mobile) return _options.MobileDefault;
            if (type == DeviceType.Tablet) return _options.TabletDefault;
            if (type == DeviceType.Desktop) return _options.DesktopDefault;

            return type;
        }
    }
}
