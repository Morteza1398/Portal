using System.Threading.Tasks;
using EnekasEdalat.Portal.Configuration.Dto;

namespace EnekasEdalat.Portal.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
