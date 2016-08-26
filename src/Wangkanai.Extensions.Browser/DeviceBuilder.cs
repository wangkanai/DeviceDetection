// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

namespace Wangkanai.Extensions.Browser
{
    public class DeviceBuilder
    {
        public static DeviceInfo CreateDesktop() => new DeviceInfo(DeviceTypes.Desktop);
        public static DeviceInfo CreateTablet() => new DeviceInfo(DeviceTypes.Tablet);
        public static DeviceInfo CreateMobile() => new DeviceInfo(DeviceTypes.Mobile);                        
    }
}