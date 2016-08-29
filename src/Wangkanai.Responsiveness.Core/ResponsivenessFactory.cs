﻿// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Wangkanai.Responsiveness.Abstractions;

namespace Wangkanai.Responsiveness
{
    /// <summary>
    /// An <see cref="IResponsivenessFactory"/> that creates instances of <see cref="ResponsivenessFactory"/>
    /// </summary>
    public class ResponsivenessFactory : IResponsivenessFactory
    {        
        private readonly HttpContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;        

        public ResponsivenessFactory(
            HttpContext context, 
            IHostingEnvironment hostingEnvironment)
        {
            if(context == null) throw new ArgumentNullException(nameof(context));            
            if(hostingEnvironment == null) throw new ArgumentNullException(nameof(hostingEnvironment));

            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
    }
}