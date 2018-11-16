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

        private string Get(string key)
        {
            return _context.Request.Cookies[key];
        }
        private void Set(string key, string value, int? expire)
        {
            var option = new CookieOptions();
            if (expire.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expire.Value);
            else
                option.Expires = DateTime.Now.AddMinutes(10);
            _context.Response.Cookies.Append(key, value, option);
        }

        private void Remove(string key)
        {
            _context.Response.Cookies.Delete(key);
        }
    }
}
