using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class ModelSahiplen
    {
        [Required(ErrorMessage = "Hayvan ID is required")]
        public int HayvanID { get; set; }
        [Required(ErrorMessage = "E-Mail is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public int Email { get; set; }
        public int IsimSoyisim { get; set; }
        public int TelNo { get; set; }
        public int Adres { get; set; }
        [Required(ErrorMessage = "Şifre is required")]
        public int Sifre { get; set; }
    }
}
