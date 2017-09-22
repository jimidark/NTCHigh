﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using High.Net.Models.Shared.Pages;
using High.Net.Core;
using High.Net.Models.Constants;

namespace High.Net.Web.Controllers.HighNet
{
    [TemplateDescriptor(Name = SiteGroups.HN)]
    public class NewsItemPageController : PageController<NewsItemPage>
    {
        public ActionResult Index(NewsItemPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            return View("~/Views/HighNet/Pages/NewsItemPage/Index.cshtml", model);
        }
    }
}