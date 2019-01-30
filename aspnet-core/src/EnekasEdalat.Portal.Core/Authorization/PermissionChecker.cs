using Abp.Authorization;
using EnekasEdalat.Portal.Authorization.Roles;
using EnekasEdalat.Portal.Authorization.Users;

namespace EnekasEdalat.Portal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
