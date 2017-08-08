﻿using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace ABPProject.Authorization
{
    public class ABPProjectAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            ////Common permissions
            //var pages = context.GetPermissionOrNull(PermissionNames.Pages);
            //if (pages == null)
            //{
            //    pages = context.CreatePermission(PermissionNames.Pages, L("Pages"));
            //}
            //var users = pages.CreateChildPermission(PermissionNames.Pages_Users, L("Users"));
            ////Host permissions
            //var tenants = pages.CreateChildPermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            //用户模块相关权限
            var user = context.GetPermissionOrNull(PermissionNames.User);
            if (user == null)
            {
                user = context.CreatePermission(PermissionNames.User, L("P_User"));
            }
            var userCreate = user.CreateChildPermission(PermissionNames.User_Create, L("P_UserCreate"));
            var userDelete = user.CreateChildPermission(PermissionNames.User_Delete, L("P_UserDelete"));
            var userSetRole = user.CreateChildPermission(PermissionNames.User_SetRole, L("P_UserSetRole"));
            //角色模块相关权限
            var role = context.GetPermissionOrNull(PermissionNames.Role);
            if (role == null)
            {
                role = context.CreatePermission(PermissionNames.Role, L("P_Role"));
            }
            var roleCreate = role.CreateChildPermission(PermissionNames.Role_Create, L("P_RoleCreate"));
            var roleEdit = role.CreateChildPermission(PermissionNames.Role_Edit, L("P_RoleEdit"));
            var roleDelete = role.CreateChildPermission(PermissionNames.Role_Delete, L("P_RoleDelete"));
            var roleSetPermission = role.CreateChildPermission(PermissionNames.Role_SetPermission, L("P_RoleSetPermission"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ABPProjectConsts.LocalizationSourceName);
        }
    }
}
