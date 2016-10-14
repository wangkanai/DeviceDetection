using Wangkanai.Detection;

namespace Wangkanai.Responsive
{
    public class ResponsiveOptions
    {
        public IDevice DefaultRequestDevice { get; set; }        
    }

    public class ResponsiveViewOptions
    {
        public ResponsiveViewLocationExpanderFormat Format { get; set; } = ResponsiveViewLocationExpanderFormat.Suffix;
    }
}