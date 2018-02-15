// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection;

namespace Wangkanai.Responsive
{
    public class ResolverManager
    {
        private readonly DeviceType _resolved;
        private readonly ResponsiveOptions _options;

        public ResolverManager(DeviceType resolved, ResponsiveOptions options)
        {
            _resolved = resolved;
            _options = options;
        }

        public string Device()
        {
            if (_resolved == DeviceType.Mobile) return _options.MobileDefault.ToString();
            if (_resolved == DeviceType.Tablet) return _options.TabletDefault.ToString();
            if (_resolved == DeviceType.Desktop) return _options.DesktopDefault.ToString();

            return string.Empty;
        }
    }
}
