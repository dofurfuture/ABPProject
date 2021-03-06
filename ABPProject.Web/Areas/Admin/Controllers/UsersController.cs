﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ABPProject.Authorization;
using ABPProject.Users;
using Abp.Authorization;
using ABPProject.CommonDto;
using ABPProject.Web.Controllers;

namespace ABPProject.Web.Areas.Admin.Controllers
{
    [AbpMvcAuthorize(PermissionNames.User)]
    //[AbpMvcAuthorize]
    public class UsersController : ABPProjectControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }

        /// <summary>
        /// 分页获取user列表(也可直接调用服务层接口)
        /// </summary>
        /// <param name="pageArg">{PageSize: 10, PageNumber: 0, SortOrder: "asc", SearchText: "", SortName: ""}</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult PagedList(PageParams pageArg)
        {
            var result = _userAppService.GetPagedUser(pageArg);
            return Json(result);
        }
    }
}