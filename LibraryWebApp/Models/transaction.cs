
using System;
namespace LibraryWebApp.Models
{
    public class transaction
    {
        public int transactionid { get; set; }
        public int mediaid { get; set; }
        public int userid { get; set; }
        public int mediaqty { get; set; }
        public string transactiontype { get; set; }
        public string transactionstatus { get; set; }
        public DateTime transactiondate { get; set; }
        public string username { get; set; }
        public string medianame { get; set; }
    }
}
