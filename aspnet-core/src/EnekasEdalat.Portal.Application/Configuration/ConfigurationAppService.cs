using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EnekasEdalat.Portal.Configuration.Dto;

namespace EnekasEdalat.Portal.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PortalAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
