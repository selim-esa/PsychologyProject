using System.ComponentModel.DataAnnotations;

namespace PsychologyProject.Cms.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="lütfen boş bırakmayın")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "lütfen boş bırakmayın")]
        public string Password { get; set; }
    }
}
