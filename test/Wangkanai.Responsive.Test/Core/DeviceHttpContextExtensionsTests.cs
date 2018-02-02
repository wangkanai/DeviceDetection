// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using System;
using Wangkanai.Detection;
using Xunit;


namespace Wangkanai.Responsive.Test.Core
{
    public class DeviceHttpContextExtensionsTests
    {
        [Fact]
        public void SetDevice_HttpContext_UserPerference_ReturnsExpected()
        {
            var context = new DefaultHttpContext();
            var preference = new UserPerference();
            string responsiveContextKey = "Responsive"; // May be we can make this constant public for testing purposes.

            context.SetDevice(preference);

            Assert.True(context.Items.ContainsKey(responsiveContextKey));
            Assert.Same(preference, context.Items[responsiveContextKey]);
        }

        [Fact]
        public void SetDevice_Null_UserPerference_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ((HttpContext)null).SetDevice(new UserPerference()));
        }

        [Fact]
        public void SetDevice_HttpContext_Null_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new DefaultHttpContext().SetDevice(null));
        }

        [Fact]
        public void GetDevice_HttpContext_ReturnsExpected()
        {
            string device = DeviceType.Tablet.ToString();
            var preference = new UserPerference() { Device = device };
            var context = new DefaultHttpContext();
            context.SetDevice(preference);

            Assert.Same(preference, context.GetDevice());
            Assert.Same(preference.Device, context.GetDevice().Device);
        }

        [Fact]
        public void SetDevice_Null_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ((HttpContext)null).GetDevice());
        }

        [Fact]
        public void SetDevice_InvalidContext_ReturnsNull()
        {
            var context = new DefaultHttpContext();

            // If the device is not found it just returns NULL. May be we can throw some exception here.
            Assert.Null(context.GetDevice());
        }
    }
}
