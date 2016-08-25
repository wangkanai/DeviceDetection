// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;
using Wangkanai.Extensions.Browser;

namespace Wangkanai.AspNetCore.Responsiveness.Devices
{
    public class DefaultDevice : IDevice
    {
        public bool IsDesktop => _deviceTypes == DeviceTypes.Desktop;
        public bool IsTablet => _deviceTypes == DeviceTypes.Tablet;
        public bool IsMobile => _deviceTypes == DeviceTypes.Mobile;
        public bool IsCrawler => _deviceTypes == DeviceTypes.Crawler;

        private readonly DeviceTypes _deviceTypes;

        public DefaultDevice(DeviceTypes deviceTypes)
        {
            _deviceTypes = deviceTypes;
        }
    }
}
