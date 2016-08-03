// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;
using Wangkanai.AspNetCore.Responsiveness.Resolvers;
using Xunit;

namespace Wangkanai.AspNetCore.Responsiveness.Core.Test.Resolvers
{
    public class AgentResolverTest
    {
        [Fact]
        public void Mobile_device_detection()
        {
            // Arrange
            var context = new DefaultHttpContext();
            var header = "User-Agent";
            var headerValue = "Nexus 5 Build/KOT49H)";
            context.Request.Headers.Add(header, new[] {headerValue});

            var manager = new Mock<IDeviceManager>();
            var options = new Mock<IOptions<DeviceOptions>>();
            var resolver = new AgentResolver(options.Object, manager.Object);
            var expected = new Mock<IDevice>();
            expected.Setup(x => x.IsMobile).Returns(true);
            
            // Act
            var device = resolver.Resolve(context);


            // Assert
            Assert.Equal(expected.Object.IsMobile, device.IsMobile);
        }
    }
}
