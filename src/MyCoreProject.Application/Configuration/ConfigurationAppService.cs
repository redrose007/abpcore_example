using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyCoreProject.Configuration.Dto;

namespace MyCoreProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyCoreProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
