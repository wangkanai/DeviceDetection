using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.AspNetCore.Responsiveness.Core.Internal
{
    public class ResponsivenessBuilder : IResponsivenessBuilder
    {
        public IServiceCollection Services { get; }
        //public ResponsivenessManager ResponsivenessManager { get; }

        public ResponsivenessBuilder(
            IServiceCollection services)
        {
            if(services == null ) throw new ArgumentNullException(nameof(services));

            Services = services;
        }
    }
}
