// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using System;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal interface IUserAgent
    {
        IDevice CreateDevice(IDeviceManager _manager);
        bool Validate(HttpContext context);
    }
}