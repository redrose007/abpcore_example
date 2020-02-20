using System.ComponentModel.DataAnnotations;

namespace MyCoreProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}