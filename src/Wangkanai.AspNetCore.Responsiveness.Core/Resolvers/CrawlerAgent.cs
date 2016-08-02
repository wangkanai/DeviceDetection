// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class CrawlerAgent : IUserAgent
    {
        public string[] Keywords { get; } = new string[]
        {

        };

        public KeywordType Type { get; } = KeywordType.Keywords;

        public IDevice CreateDevice(IDeviceManager _manager)
        {
            throw new NotImplementedException();
        }

        public bool Validate(string agent)
        {
            throw new NotImplementedException();
        }
    }
}