using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyCoreProject.Controllers
{
    public abstract class MyCoreProjectControllerBase: AbpController
    {
        protected MyCoreProjectControllerBase()
        {
            LocalizationSourceName = MyCoreProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
