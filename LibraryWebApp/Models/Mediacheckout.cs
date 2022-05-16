namespace LibraryWebApp.Models
{
    public class Mediacheckout
    {
        public int mediaid { get; set; }
        public string medianame { get; set; }
        public string mediatype { get; set; }
        public string mediagenre { get; set; }
        public string mediaauthor { get; set; }
        public int numberofcopies { get; set; }
        public bool mediacheck { get; set; }
    }
}
