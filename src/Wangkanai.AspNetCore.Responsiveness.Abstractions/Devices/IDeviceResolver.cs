// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;

namespace Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices
{
    public interface IDeviceResolver
    {
        IDevice Resolve(HttpContext context);
    }
}