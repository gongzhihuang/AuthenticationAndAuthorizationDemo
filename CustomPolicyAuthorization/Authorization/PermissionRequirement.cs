using System;
using Microsoft.AspNetCore.Authorization;

namespace CustomPolicyAuthorization.Authorization
{
    public class PermissionRequirement : IAuthorizationRequirement
    {
        /// <summary>
        /// 用户权限信息
        /// </summary>
        public int Permission { get; private set; }

        public PermissionRequirement(int permission) { Permission = permission; }
    }
}
