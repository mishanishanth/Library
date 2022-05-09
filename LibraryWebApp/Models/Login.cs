using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Please enter username"),MaxLength(30)]
        public string username { get; set; }
        [Required(ErrorMessage ="Please enter password")]
        public string password { get; set; }
    }
}
