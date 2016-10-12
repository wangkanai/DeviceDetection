
using Wangkanai.Detection;
using Wangkanai.Responsive;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ViewBuilderExtensions
    {
        public static IResponsiveBuilder AddViewLocation(this IResponsiveBuilder builder)
        {
            return builder;
        }
    }
}
