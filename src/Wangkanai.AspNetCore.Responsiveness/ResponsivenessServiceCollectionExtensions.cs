// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.AspNetCore.Responsiveness.DependencyInjection;
using Wangkanai.AspNetCore.Responsiveness.Internal;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// ASP.NET Core middleware for routing to specific area base client request device
    /// Extension method for setting up Universal in an <see cref="IServiceCollection" />
    /// </summary>
    public static class ResponsivenessServiceCollectionExtensions
    {
        public static IResponsivenessBuilder AddResponsiveness(
            this IServiceCollection services)
        {
            if(services == null) throw new ArgumentNullException(nameof(services));

            var builder = services.AddResponsivenessCore();

            return new ResponsivenessBuilder(builder.Services);
        }

        public static IResponsivenessBuilder AddResponsiveness<T>(
            this IServiceCollection services)
            where T : class
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var builder = services.AddResponsivenessCore();

            return new ResponsivenessBuilder(builder.Services);
        }
    }
}
