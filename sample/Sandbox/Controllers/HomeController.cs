// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wangkanai.Detection;
using Wangkanai.Responsive;

namespace Sandbox.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IResponsiveResolver _resolver;

        //public HomeController(IResponsiveResolver resolver)
        //{
        //    this._resolver = resolver;
        //}

        public IActionResult Index()
        {
            return View();//_resolver.DeviceInfo);
        }

        [HttpPost]
        public IActionResult ChangeToDesktop()
        {
            var preference = HttpContext.GetDevice();
            preference.Change(DeviceType.Desktop);
            HttpContext.SetDevice(preference);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeToMobile()
        {
            var preference = HttpContext.GetDevice();
            preference.Change(DeviceType.Mobile);
            HttpContext.SetDevice(preference);
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
