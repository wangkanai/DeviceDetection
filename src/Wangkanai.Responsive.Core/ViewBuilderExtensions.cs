// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.


using System;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Wangkanai.Detection;
using Wangkanai.Responsive;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ViewBuilderExtensions
    {
        public static IResponsiveBuilder AddViewLocation(this IResponsiveBuilder builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            return AddViewLocation(builder, ResponsiveViewLocationExpanderFormat.Suffix);
        }

        public static IResponsiveBuilder AddViewLocation(
            this IResponsiveBuilder builder,
            ResponsiveViewLocationExpanderFormat format)
        {
            //Action<ResponsiveViewOptions> viewOptions = options => options.Format = format;
            //builder.Services.Configure(viewOptions);
            //builder.Services.TryAddTransient<ResponsiveViewLocationExpander>();

            builder.Services.Configure<RazorViewEngineOptions>(
                options =>
                {
                    options.ViewLocationExpanders.Add(new ResponsiveViewLocationExpander(format));
                    //builder.Services.BuildServiceProvider().GetService<ResponsiveViewLocationExpander>());
                });

            return builder;
        }
    }
}
