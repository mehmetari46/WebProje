using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class Login
    {
        [Required(ErrorMessage = "User name is required")]
        public int User_Name { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public int password { get; set; }
        [Required(ErrorMessage = "E-Mail  is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public int E_Mail { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public int First_Name { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public int Last_Name { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        public int Phone { get; set; }

}
}