using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wangkanai.Extensions.Browser
{
    internal abstract class DeviceBrowser: IDeviceBrowser
    {
        
    }

    internal interface IDeviceBrowser
    {
        
    }
    internal class DesktopBrowser:DeviceBrowser
    {
    }

    internal class TabletBrowser:DeviceBrowser
    {
        
    }

    internal class MobileBrowser:DeviceBrowser
    {
        
    }
    
}
