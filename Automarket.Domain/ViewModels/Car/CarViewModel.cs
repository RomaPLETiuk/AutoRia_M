using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Automarket.Domain.ViewModels.Car
{
    public class CarViewModel
    {
        public long Id { get; set; }
        
        [Display(Name = "Назва")]
        [Required(ErrorMessage = "Введіть назву")]
        [MinLength(2, ErrorMessage = "Назва має бути два і більше символів")]
        public string Name { get; set; }
        
        [Display(Name = "Опис")]
        [MinLength(50, ErrorMessage = "Рпис має бути більше 50 символів")]
        public string Description { get; set; }
        
        [Display(Name = "Модель")]
        [Required(ErrorMessage = "Вкажіть модель")]
        [MinLength(2, ErrorMessage = "Має бути два і більше символів")]
        public string Model { get; set; }
        
        [Display(Name = "Швидкість")]
        [Required(ErrorMessage = "Вкажіть швидкість")]
        [Range(0, 600, ErrorMessage = "Швидкість може бути від 0 до 600 км/год")]
        public double Speed { get; set; }
        
        [Display(Name = "Вартісь")]
        [Required(ErrorMessage = "Вккажіть ціну")]
        public decimal Price { get; set; }

        public string DateCreate { get; set; }
        
        [Display(Name = "Тип автомобіиля")]
        [Required(ErrorMessage = "Виберіть тип")]
        public string TypeCar { get; set; }

        public IFormFile Avatar { get; set; }
        
        public byte[]? Image { get; set; }
    }
}