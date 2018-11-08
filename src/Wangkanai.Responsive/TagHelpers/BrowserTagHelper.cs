using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wangkanai.Responsive.TagHelpers
{
    [HtmlTargetElement("browser")]
    public class BrowserTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.AppendHtml("browser");
        }
    }
}
