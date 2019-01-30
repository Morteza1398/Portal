using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EnekasEdalat.Portal.MultiTenancy.Dto;

namespace EnekasEdalat.Portal.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

