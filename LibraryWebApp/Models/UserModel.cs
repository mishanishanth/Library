using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibraryWebApp.Models
{
    public class UserModel
    {
       
        public string role { get; set; }
        public List<string> rolelist { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string firstname { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string lastname { get; set; }
        [Required(ErrorMessage ="Email is required")]
        public string emailid { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Username 8 and 50 characters.")]
        [RegularExpression("^([a-zA-Z0-9.@]+)$", ErrorMessage = "Username must be letter, number, or . @ only")]
        public string username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password  8 and 50 characters.")]
        [RegularExpression("^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$!*]+).*$", ErrorMessage = "Password must be a Uppercase letter, number, or  #$!*@ only")]
        public string password { get; set; }
        public string phoneno { get; set; }
        public string loginlogoutstatus { get; set; }
        public string streetaddress { get; set; }
        public string city { get; set; }
        public string pincode { get; set; }
        public string accountstatus { get; set; }

        public int userid { get; set; }
    }
}
