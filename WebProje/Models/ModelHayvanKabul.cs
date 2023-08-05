using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class ModelHayvanKabul
    {
        [Required]
        public int HayvanID { get; set; }
        [Required]
        public int Animal_Name { get; set; }
        [Required]
        public int Animal_Age { get; set; }
        [Required]
        public int Animal_Gender { get; set; }
        [Required]
        public int Animal_Kind { get; set; }
    }
}
