// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;
using Wangkanai.Extensions.Browser;

namespace Wangkanai.AspNetCore.Responsiveness
{
    /// <summary>
    /// a <see cref="IViewLocationExpander"/> that adds the lanuage as an extension prefix to view names.
    /// device that is getting added as extensions prefix comes from <see cref="Microsoft.AspNetCore.Http.HttpContext"/>.
    /// </summary>
    /// <example>
    /// For the default case with no areas, views are generated with the following patterns
    /// (assuming controller is "Home", action is "Index" and device is "mobile")
    /// Views/Home/mobile/Action
    /// Views/Home/Action
    /// Views/Shared/mobile/Action
    /// Views/Shared/Action
    /// </example>
    public class ResponsivenessViewLocationExpander : IViewLocationExpander
    {
        private const string ValueKey = "device";
        private ResponsivenessViewLocationExpanderFormat _format;

        /// <summary>
        /// Instantiates a new <see cref="ResponsivenessViewLocationExpander"/> instance.
        /// </summary>
        public ResponsivenessViewLocationExpander() : this(ResponsivenessViewLocationExpanderFormat.Suffix) { }

        /// <summary>
        /// Instantiates a new <see cref="ResponsivenessViewLocationExpander"/> instance.
        /// </summary>
        /// <param name="format">The <see cref="ResponsivenessViewLocationExpanderFormat"/>.</param>
        public ResponsivenessViewLocationExpander(ResponsivenessViewLocationExpanderFormat format)
        {
            _format = format;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            context.Values[ValueKey] = "mobile"; // waiting for device resolver
        }

        public IEnumerable<string> ExpandViewLocations(
            ViewLocationExpanderContext context,
            IEnumerable<string> viewLocations)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            if (viewLocations == null) throw new ArgumentNullException(nameof(viewLocations));

            string value;
            context.Values.TryGetValue(ValueKey, out value);

            if (!string.IsNullOrEmpty(value))
            {
                DeviceInfo device;
                try
                {
                    device = new DeviceInfo(value);
                }
                catch (DeviceNotFoundException)
                {
                    return viewLocations;
                }

                return ExpandViewLocationsCore(viewLocations, device);
            }

            return viewLocations;
        }

        private IEnumerable<string> ExpandViewLocationsCore(IEnumerable<string> viewLocations, DeviceInfo deviceinfo)
        {
            foreach (var location in viewLocations)
            {
                if (_format == ResponsivenessViewLocationExpanderFormat.Area)
                    yield return location.Replace("{0}", deviceinfo.Name + "/{0}");
                else
                    yield return location.Replace("{0}", "{0}." + deviceinfo.Name);

                yield return location;
            }
        }
    }
}
