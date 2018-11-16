using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.Detection;

namespace Wangkanai.Responsive
{
    public class CookieManager : DeviceManager
    {
        private const string ResponsiveContextKey = "Responsive";
        private readonly HttpContext _context;

        public CookieManager(HttpContext context, ResponsiveOptions options)
            : base(DeviceType.Desktop, options)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            _context = context;
        }

        public override string Device()
        {
            return string.Empty;
        }

        public DeviceType Get()
        {
            var value = _context.Request.Cookies[ResponsiveContextKey];
            DeviceType result;
            Console.Write(value);
            Enum.TryParse<DeviceType>(value, out result);
            return result;
        }
        public void Set(DeviceType value)
        {
            var option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(60);

            _context.Response.Cookies.Append(ResponsiveContextKey,value.ToString(), option);
        }

        public void Remove()
        {
            _context.Response.Cookies.Delete(ResponsiveContextKey);
        }
    }
}
