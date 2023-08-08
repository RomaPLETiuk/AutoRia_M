using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.Enum
{
    public enum TypeCar
    {
        [Display(Name = "Легковий Автомобіль")]
        PassengerCar = 0,
        [Display(Name = "Седан")]
        Sedan = 1,
        [Display(Name = "Хечбек")]
        HatchBack = 2,
        [Display(Name = "Мінівен")]
        Minivan = 3,
        [Display(Name = "Спорт кар")]
        SportsCar = 4,
        [Display(Name = "Позашляховик")]
        Suv = 5,
    }
}