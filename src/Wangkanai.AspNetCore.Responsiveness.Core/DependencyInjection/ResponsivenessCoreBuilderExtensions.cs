// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.AspNetCore.Responsiveness.DependencyInjection
{
    ///// <summary>
    ///// Extensions for configuring Responsiveness using an <see cref="IResponsivenessBuilder"/>
    ///// </summary>
    //public static class ResponsivenessCoreBuilderExtensions
    //{
    //    /// <summary>
    //    /// Registers an action to configure <see cref="ViewResponsivenessOptions"/>
    //    /// </summary>
    //    /// <param name="builder">The <see cref="IResponsivenessBuilder"/>.</param>
    //    /// <param name="options">An <see cref="Action{ViewResponsivenessOptions}"/></param>
    //    /// <returns>The <see cref="IResponsivenessBuilder"/>.</returns>
    //    public static IResponsivenessBuilder AddResponsivenessOptions(
    //        this IResponsivenessBuilder builder,
    //        Action<ViewResponsivenessOptions> options)
    //    {
    //        if(builder == null) throw new ArgumentNullException(nameof(builder));
    //        if(options == null) throw new ArgumentNullException(nameof(options));

    //        builder.Services.Configure<ViewResponsivenessOptions>(options);
    //        return builder;
    //    }
    //}
}