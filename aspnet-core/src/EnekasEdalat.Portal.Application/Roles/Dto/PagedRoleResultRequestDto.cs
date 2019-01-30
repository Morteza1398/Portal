using Abp.Application.Services.Dto;

namespace EnekasEdalat.Portal.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

