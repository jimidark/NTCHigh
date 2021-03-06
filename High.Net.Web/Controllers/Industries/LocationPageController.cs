﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using High.Net.Core;
using High.Net.Models.Shared.Pages;
using High.Net.Models.Constants;

namespace High.Net.Web.Controllers.Industries
{
    [TemplateDescriptor(Name = SiteGroups.HII)]
    public class LocationPageController : IndustriesController<LocationPage>
    {
        public ActionResult Index(LocationPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            return View("~/Views/Industries/Pages/LocationPage/Index.cshtml", model);
        }
    }
}