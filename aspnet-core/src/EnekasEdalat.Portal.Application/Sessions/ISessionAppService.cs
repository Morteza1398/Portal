using System.Threading.Tasks;
using Abp.Application.Services;
using EnekasEdalat.Portal.Sessions.Dto;

namespace EnekasEdalat.Portal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
