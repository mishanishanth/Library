using System;
using LibraryDBConnectLibrary;
using LbAssgLibrary;
using System.Collections.Generic;
using System.Linq;


namespace LibraryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBConnect dbc=new DBConnect();
            DTOUser dtouser=new DTOUser();
            DTORole dtorole=new DTORole();
            DTOMedia dtomedia=new DTOMedia();
            DTOTran dtotran=new DTOTran();
            List<DTORole> roles = new List<DTORole>();
            List<DTOUser> users = new List<DTOUser>();
            List<DTOMedia> media = new List<DTOMedia>();
            List<DTOTran> tran=new List<DTOTran>();
            dbc.viewroledata(roles);
            // dtorole.AddRole(roles, "Default");
            DTOUser globaluserlogin = new DTOUser();
            string globalusername;
            string globalpassword;
            string globalrolename;


            while (true)
            {
             
                    Console.WriteLine("Welcome to County Library System");
                    Console.WriteLine("   Roles Management       <Press R>");
                    Console.WriteLine("   User Management        <Press U>");
                    Console.WriteLine("   Media Management       <Press M>");
                    Console.WriteLine("   Media Checkin/Checkout <Press C>");
                    Console.WriteLine("   Exit <Press E>");
                     
                string option = Console.ReadLine();

                if (option.ToUpper() == "R")
                {
                    Console.Clear();
                    string roleoption;
                    Console.WriteLine("Enter username");
                    globalusername = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    globalpassword = Console.ReadLine();
                    globaluserlogin = dbc.autheticateuser(globalusername, globalpassword);
                    globalrolename = globaluserlogin.role;
                    if (globalrolename != "Administrator")
                    {
                        Console.WriteLine("Only Admin can modify Roles");
                        continue;
                    }
                    Console.WriteLine("Role Addition <Press RA>");
                    Console.WriteLine("Role Deletion <Press RD>");
                    Console.WriteLine("Role List <Press RL>");
                    roleoption = Console.ReadLine();
                    if (roleoption == "RA")
                    {
                        dtorole.AddRole(roles, "UserInput");
                        dbc.insertroledata(roles);

                    }
                    else if (roleoption == "RD")
                    {
                        Console.WriteLine("Enter the Role Name to delete");
                        string rolename = Console.ReadLine();
                        if (dbc.getroleid(rolename) > 0)
                        {
                            if (dbc.deleteroledata(rolename) == 1)
                                Console.WriteLine("Role Deleted Successfully");
                            else
                                Console.WriteLine("You cannot Delete Role assigned to User");
                        }
                        else
                            Console.WriteLine("Role doesnot Exists");
                    }
                    else if (roleoption == "RL")
                    {
                        roles.Clear();
                        dbc.viewroledata(roles);
                        Console.WriteLine("List of available Roles");
                        foreach (DTORole i in roles)
                            Console.WriteLine(i.role);
                    }

                }

                else if (option.ToUpper() == "U")
                {
                    Console.Clear();
                    Console.WriteLine("Register for new user <Press R>");
                    Console.WriteLine("Update User Information <Press UP>");
                    Console.WriteLine("Delete User <Press UD>");
                    Console.WriteLine("Print User <Press PU>");
                    Console.WriteLine("Print Profile <Press PP>");
                    Console.WriteLine("Login User <Press L>");
                    string input_user = Console.ReadLine();

                    if (input_user.ToUpper() == "R")
                    {
                        users.Clear();
                        while (true)
                        {
                            users.AddRange(dtouser.register(roles));
                            Console.WriteLine("Do you want to add another user(Yes/No)");
                            if (Console.ReadLine().ToUpper() != "YES")
                            {
                                Console.Clear();
                                dbc.insertuserdata(users);
                                Console.WriteLine("List of Available users :");
                                foreach (var j in users)
                                    Console.WriteLine(j.username);
                                break;
                            }
                        }

                    }

                    else if (input_user.ToUpper() == "UP")
                    {
                        string usrnameinput;
                        users.Clear();
                        Console.WriteLine("Enter the Username to Modify");
                        usrnameinput = Console.ReadLine();
                        dbc.viewuserdata(users, usrnameinput);
                        dtouser.update_userlist(users, usrnameinput);
                        if (dbc.updateuserdata(users) == 1)
                        {
                            Console.WriteLine(usrnameinput + " User Updated Successfully");
                        }
                        else
                            Console.WriteLine("Falied to Update the User");
                    }
                    else if (input_user.ToUpper() == "UD")
                    {
                        string usrnameinput;
                        Console.Clear();
                        Console.WriteLine("Enter username");
                        globalusername = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        globalpassword = Console.ReadLine();
                        globaluserlogin = dbc.autheticateuser(globalusername, globalpassword);
                        globalrolename = globaluserlogin.role;
                        if (globalrolename != "Administrator")
                        {
                            Console.WriteLine("Only Admin can modify Roles");
                            continue;
                        }
                        users.Clear();
                        Console.WriteLine("Enter your Username to Delete");
                        usrnameinput = Console.ReadLine();
                        dbc.viewuserdata(users, usrnameinput);
                        dtouser.PrintUser(users, "PP");
                        Console.WriteLine("Please confirm (Y) to Delete (Y/N)");
                        if (Console.ReadLine() == "Y")
                        {
                            if (dbc.deletuserdata(usrnameinput) == 1)
                            {
                                Console.WriteLine(usrnameinput + " User Deleted Successfully");
                            }

                        }
                    }
                    else if (input_user.ToUpper() == "PU")
                    {
                        Console.Clear();
                        users.Clear();
                        users.AddRange(dbc.viewuserdata(users, null));
                        dtouser.PrintUser(users, "PU");

                    }
                    else if (input_user.ToUpper() == "PP")
                    {
                        Console.Clear();
                        users.Clear();
                        dbc.viewuserdata(users, "");
                        dtouser.PrintUser(users, "PP");
                    }
                    else if (input_user.ToUpper() == "L")
                    {
                        Console.WriteLine("Enter your Username");
                        string usrname = Console.ReadLine();
                        Console.WriteLine("Enter your Password");
                        string psswd = Console.ReadLine();
                        if (dtouser.authenticate(users, usrname, psswd))
                        {
                            Console.WriteLine("User Modification <Press UM>");
                            Console.WriteLine("Logout <Press O>");
                            string louser_input = Console.ReadLine();
                            if (louser_input.ToUpper() == "UM")
                            {
                                dtouser.update_userlist(users, usrname);
                            }
                            else if (louser_input.ToUpper() == "O")
                            {
                                dtouser.logout(users, usrname);
                                Console.WriteLine("User Logged out :" + usrname);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Login");
                        }

                    }


                }
                else if(option=="M")
                {
                    Console.Clear();
                    Console.WriteLine("Media Addition <Press MA>");
                    Console.WriteLine("Media Updation <Press MU>");
                    Console.WriteLine("Media Deletion <Press MD>");
                    Console.WriteLine("Media List     <Press ML>");
                    string input_user=Console.ReadLine();
                    if (input_user.ToUpper() == "MA")
                    {
                        media.Clear();
                        while (true)
                        {
                            media.AddRange(dtomedia.register("BOOK"));
                            Console.WriteLine("Do you want to add another Media(Yes/No)");
                            if (Console.ReadLine().ToUpper() != "YES")
                            {
                                Console.Clear();
                                dbc.mediainsert(media);
                                Console.WriteLine("List of Available users :");
                                foreach (var j in media)
                                    Console.WriteLine(j.medianame);
                                break;
                            }
                        }
                    }
                    else if (input_user.ToUpper()=="MD")
                    {


                    }
                    else if(input_user.ToUpper()=="ML")
                    {
                        Console.Clear();
                        media.Clear();
                        dbc.viewmediadata(media, "");
                        dtomedia.PrintMedia(media, "FULL");
                    }

                }
                else if (option.ToUpper() == "C")
                {
                    Console.WriteLine("Enter your Username");
                    string usrname = Console.ReadLine();
                    Console.WriteLine("Enter your Password");
                    string psswd = Console.ReadLine();
                    DTOUser userauth;
                    DTOTran checkinout= new DTOTran();
                    string chkmedianame;
                    int chkmediaid;
                    userauth = dbc.autheticateuser(usrname,psswd);
                    if (userauth.username != "NA")
                    {
                        Console.WriteLine("Media Check-in/out system for :" + userauth.firstname + " " + userauth.lastname);
                        Console.WriteLine("Media Check Out  Press <MO>");
                        Console.WriteLine("Media Check In Press <MI>");
                        Console.WriteLine("Logout      Press <LO>");
                        string chkoption = Console.ReadLine();
                        if(chkoption.ToUpper() == "MO" +
                            "+")
                        {

                            media.Clear();
                            checkinout.userid = userauth.userid;
                            tran.Clear();
                            dtomedia.PrintMedia(dbc.viewmediadata(media, ""),"NAMEONLY");
                            while (true)
                            {
                                Console.WriteLine("Enter Media Name:");
                                chkmedianame = Console.ReadLine();
                                chkmediaid = dbc.getmediaid(chkmedianame);
                                if (chkmediaid >= 1)
                                {
                                    checkinout.mediaid = chkmediaid;
                                    checkinout.mediaqty = 1;
                                    checkinout.transactionstatus = "P";
                                    checkinout.transactiontype = "CI";
                                    tran.Add(checkinout);
                                }
                                else
                                    Console.WriteLine("Media is not available");
                                Console.WriteLine("Do you want to check out another media Press Y/N");
                                if (Console.ReadLine().ToUpper() !="Y")
                                { dbc.inserttransaction(tran);
                                    break; }    
                            }


                        }
                        else if(chkoption.ToUpper()=="MI")
                        {
                            tran.Clear();
                            checkinout.userid=userauth.userid;  
                            dbc.viewtransaction(tran, checkinout.userid);
                            Console.Clear();
                            if (tran.Count > 0)
                            {
                                Console.WriteLine("List of Media checked in " + checkinout.username);
                                dtotran.PrintTran(tran, "USER");
                                Console.WriteLine("Do you want to check out Press Y");
                                string usertraninput = Console.ReadLine();
                                if (usertraninput.ToUpper() == "Y")
                                {
                                    if (dbc.tranupdate(checkinout.userid) == 1) ;
                                    Console.WriteLine("Checked out Successfully");
                                }
                            }
                            else
                                Console.WriteLine("No Media to check out");

                        }

                    }
                    else
                        Console.WriteLine("Login Failed");
                }
                else if (option == "E")
                    Environment.Exit(0);
            }
        
        }
        
    }
}
