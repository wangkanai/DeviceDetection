// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using Wangkanai.AspNetCore.Responsiveness.DependencyInjection;

namespace Wangkanai.AspNetCore.Responsiveness.Internal
{
    public class ResponsivenessCoreBuilder : IResponsivenessCoreBuilder
    {
        public IServiceCollection Services { get; }

        public ResponsivenessCoreBuilder(IServiceCollection services)
        {
            Services = services;
        }
    }
}