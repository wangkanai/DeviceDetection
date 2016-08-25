// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;
using Wangkanai.Extensions.Responsiveness;

namespace Wangkanai.AspNetCore.Responsiveness.Devices
{
    public class DefaultDevice : IDevice
    {
        public bool IsDesktop => _deviceType == DeviceType.Desktop;
        public bool IsTablet => _deviceType == DeviceType.Tablet;
        public bool IsMobile => _deviceType == DeviceType.Mobile;
        public bool IsCrawler => _deviceType == DeviceType.Crawler;

        private readonly DeviceType _deviceType;

        public DefaultDevice(DeviceType deviceType)
        {
            _deviceType = deviceType;
        }
    }
}
