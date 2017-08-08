﻿using Abp.Web.Mvc.Authorization;
using System.Web.Mvc;

namespace ABPProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ABPProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}