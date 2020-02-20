using System.Threading.Tasks;
using Abp.Application.Services;
using MyCoreProject.Sessions.Dto;

namespace MyCoreProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
