using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.Detection;
using Xunit;

namespace Wangkanai.Responsive.Test.Core
{
    public class ResolverManagerTests
    {
        [Fact]
        public void Ctor_ResolverManager_ResponsiveOptions_Success()
        {
            var options = (Options.Create(new ResponsiveOptions())).Value;
            var desktop = DeviceType.Desktop;
            var manager = new ResolverManager(desktop, options);
        }
        [Fact]
        public void TabletDefault_is_Mobile()
        {
            var desktop = DeviceType.Desktop;
            var tablet = DeviceType.Tablet;
            var mobile = DeviceType.Mobile;

            var options = new ResponsiveOptions(desktop, mobile, mobile);
            Assert.Equal(mobile, options.TabletDefault);
            Assert.NotEqual(tablet, options.TabletDefault);
            Assert.Equal(desktop, options.DesktopDefault);

            var manager = new ResolverManager(tablet, options);
            Assert.Equal(mobile.ToString(), manager.Device());
        }
    }
}
