using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Wangkanai.Detection;
using Xunit;

namespace Wangkanai.Responsive.Test.Core
{
    public class ResponsiveViewLocationExpanderTests
    {
        [Fact]
        public void Ctor_Default_Success()
        {
            var locationExpander = new ResponsiveViewLocationExpander();
            // May be we can make "_format" public so we can test the default value is set properly.
        }

        [Fact]
        public void Ctor_ResponsiveViewLocationFormat_Success()
        {
            var locationExpander = new ResponsiveViewLocationExpander(ResponsiveViewLocationFormat.Subfolder);
            // May be we can make "_format" public so we can test the value is set properly.
        }

        [Fact]//(Skip = "This case is not handled.")]
        public void Ctor_InvalidFormat_InvalidEnumArgumentException()
        {
            var max = int.MaxValue;
            var locationFormat = (ResponsiveViewLocationFormat)max;
            Assert.Throws<InvalidEnumArgumentException>(() => new ResponsiveViewLocationExpander(locationFormat));
        }

        [Fact]//(Skip = "Fails with NullReferenceExeption because context.Values is not set to instance of an object.")]
        public void PopulateValues_ViewLocationExpanderContext_Success()
        {
            string deviceKey = "device"; // May this one can be public in ResponsiveViewLocationExpander.cs.
            var context = SetupViewLocationExpanderContext();
            var locationExpander = new ResponsiveViewLocationExpander();
            locationExpander.PopulateValues(context);

            Assert.NotEqual(0, context.Values.Count);
            Assert.Same(context.ActionContext.HttpContext.GetDevice().Device, context.Values[deviceKey]);
        }        

        [Fact]
        public void PopulateValues_Null_ThrowsArgumentNullException()
        {
            var locationExpander = new ResponsiveViewLocationExpander();
            Assert.Throws<ArgumentNullException>(() => locationExpander.PopulateValues(null));
        }

        [Fact(Skip = "Fails with NullReferenceExeption because context.Values is not set to instance of an object.")]
        public void ExpandViewLocations_ViewLocationExpanderContext_IEnumerable_ReturnsExpected()
        {
            var context = SetupViewLocationExpanderContext();
            var viewLocations = new List<string>() { "{0} location1", "{0} location2" };
            var locationExpander = new ResponsiveViewLocationExpander();
            locationExpander.PopulateValues(context);
            var resultLocations = locationExpander.ExpandViewLocations(context, viewLocations);
            
            Assert.True(viewLocations.Count < resultLocations.ToList().Count);
        }

        [Fact(Skip = "Fails with NullReferenceExeption because context.Values is not set to instance of an object.")]
        public void ExpandViewLocations_NoDevice_ReturnsExpected()
        {
            var context = SetupViewLocationExpanderContext();
            var viewLocations = new List<string>() { "{0} location1", "{0} location2" };
            var locationExpander = new ResponsiveViewLocationExpander();
            var resultLocations = locationExpander.ExpandViewLocations(context, viewLocations);
            
            Assert.Equal(viewLocations.Count, resultLocations.ToList().Count);
        }

        [Fact]
        public void ExpandViewLocations_Null_IEnumerable_ThrowsArgumentNullException()
        {
            var locationExpander = new ResponsiveViewLocationExpander();
            Assert.Throws<ArgumentNullException>(() => locationExpander.ExpandViewLocations(null, new List<string>()));
        }

        [Fact]
        public void ExpandViewLocations_ViewLocationExpanderContext_Null_ThrowsArgumentNullException()
        {
            var locationExpander = new ResponsiveViewLocationExpander();
            Assert.Throws<ArgumentNullException>(() => locationExpander.ExpandViewLocations(SetupViewLocationExpanderContext(), null));
        }

        private ViewLocationExpanderContext SetupViewLocationExpanderContext()
        {
            var basecontext = new ContextWithViewLocationExpander();
            var action = basecontext.CreateActionContext("test");
            var context = new ViewLocationExpanderContext(action, "View", "Controller", "Area", "Page", true);
            context.ActionContext.HttpContext = new DefaultHttpContext();
            context.ActionContext.HttpContext.SetDevice(new UserPerference() { Device = DeviceType.Tablet.ToString() });

            return context;
        }
    }

    public class ContextWithViewLocationExpander : ResponsiveTestAbstract
    {
        public ActionContext CreateActionContext(string agent)
        {
            var http = CreateContext(agent);
            var action = new Mock<ActionContext>();
            action.Setup(f => f.HttpContext).Returns(http);

            return action.Object;
        }
    }
}
