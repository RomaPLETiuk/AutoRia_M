using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Введіть ім'я")]
        [MaxLength(20, ErrorMessage = "Ім'я має бути менше 20 символів")]
        [MinLength(3, ErrorMessage = "Ім'я має бути більше 3 символів")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введіть пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}