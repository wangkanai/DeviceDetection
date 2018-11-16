using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.Detection;
using Xunit;

namespace Wangkanai.Responsive.Test
{
    public class CookieManagerTest : ResponsiveTestAbstract
    {
        [Fact]
        public void SetAble()
        {
            var service = CreateService("test");
            var manager = new CookieManager(service.Context, null);

            manager.Set(DeviceType.Mobile);

            Assert.Equal(DeviceType.Mobile, manager.Get());
        }
    }
}
