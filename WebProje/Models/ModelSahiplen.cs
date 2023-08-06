using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace WebProje.Models
{
    public class ModelSahiplen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SahiplenmeID { get; set; }
        [Required(ErrorMessage = "Hayvan ID is required")]
        public int HayvanID { get; set; }
        [Required(ErrorMessage = "E-Mail is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required]
        public string IsimSoyisim { get; set; }
        [Required]
        public int TelNo { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Şifre is required")]
        public int Sifre { get; set; }
        public string SahiplenmeDurumu { get; set; }
    }
}
