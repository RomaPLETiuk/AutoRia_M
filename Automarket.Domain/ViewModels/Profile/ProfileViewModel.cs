using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.ViewModels.Profile
{
    public class ProfileViewModel
    {
        public long Id { get; set; }
        
        [Required(ErrorMessage = "Ваш вік")]
        [Range(0, 150, ErrorMessage = "Вік повинен бути від 0 до 150")]
        public byte Age { get; set; }
        
        [Required(ErrorMessage = "Вкажіть адресу")]
        [MinLength(5, ErrorMessage = "має бути більше 5 символів")] 
        [MaxLength(200, ErrorMessage = "має бути менше 200 символів")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Вкажіть імя")]
        public string UserName { get; set; }
    }
}