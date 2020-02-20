using Abp.Authorization;
using MyCoreProject.Authorization.Roles;
using MyCoreProject.Authorization.Users;

namespace MyCoreProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
