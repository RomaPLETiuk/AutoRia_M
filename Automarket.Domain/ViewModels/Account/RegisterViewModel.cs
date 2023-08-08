using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Ваше ім'я")]
        [MaxLength(20, ErrorMessage = "Ім'я має бути менше 20 символів")]
        [MinLength(3, ErrorMessage = "Ім'я має бути більше 3 символів")]
        public string Name { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Вкажіть пароль")]
        [MinLength(6, ErrorMessage = "Пароль ммає бути більше 6 символів")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Підтвердження пароля")]
        [Compare("Password", ErrorMessage = "А паролі не співпадають")]
        public string PasswordConfirm { get; set; }
    }
}