// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wangkanai.Responsive;

namespace Sandbox.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ResponsiveResolver _resolver;

        //public HomeController(ResponsiveResolver resolver)
        //{
        //    this._resolver = resolver;
        //}

        public IActionResult Index()
        {
            return View();//_resolver.DeviceInfo);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
