using System.ComponentModel.DataAnnotations;

namespace EnekasEdalat.Portal.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}