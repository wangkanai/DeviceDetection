// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Http;
using Wangkanai.Browser;
using Wangkanai.Responsiveness.Abstractions;

namespace Wangkanai.Responsiveness
{
    public class ResponsivenessResolver : IResponsivenessResolver
    {
        private ResponsivenessFactory _factory;
        //public DeviceInfo DeviceInfo { get; private set; }       

        public ResponsivenessResolver(ResponsivenessFactory factory, HttpContext context)
        {
            if(factory == null) throw new ArgumentNullException(nameof(factory));

            _factory = factory;            
            //DeviceInfo = new DeviceResolver(context.Request).DeviceInfo;
        }
    }
}