// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Wangkanai.Responsive;
using Wangkanai.Responsive.Abstractions;
using Wangkanai.Detection;
using Wangkanai.Detection.Builder;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// ASP.NET Core middleware for routing to specific area base client request device
    /// Extension method for setting up Universal in an <see cref="IServiceCollection" />
    /// </summary>
    public static class ResponsiveServiceCollectionExtensions
    {
        /// <summary>
        /// Adds services required for application Responsive.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
        /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        public static IResponsiveBuilder AddResponsive(
            this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDetection().AddDevice();            
            services.TryAddTransient(typeof(IResponsiveResolver), typeof(ResponsiveResolver));

            return new ResponsiveBuilder(services);
        }
    }
}
