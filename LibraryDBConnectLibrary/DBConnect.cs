using System;
using System.Data.SqlClient;
using LbAssgLibrary;
using System.Collections.Generic;
using System.Data;
namespace LibraryDBConnectLibrary
{
    public class DBConnect
    {
       public  string connectionstring;
       SqlConnection dbcon;
        public SqlConnection DBopen()
        {
            connectionstring= @"Data Source=LAPTOP-UDQPO2MH; Initial Catalog=librarydb; User ID=libadmin; Password=Misha4632#";
            dbcon = new SqlConnection(connectionstring);
            try
            {
                dbcon.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Open Failed, Contact Administrator", ex.Errors);
                Environment.Exit(1);
            }
            return dbcon;
        }
        public void DBclose()
        {
            dbcon.Close();
        }
        public DTOUser autheticateuser(string usrname,string psswd)
        {
            DTOUser userinfo = new DTOUser();
            string sqlstring = "select username,psswd,firstname,lastname,lstatus,accountstatus,emailid,phoneno,streetaddress,city,pincode,rolename,userid from userlist, rolelist where rolelist.roleid=userlist.roleid and userlist.username='" + usrname + "' and psswd='" + psswd + "'";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring,DBopen());
           // try
           // {
            sqldata = sqlcmd.ExecuteReader();
            sqldata.Read();
            if (sqldata.HasRows)
                {
                    
                    userinfo.username = sqldata[0].ToString();
                    userinfo.password = sqldata[1].ToString();
                    userinfo.firstname = sqldata[2].ToString();
                    userinfo.lastname = sqldata[3].ToString();
                    userinfo.loginlogoutstatus = sqldata[4].ToString();
                    userinfo.accountstatus = sqldata[5].ToString();
                    userinfo.emailid = sqldata[6].ToString();
                    userinfo.phoneno = sqldata[7].ToString();
                    userinfo.streetaddress = sqldata[8].ToString();
                    userinfo.city = sqldata[9].ToString();
                    userinfo.pincode = sqldata[10].ToString();
                    userinfo.role = sqldata[11].ToString();
                    userinfo.userid = Convert.ToInt32(sqldata[12]);
                }
            else 
                { userinfo.username = "NA"; }

           // }
           // catch (Exception) { Console.WriteLine("Authentication Failed"); }
            DBclose();
            return userinfo;

        }
        public void insertuserdata(List<DTOUser> usrlist)
        {
            string sqlstring = "userinsert";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            int rolenametoid = 0;
            foreach (var u in usrlist)
            {
                sqlcmd.Parameters.Add(new SqlParameter("@usrname", u.username));
                sqlcmd.Parameters.Add(new SqlParameter("@psswd", u.password));
                sqlcmd.Parameters.Add(new SqlParameter("@firstname", u.firstname));
                sqlcmd.Parameters.Add(new SqlParameter("@lastname", u.lastname));
                sqlcmd.Parameters.Add(new SqlParameter("@emailid", u.emailid));
                sqlcmd.Parameters.Add(new SqlParameter("@streetaddress", u.streetaddress));
                sqlcmd.Parameters.Add(new SqlParameter("@city", u.city));
                sqlcmd.Parameters.Add(new SqlParameter("@pincode", u.pincode));
                sqlcmd.Parameters.Add(new SqlParameter("@phoneno", u.phoneno));
                rolenametoid = getroleid(u.role);
                sqlcmd.Parameters.Add(new SqlParameter("@roleid", rolenametoid));
                sqlcmd.Parameters.Add(new SqlParameter("@lstatus", u.loginlogoutstatus));
                sqlcmd.Parameters.Add(new SqlParameter("@accountstatus", u.accountstatus));
                sqldata = sqlcmd.ExecuteReader();
                sqlcmd.Parameters.Clear();
                sqldata.Close();

            }
            DBclose();

        }
        public int updateuserdata(List<DTOUser> usrlist)
        {
            string sqlstring = "userupdate";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlParameter returnparam;
            returnparam = new SqlParameter("@returnval", SqlDbType.Int);
            returnparam.Direction = ParameterDirection.Output;
            int retval=0;
            foreach (var u in usrlist)
            {
                sqlcmd.Parameters.Add(new SqlParameter("@usrname", u.username));
                sqlcmd.Parameters.Add(new SqlParameter("@lastname", u.lastname));
                sqlcmd.Parameters.Add(new SqlParameter("@emailid", u.emailid));
                sqlcmd.Parameters.Add(new SqlParameter("@streetaddress", u.streetaddress));
                sqlcmd.Parameters.Add(new SqlParameter("@city", u.city));
                sqlcmd.Parameters.Add(new SqlParameter("@pincode", u.pincode));
                sqlcmd.Parameters.Add(new SqlParameter("@phoneno", u.phoneno));
                sqlcmd.Parameters.Add(returnparam);
                sqldata = sqlcmd.ExecuteReader();
                retval = (int)sqlcmd.Parameters["@returnval"].Value;
                sqlcmd.Parameters.Clear();
                sqldata.Close();
            }
            
            DBclose();
            return retval;
        }

        public int deletuserdata(string username)
        {
            string sqlstring = "userdelete";
            SqlCommand sqlcmd;
            // SqlDataReader sqldata;
            SqlParameter returnparam;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@usrname", username));
            returnparam = new SqlParameter("@returnval", SqlDbType.Int);
            returnparam.Direction = ParameterDirection.Output;
            sqlcmd.Parameters.Add(returnparam);
            sqlcmd.ExecuteNonQuery();
            int retval= (int)sqlcmd.Parameters["@returnval"].Value;
            DBclose();
            return retval;
        }

        public List<DTOUser> viewuserdata(List<DTOUser> userlist,string username)
        {
            string sqlstring;
            if (username == String.Empty)
                sqlstring = "select username,psswd,firstname,lastname,lstatus,accountstatus,emailid,phoneno,streetaddress,city,pincode,rolename from userlist, rolelist where rolelist.roleid=userlist.roleid";
            else
                sqlstring = "select username,psswd,firstname,lastname,lstatus,accountstatus,emailid,phoneno,streetaddress,city,pincode,rolename from userlist, rolelist where rolelist.roleid=userlist.roleid and userlist.username='" + username + "'";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqldata = sqlcmd.ExecuteReader();
            while (sqldata.Read())
            {
                userlist.Add(new DTOUser
                {
                    username = sqldata[0].ToString(),
                    password = sqldata[1].ToString(),
                    firstname = sqldata[2].ToString(),
                    lastname = sqldata[3].ToString(),
                    loginlogoutstatus = sqldata[4].ToString(),
                    accountstatus = sqldata[5].ToString(),
                    emailid = sqldata[6].ToString(),
                    phoneno = sqldata[7].ToString(),
                    streetaddress = sqldata[8].ToString(),
                    city = sqldata[9].ToString(),
                    pincode = sqldata[10].ToString(),
                    role = sqldata[11].ToString()
                }
                );
                
            }
           // foreach (var i in userlist)
          //  Console.WriteLine(i.username);
            DBclose();
            return userlist;
         }
        
               
        
       
        public List<DTORole> viewroledata(List<DTORole> roles)
        { 
            string sqlstring = "select rolename from rolelist";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            try
            {
                using (sqldata = sqlcmd.ExecuteReader())
                {
                    string roleinfo;
                    while (sqldata.Read())
                    {
                        roleinfo = sqldata[0].ToString();
                        roles.Add(new DTORole { role = roleinfo });
                    }
                    DBclose();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Role list from Database Failed" + ex.Errors);
            }


            return roles;

        }

        public void insertroledata(List<DTORole> roles)
        {
            string sqlstring = "roleinsert";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            foreach (var r in roles)
            {
                sqlcmd.Parameters.Add(new SqlParameter("@rolename", r.role));
                sqldata = sqlcmd.ExecuteReader();
                sqlcmd.Parameters.Clear();
                sqldata.Close();

            }
            DBclose ();
        }

        public int deleteroledata(string rolename)
        {
            string sqlstring = "roledelete";
            SqlCommand sqlcmd;
           // SqlDataReader sqldata;
            SqlParameter returnparam;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@rolename",rolename));
            returnparam=new SqlParameter("@returnval", SqlDbType.Int);
            returnparam.Direction = ParameterDirection.Output;
            sqlcmd.Parameters.Add(returnparam);
            sqlcmd.ExecuteNonQuery();
            //sqldata = sqlcmd.ExecuteReader();
            //Console.WriteLine(sqldata.ToString());
            int retval = (int)sqlcmd.Parameters["@returnval"].Value;
            DBclose ();
            return retval;
        }

        public int getroleid(string rolename)
        {
            int roleid;
            string sqlstring = "select roleid from rolelist where rolename='" + rolename + "'" ;
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqldata = sqlcmd.ExecuteReader();
            sqldata.Read();
            if (sqldata.HasRows)
                roleid = Convert.ToInt32(sqldata[0]);
            else
                roleid = 0;
            DBclose();
            return roleid;

        }

        public void mediainsert(List<DTOMedia> medialist)
        {
            string sqlstring = "mediainsert";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            foreach (var m in medialist)
            {
                sqlcmd.Parameters.Add(new SqlParameter("@medianame", m.medianame));
                sqlcmd.Parameters.Add(new SqlParameter("@mediatype", m.mediatype));
                sqlcmd.Parameters.Add(new SqlParameter("@mediagenre", m.mediagenre));
                sqlcmd.Parameters.Add(new SqlParameter("@mediaauthor", m.mediaauthor));
                sqlcmd.Parameters.Add(new SqlParameter("@numberofcopies", m.numberofcopies));
                sqldata = sqlcmd.ExecuteReader();
                sqlcmd.Parameters.Clear();
                sqldata.Close();

            }
            DBclose();

        }
        public List<DTOMedia> viewmediadata(List<DTOMedia> medialist, string medianame)
        {
            string sqlstring;
            if (medianame == String.Empty)
                sqlstring = "select mediaid,medianame,mediatype,mediagenre,mediaauthor,numberofcopies from medialist";
            else
                sqlstring = "select mediaid,medianame,mediatype,mediagenre,mediaauthor,numberofcopies from medialist where medianame='" + medianame + "'";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqldata = sqlcmd.ExecuteReader();
            while (sqldata.Read())
            {
                medialist.Add(new DTOMedia
                {
                    mediaid = Convert.ToInt32(sqldata[0]),
                    medianame = sqldata[1].ToString(),
                    mediatype = sqldata[2].ToString(),
                    mediagenre = sqldata[3].ToString(),
                    mediaauthor = sqldata[4].ToString(),
                    numberofcopies = Convert.ToInt32(sqldata[5])
                }
                );

            }

            DBclose();
            return medialist;
        }
        public int getmediaid(string medianame)
        {
            int mediaid;
            string sqlstring = "select mediaid from medialist where numberofcopies >=1 and medianame='" + medianame + "'";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqldata = sqlcmd.ExecuteReader();
            sqldata.Read();
            if (sqldata.HasRows)
                mediaid = Convert.ToInt32(sqldata[0]);
            else
                mediaid = 0;
            DBclose();
            return mediaid;

        }

        public void inserttransaction(List<DTOTran> tranlist)
        {
            string sqlstring = "traninsert";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            foreach (var t in tranlist)
            {
                sqlcmd.Parameters.Add(new SqlParameter("@mediaid", t.mediaid));
                sqlcmd.Parameters.Add(new SqlParameter("@userid", t.userid));
                sqlcmd.Parameters.Add(new SqlParameter("@mediaqty", t.mediaqty));
                sqlcmd.Parameters.Add(new SqlParameter("@transactiontype", t.transactiontype));
                sqlcmd.Parameters.Add(new SqlParameter("@transactionstatus", t.transactionstatus));
                sqldata = sqlcmd.ExecuteReader();
                sqlcmd.Parameters.Clear();
                sqldata.Close();

            }
            DBclose();


        }

        public List<DTOTran> viewtransaction(List<DTOTran> tranlist, int userid)
        {
            string sqlstring;
            if (userid == 0)
                sqlstring = "select transactionid,transactionlist.mediaid,medialist.medianame,transactionlist.userid, userlist.username,transactionlist.mediaqty,transactiondate,transactiontype,transactionstatus from transactionlist,medialist,userlist where transactionlist.mediaid = medialist.mediaid and transactionlist.userid = userlist.userid";
            else
                sqlstring = "select transactionid,transactionlist.mediaid,medialist.medianame,transactionlist.userid, userlist.username,transactionlist.mediaqty,transactiondate,transactiontype,transactionstatus from transactionlist,medialist,userlist where transactionlist.mediaid = medialist.mediaid and transactionlist.userid = userlist.userid and transactionstatus = 'P' and transactionlist.userid = " + userid;
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqldata = sqlcmd.ExecuteReader();
            while (sqldata.Read())
            {
                tranlist.Add(new DTOTran
                {
                    transactionid = Convert.ToInt32(sqldata[0]),
                    mediaid = Convert.ToInt32(sqldata[1]),
                    medianame = sqldata[2].ToString(),
                    userid = Convert.ToInt32(sqldata[3]),
                    username = sqldata[4].ToString(),
                    mediaqty = Convert.ToInt32(sqldata[5]),
                    transactiondate = Convert.ToDateTime(sqldata[6]),
                    transactiontype = sqldata[7].ToString(),
                    transactionstatus = sqldata[8].ToString(),

                }
                );

            }

            DBclose();
            return tranlist;
        }

        public int tranupdate(int userid)
        {
            string sqlstring = "tranupdate";
            int retval;
            SqlCommand sqlcmd;
            //SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlParameter returnparam;
            returnparam = new SqlParameter("@returnval", SqlDbType.Int);
            returnparam.Direction = ParameterDirection.Output;
            sqlcmd.Parameters.Add(new SqlParameter("@userid", userid));
            sqlcmd.Parameters.Add(returnparam);
            //sqldata = sqlcmd.ExecuteReader();
            sqlcmd.ExecuteNonQuery();
            retval = (int)sqlcmd.Parameters["@returnval"].Value;
            Console.WriteLine(retval);
            Console.WriteLine(userid);
            sqlcmd.Parameters.Clear();
            //sqldata.Close();
            DBclose();
            return retval;
        }



    }
}
