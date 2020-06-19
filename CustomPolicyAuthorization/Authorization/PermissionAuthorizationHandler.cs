using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CustomPolicyAuthorization.Authorization
{
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
    {
        //IAcountService _acountService;

        //public PermissionAuthorizationHandler(IAcountService acountService)
        //{
        //    _acountService = acountService;
        //}

        public PermissionAuthorizationHandler()
        {

        }

        /// <summary>
        /// 授权处理
        /// </summary>
        /// <param name="context"></param>
        /// <param name="requirement"></param>
        /// <returns></returns>
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            IEnumerable<Claim> claims = context.User.Claims;
            //var userId = claims.Where(x => x.Type == "user_name").FirstOrDefault()?.Value;

            //if (string.IsNullOrWhiteSpace(userId))
            //{
            //    context.Fail();
            //}
            //UserResponseDTO user = await _acountService.GetUserByUserId(userId);

            //if (user == null)
            //{
            //    context.Fail();
            //}
            //else
            //{
            //    if ((int)user.Role == requirement.Permission)
            //    {
            //        context.Succeed(requirement);
            //    }
            //}
        }
    }
}
