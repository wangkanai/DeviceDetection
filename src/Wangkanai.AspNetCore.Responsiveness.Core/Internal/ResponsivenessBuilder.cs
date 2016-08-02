// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;
using Wangkanai.AspNetCore.Responsiveness.DependencyInjection;

namespace Wangkanai.AspNetCore.Responsiveness.Internal
{
    /// <summary>
    /// Allows fine grained configuration of Responsiveness services.
    /// </summary>
    public class ResponsivenessBuilder : IResponsivenessBuilder
    {
        public IServiceCollection Services { get; }
        //public ResponsivenessManager ResponsivenessManager { get; }

        /// <summary>
        /// Initializes a new <see cref="ResponsivenessBuilder"/> instance.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/></param>
        public ResponsivenessBuilder(
            IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            Services = services;
        }
    }
}
