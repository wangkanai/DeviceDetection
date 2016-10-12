using System;
using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.Responsive
{
    public class ResponsiveBuilder : IResponsiveBuilder
    {
        public IServiceCollection Services { get; }
        public ResponsiveBuilder(IServiceCollection services)
        {
            if( services == null) throw new ArgumentNullException(nameof(services));

            Services = services;
        }
    }
}