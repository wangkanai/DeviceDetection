
using System;
using Microsoft.AspNetCore.Mvc.Razor;
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
            builder.Services.Configure<RazorViewEngineOptions>(
                options =>
                {
                    options.ViewLocationExpanders.Add(new ResponsiveViewLocationExpander(format));
                });

            return builder;
        }
    }
}
