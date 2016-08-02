// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.AspNetCore.Responsiveness.Core.Abstractions;

namespace Wangkanai.AspNetCore.Responsiveness.Core.Builder
{
    public class ResponsivenessBuilder: IResponsivenessBuilder
    {
        private readonly IServiceCollection _serivces;
        public ResponsivenessBuilder(IServiceCollection services)
        {
            _serivces = services;
        }
    }
}
