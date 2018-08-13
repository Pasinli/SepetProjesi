using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace NTier.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Kullanıcı Adınızı Giriniz")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [
            Required(ErrorMessage = "Parola Giriniz"),
            DisplayName("Parola")
        ]
        public string Password { get; set; }

    }
}