// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

namespace Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices
{
    public interface IDevice
    {
        bool IsMobile { get; }
        bool IsTablet { get; }
        bool IsDesktop { get; }
        bool IsCrawler { get; }
    }
}
