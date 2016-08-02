// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using System;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal interface IUserAgent
    {
        string[] Keywords { get; }
        KeywordType Type { get; }
        IDevice CreateDevice(IDeviceManager _manager);
        bool Validate(string agent);
    }
}