// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

namespace Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices
{
    public interface IDeviceManager
    {
        IDevice CreateDesktopDevice();
        IDevice CreateTabletDevice();
        IDevice CreateMobileDevice();
        IDevice CreateCrawkerDevice();
        IDevice CreateOtherDevice(string code);
    }
}