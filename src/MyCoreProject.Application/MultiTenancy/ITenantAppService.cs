using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCoreProject.MultiTenancy.Dto;

namespace MyCoreProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

