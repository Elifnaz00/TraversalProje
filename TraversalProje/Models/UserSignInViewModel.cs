using System.ComponentModel.DataAnnotations;

namespace TraversalProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kulllanıcı adını giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
