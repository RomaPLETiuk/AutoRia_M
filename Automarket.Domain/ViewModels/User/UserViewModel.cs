using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.ViewModels.User
{
    public class UserViewModel
    {
        [Display(Name = "Id")]
        public long Id { get; set; }
        
        [Required(ErrorMessage = "Роль")]
        [Display(Name = "Роль")]
        public string Role { get; set; }
        
        [Required(ErrorMessage = "Логін")]
        [Display(Name = "Логін")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пароль")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}