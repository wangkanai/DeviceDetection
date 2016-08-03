// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Devices
{
    public class DefaultDeviceManager : IDeviceManager
    {
        public IDevice CreateDesktopDevice()
            => new DefaultDevice(DeviceType.Desktop);

        public IDevice CreateTabletDevice()
            => new DefaultDevice(DeviceType.Tablet);

        public IDevice CreateMobileDevice()
            => new DefaultDevice(DeviceType.Mobile);

        public IDevice CreateCrawlerDevice()
            => new DefaultDevice(DeviceType.Crawler);

        public IDevice CreateOtherDevice(string code)
            => new DefaultDevice(DeviceType.Other);
    }
}