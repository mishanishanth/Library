using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Login
    {
        [Required (ErrorMessage ="Name is required")]
        public string username { get; set; }

        [Required(ErrorMessage ="password is required")]
        public string password { get; set; }
    }
}
