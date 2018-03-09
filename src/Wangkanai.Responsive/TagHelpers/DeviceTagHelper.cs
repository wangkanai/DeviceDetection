using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.Detection;

namespace Wangkanai.Responsive.TagHelpers
{
    [HtmlTargetElement("device", Attributes = IncludeAttributeName)]
    [HtmlTargetElement("device", Attributes = ExcludeAttributeName)]
    public class DeviceTagHelper : TagHelper
    {
        private const string ElementName = "device";
        private const string IncludeAttributeName = "include";
        private const string ExcludeAttributeName = "exclude";

        private static readonly char[] NameSeparator = new[] { ',' };

        [HtmlAttributeName(IncludeAttributeName)]
        public string Include { get; set; }
        [HtmlAttributeName(ExcludeAttributeName)]
        public string Exclude { get; set; }

        private readonly IDeviceResolver Resolver;

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public DeviceTagHelper(TagHelperContext context, TagHelperOutput output, IDeviceResolver resolver)
        {
            if (resolver == null) throw new ArgumentNullException(nameof(resolver));

            Resolver = resolver;

            base.Process(context, output);
        }

        //public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        //{
        //    Process(context, output);
        //}
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            if (output == null) throw new ArgumentNullException(nameof(output));

            output.TagName = null;

            if (string.IsNullOrWhiteSpace(Include) && string.IsNullOrWhiteSpace(Exclude)) return;

            var device = Resolver.Device;
            var currentDeviceName = device.Type.ToString();

            if (Exclude != null)
            {
                var tokenizer = new StringTokenizer(Exclude, NameSeparator);
                foreach (var item in tokenizer)
                {
                    var client = item.Trim();
                    if (client.HasValue && client.Length > 0)
                        if (client.Equals(currentDeviceName, StringComparison.OrdinalIgnoreCase))
                        {
                            output.SuppressOutput();
                            return;
                        }
                }
            }

            var hasDevice = false;
            if (Include != null)
            {
                var tokenizer = new StringTokenizer(Include, NameSeparator);
                foreach (var item in tokenizer)
                {
                    var client = item.Trim();
                    if (client.HasValue && client.Length > 0)
                    {
                        hasDevice = true;
                        if (client.Equals(currentDeviceName, StringComparison.OrdinalIgnoreCase))
                            return;
                    }
                }
            }

            if (hasDevice) output.SuppressOutput();

            base.Process(context, output);
        }
    }
}
