namespace Microsoft.AspNetCore.Http
{
    public static class ResponsiveHttpContextExtensions
    {
        public static ResponsiveExtension Responsive(this HttpContext context)
        {
            return new ResponsiveExtension();
        }
    }

    public class ResponsiveExtension
    {
    }
}
