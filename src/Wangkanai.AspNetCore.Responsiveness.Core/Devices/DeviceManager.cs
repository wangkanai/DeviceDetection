// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;
using Wangkanai.Extensions.Browser;

namespace Wangkanai.AspNetCore.Responsiveness.Devices
{
    public class DeviceManager : IDeviceManager
    {
        public IDevice CreateDesktopDevice()
            => new DefaultDevice(DeviceTypes.Desktop);

        public IDevice CreateTabletDevice()
            => new DefaultDevice(DeviceTypes.Tablet);

        public IDevice CreateMobileDevice()
            => new DefaultDevice(DeviceTypes.Mobile);

        public IDevice CreateCrawlerDevice()
            => new DefaultDevice(DeviceTypes.Crawler);

        public IDevice CreateOtherDevice(string code)
            => new DefaultDevice(DeviceTypes.Other);
    }
}