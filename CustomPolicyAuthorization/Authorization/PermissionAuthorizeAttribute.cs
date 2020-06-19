using System;
using Microsoft.AspNetCore.Authorization;

namespace CustomPolicyAuthorization.Authorization
{
    public class PermissionAuthorizeAttribute : AuthorizeAttribute
    {
        const string POLICY_PREFIX = "Permission";

        public PermissionAuthorizeAttribute(Role permission) => Permission = (int)permission;

        public int Permission
        {
            get
            {
                if (int.TryParse(Policy.Substring(POLICY_PREFIX.Length), out var permission))
                {
                    return permission;
                }
                return default(int);
            }
            set
            {
                Policy = $"{POLICY_PREFIX}{value.ToString()}";
            }
        }
    }
}
