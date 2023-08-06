using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProje.Models
{
    public class ModelHayvanKabul
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HayvanID { get; set; }
        public int SahiplenmeID { get; set; }
        [Required]
        public string Animal_Name { get; set; }
        [Required]
        public int Animal_Age { get; set; }
        [Required]
        public string Animal_Gender { get; set; }
        [Required]
        public string Animal_Kind { get; set; }
        public string SahiplenmeDurumu { get; set; }
    }
}
