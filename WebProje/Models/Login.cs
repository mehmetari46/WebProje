using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProje.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_ID { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı kısmı boş bırakılamaz")]
        public string User_Name { get; set; }
        [Required(ErrorMessage = "Şifre kısmı boş bırakılamaz")]
        public string password { get; set; }
        [Required(ErrorMessage = "E-mail kısmı boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir e-mail adresi giriniz")]
        public string E_Mail { get; set; }
        [Required(ErrorMessage = "isim kısmı boş bırakılamaz")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Soyisim kısmı boş bırakılamaz")]
        public string Last_Name { get; set; }
        [Required(ErrorMessage = "Telefon numarası kısmı boş bırakılamaz")]
        public string Phone { get; set; }

}
}