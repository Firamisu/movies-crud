using System.ComponentModel.DataAnnotations;

namespace Filmy.Models
{
    public class Data
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string Topic { get; set; }
        [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string Content { get; set; }

    }
}

