﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using High.Net.Models.HighConstructionCo.Pages;
using High.Net.Core;

namespace High.Net.Web.Controllers.HighConstructionCo
{
    public class ProjectItemPageController : PageController<ProjectItemPage>
    {
        public ActionResult Index(ProjectItemPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            return View("~/Views/HighConstructionCo/Pages/ProjectItemPage/Index.cshtml",model);
        }
    }
}