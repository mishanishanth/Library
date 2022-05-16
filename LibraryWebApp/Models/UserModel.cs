

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LibraryWebApp.Models
{
    public class UserModel
    {
       
        public string role { get; set; }
        public List<string> rolelist { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        [Required]
        public string emailid { get; set; }
        [Required]
        public string username { get; set; }
      //  [Required]
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
