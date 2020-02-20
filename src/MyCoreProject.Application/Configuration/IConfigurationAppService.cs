using System.Threading.Tasks;
using MyCoreProject.Configuration.Dto;

namespace MyCoreProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
