// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection;

namespace Wangkanai.Responsive
{
    public class ResolverManager : DeviceManager
    {
        public ResolverManager(DeviceType resolved, ResponsiveOptions options)
        : base(resolved, options) { }

    }

    public class DeviceManager : IDeviceManager
    {
        private readonly DeviceType _selected;
        private readonly ResponsiveOptions _options;

        public DeviceManager(DeviceType selected, ResponsiveOptions options)
        {
            _selected = selected;
            _options = options;
        }
        public virtual string Device()
        {
            if (_selected == DeviceType.Mobile) return _options.MobileDefault.ToString();
            if (_selected == DeviceType.Tablet) return _options.TabletDefault.ToString();
            if (_selected == DeviceType.Desktop) return _options.DesktopDefault.ToString();

            return string.Empty;
        }
    }
}
