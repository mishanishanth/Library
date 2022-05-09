

namespace LibraryWebApp.Models
{
    public class UserModel
    {
        public string role { get; set; } = "Guest";
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string emailid { get; set; }
        public string username { get; set; }
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
