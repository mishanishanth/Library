using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbAssgLibrary
{
    public class DTOMedia
    {
        public int mediaid { get; set; }
        public string medianame { get; set; }   
        public string mediatype { get; set; }
        public string mediagenre { get; set; }
        public string mediaauthor { get; set; }
        public int numberofcopies { get; set; }
        //public int publisherid { get; set; }

        public List<DTOMedia> register(string mediatype)
        {
          List<DTOMedia> medialist = new List<DTOMedia>();
            Console.Clear();
            if (mediatype.ToUpper() == "BOOK")
            {
                Console.WriteLine("Enter the Book Name ");
                string smedianame=Console.ReadLine();
                Console.WriteLine("Enter the Book Genre");
                string smediagenre=Console.ReadLine();
                Console.WriteLine("Enter the Author Name");
                string smediaauthor=Console.ReadLine();
                Console.WriteLine("Enter number of copies");
                int inumberofcopies = Convert.ToInt32(Console.ReadLine());
                medialist.Add(new DTOMedia
                {
                    mediatype = "BOOK",
                    medianame = smedianame,
                    mediagenre = smediagenre, 
                    mediaauthor=smediaauthor,
                    numberofcopies = inumberofcopies

                }
                );

            }

         return medialist;
        }

        public void PrintMedia(List<DTOMedia> medialist, string option)
        {
            if (option == "FULL")
            {
                Console.Clear();
                Console.WriteLine("List of Media");
                foreach (var j in medialist)
                {
                    Console.WriteLine("Media Name   	: " + j.medianame);
                    Console.WriteLine("Media Type   	: " + j.mediatype);
                    Console.WriteLine("Media Genre  	: " + j.mediagenre);
                    Console.WriteLine("Media Author 	: " + j.mediaauthor);
                    Console.WriteLine("Number of Copies : " + j.numberofcopies);
                }

            }
            if (option == "NAMEONLY")
            {
                foreach (var j in medialist)
                    Console.WriteLine("Media Name   	: " + j.medianame);
            }
        }



    }
}
