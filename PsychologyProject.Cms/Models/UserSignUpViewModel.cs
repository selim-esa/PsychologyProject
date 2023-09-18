using System.ComponentModel.DataAnnotations;

namespace PsychologyProject.Cms.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad soyad")]
        [Required(ErrorMessage ="Lütfen ad soyad giriniz")]
        public string NameSurname { get; set; }

        [Display(Name = "şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }

        [Display(Name = "şifre tekrar")]
        [Compare("Password",ErrorMessage = "şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail adresi")]
        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }



    }
}
