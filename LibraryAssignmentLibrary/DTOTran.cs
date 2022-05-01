using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbAssgLibrary
{
    public class DTOTran
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


        public void PrintTran(List<DTOTran> tranlist, string option)
        {
            if (option == "ALL")
            {
                Console.WriteLine("List of Transaction Detail");
                foreach (var j in tranlist)
                {
                    Console.WriteLine("User Name   	   		: " + j.username);
                    Console.WriteLine("Transaction ID  		: " + j.transactionid);
                    Console.WriteLine("Media ID        		: " + j.mediaid);
                    Console.WriteLine("Media Name      		: " + j.medianame);
                    Console.WriteLine("Quantity    	   		: " + j.mediaqty);
                    Console.WriteLine("Transaction Status   : " + j.transactionstatus);
                    Console.WriteLine("Transaction Type     :" + j.transactiontype);
                    Console.WriteLine("-----------------------");
                }
            }
            else if(option=="USER")
            {
                foreach (var j in tranlist)
                {
                    Console.WriteLine("Media Name      		: " + j.medianame);
                    Console.WriteLine("Quantity    	   		: " + j.mediaqty);
                }
            }


        }


    }
}
