using System;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Wangkanai.Responsiveness
{
    public class ResponsivenessBuilder : IResponsivenessBuilder
    {
        public IServiceCollection Services { get; }
        public ResponsivenessBuilder(IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            Services = services;
        }
    }

    public interface IResponsivenessBuilder
    {
        IServiceCollection Services { get; }
    }
}
