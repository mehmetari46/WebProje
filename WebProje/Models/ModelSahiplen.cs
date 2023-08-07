using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class ModelSahiplen
    {
        [Key]
        public int SahiplenmeID { get; set; }
        public int HayvanID { get; set; }
        public string Email { get; set; }
        
        public string IsimSoyisim { get; set; }
        
        public string TelNo { get; set; }
        
        public string Adres { get; set; }
        
        public string Sifre { get; set; }
    }
}
