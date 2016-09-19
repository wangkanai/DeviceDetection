// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;
using Wangkanai.Browser;

namespace Wangkanai.Responsive
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
    public class ResponsiveViewLocationExpander : IViewLocationExpander
    {
        private const string ValueKey = "Device";
        private readonly IClientInfo _client;
        private readonly ResponsiveViewLocationExpanderFormat _format;

        /// <summary>
        /// Instantiates a new <see cref="ResponsiveViewLocationExpander"/> instance.
        /// </summary>
        /// <param name="client">The <see cref="IClientInfo"/>.</param>
        /// <param name="format">The <see cref="ResponsiveViewLocationExpanderFormat"/>.</param>
        public ResponsiveViewLocationExpander(IClientInfo client, ResponsiveViewLocationExpanderFormat format)
        {
            _client = client;
            _format = format;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            context.Values[ValueKey] = _client.Device.Type.ToString();
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
                Device device;
                try
                {
                    device = new Device(); //value); waiting browser beta3
                }
                catch (DeviceNotFoundException)
                {
                    return viewLocations;
                }

                return ExpandViewLocationsCore(viewLocations, device);
            }

            return viewLocations;
        }

        private IEnumerable<string> ExpandViewLocationsCore(IEnumerable<string> viewLocations, Device device)
        {
            foreach (var location in viewLocations)
            {
                if (_format == ResponsiveViewLocationExpanderFormat.Subfolder)
                    yield return location.Replace("{0}", device.Type.ToString() + "/{0}");
                else
                    yield return location.Replace("{0}", "{0}." + device.Type.ToString());

                yield return location;
            }
        }
    }
}
