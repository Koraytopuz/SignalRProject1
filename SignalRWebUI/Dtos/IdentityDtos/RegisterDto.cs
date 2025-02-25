using System.ComponentModel.DataAnnotations;

namespace SignalRWebUI.Dtos.IdentityDtos
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Ad boş olamaz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad boş olamaz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "E-posta boş olamaz.")]
       
        public string Mail { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş olamaz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş olamaz.")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }
    }
}
