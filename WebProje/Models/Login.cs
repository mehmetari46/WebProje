using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProje.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_ID { get; set; }
        [Required(ErrorMessage = "User name is required")]
        public string User_Name { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public int password { get; set; }
        [Required(ErrorMessage = "E-Mail  is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string E_Mail { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string Last_Name { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        public int Phone { get; set; }

}
}