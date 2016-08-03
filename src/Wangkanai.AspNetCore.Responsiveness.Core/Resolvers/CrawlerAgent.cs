// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Http;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class CrawlerAgent : IUserAgent
    {
        private string[] Keywords { get; } = new string[]
        {

        };        

        public IDevice CreateDevice(IDeviceManager _manager)
        {
            return _manager.CreateCrawlerDevice();
        }

        public bool Validate(HttpContext context)
        {
            //not yet implemented
            return false;
        }
    }
}