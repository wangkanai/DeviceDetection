// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.


using System;

namespace Wangkanai.Responsive
{
    public class UserPerference
    {
        private readonly ResponsiveOptions _options;
        private readonly string _device;

        public string Device { get; set; }

        public UserPerference()
        {

        }
        public UserPerference(ResponsiveOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));
        }
    }
}
