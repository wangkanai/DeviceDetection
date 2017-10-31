using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Wangkanai.Responsive.Test.Core
{
    public class ResponsiveBuilderTests
    {
        [Fact]
        public void Ctor_Services_ReturnsExpected()
        {
            var serviceCollection = new ServiceCollection();
            var builder = new ResponsiveBuilder(serviceCollection);

            Assert.Same(serviceCollection, builder.Services);
        }

        [Fact]
        public void Ctor_Null_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ResponsiveBuilder(null));
        }

        [Fact]
        public void Services_ReturnsExpected()
        {
            var serviceCollection = new ServiceCollection();
            var builder = serviceCollection.AddResponsive();

            Assert.NotNull(builder.Services);
            Assert.NotEmpty(builder.Services);
        }
    }
}
