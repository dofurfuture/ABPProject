﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ABPProject.Authorization;
using Abp.Authorization;
using ABPProject.Roles;
using ABPProject.CommonDto;
using ABPProject.Web.Controllers;

namespace ABPProject.Web.Areas.Admin.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Role)]
    //[AbpMvcAuthorize]
    public class RolesController : ABPProjectControllerBase
    {
        private readonly IRoleAppService _roleAppService;
        public RolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        /// <summary>
        /// 角色列表页
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> Index()
        {
            var output = await _roleAppService.GetRoles();
            return View(output);
        }

        /// <summary>
        /// 分页获取role列表(也可直接调用服务层接口)
        /// </summary>
        /// <param name="pageArg">{PageSize: 10, PageNumber: 0, SortOrder: "asc", SearchText: "", SortName: ""}</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult PagedList(PageParams pageArg)
        {
            var result = _roleAppService.GetPagedRole(pageArg);
            return Json(result);
        }
    }
}