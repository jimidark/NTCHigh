﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using High.Net.Models.SteelServiceCentre.Pages;
using High.Net.Core;
using High.Net.Models.Constants;
using High.Net.Models.Shared.Pages;

namespace High.Net.Web.Controllers.SteelServiceCentre
{
    [TemplateDescriptor(Name = SiteGroups.SSC)] 
    public class NewsItemPageController : PageController<NewsItemPage>
    {
        public ActionResult Index(NewsItemPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            return View("~/Views/SteelServiceCentre/Pages/NewsItemPage/Index.cshtml", model);
        }
    }
}