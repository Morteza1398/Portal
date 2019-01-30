using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EnekasEdalat.Portal.Roles.Dto;
using EnekasEdalat.Portal.Users.Dto;

namespace EnekasEdalat.Portal.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
