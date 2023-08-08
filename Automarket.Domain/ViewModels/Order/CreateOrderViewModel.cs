using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.ViewModels.Order
{
    public class CreateOrderViewModel
    {
        public int Id { get; set; }
        
        [Display(Name = "Кількість")]
        [Range(1, 10, ErrorMessage = "Кількість Може бути від 1 до 10")]
        public int Quantity { get; set; }

        [Display(Name = "Дата створення")]
        public DateTime DateCreated { get; set; }
        
        [Display(Name = "Адреса")]
        [Required(ErrorMessage = "Вкажіть адресу")]
        [MinLength(5, ErrorMessage = " Адреса має бути більше 5 символів ")] 
        [MaxLength(200, ErrorMessage = "Адреса має бути менше 200 символів")]
        public string Address { get; set; }
        
        [Display(Name = "Ім'я")]
        [Required(ErrorMessage = "Вкажіть ім'я")]
        [MaxLength(20, ErrorMessage = " Ім'я має бути менше 20 символів")]
        [MinLength(3, ErrorMessage = "Ім'я має бути більше 3 символів")]
        public string FirstName { get; set; }
        
        [Display(Name = "Прізвище")]
        [MaxLength(50, ErrorMessage = " Прізвище має бути менше 50 символів")]
        [MinLength(2, ErrorMessage = "Прізвище має бути більше 2 символів")]
        public string LastName { get; set; }
        
        [Display(Name = "Побатькові")]
        [MaxLength(50, ErrorMessage = "Побатькові має бути менше 50 символів")]
        [MinLength(2, ErrorMessage = "Отчество має бути більше 2 символів")]
        public string MiddleName { get; set; }
        
        public long CarId { get; set; }
        
        public string Login { get; set; }
    }   
}