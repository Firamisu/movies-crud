using System.ComponentModel.DataAnnotations;

namespace Filmy.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Imię jest wymagane")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane")]
        [StringLength(100, ErrorMessage = "Hasło musi mieć co najmniej {2} znaków", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$",
            ErrorMessage = "Hasło musi zawierać co najmniej jedną małą literę, jedną dużą literę i jedną cyfrę")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane")]
        [Compare("Password", ErrorMessage = "Hasła nie są zgodne")]
        public string ConfirmPassword { get; set; }

        [Phone]
        [Required(ErrorMessage = "Numer tel jest wymagany")]
        public string PhoneNumber { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi być pomiędzy 10 a 80 lat")]
        [Required(ErrorMessage = "Wiek jest wymagany")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Musisz wybrać miasto")]
        public string City { get; set; }
    }
}



public enum CityEnum
{
    Warsaw,
    Cracow,
    Wroclaw,
    Poznan,
    Katowice,
}