using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProje.Models
{
    public class ModelHayvanKabul
    {
        
        [Key]
        public int HayvanID { get; set; }
        public int User_ID { get; set; }

        public string Animal_Name { get; set; }

        public int Animal_Age { get; set; }

        public string Animal_Gender { get; set; }

        public string Animal_Kind { get; set; }
        public string HayvanDurum { get; set; }

    }
}
