// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Wangkanai.AspNetCore.Responsiveness;
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
        public static IMvcBuilder AddResponsiveness(this IMvcBuilder builder)
        {
            if(builder == null) throw new ArgumentNullException(nameof(builder));

            return AddResponsiveness(builder, null);
        }

        public static IMvcBuilder AddResponsiveness(
            this IMvcBuilder builder,
            Action<ResponsivenessOptions> setupAction)            
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            ResponsivenessServices.AddResponsivenessServices(builder.Services, setupAction);
            return builder;
        }
    }
}
