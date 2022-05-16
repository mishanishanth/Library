using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using LbAssgLibrary;

namespace LibraryBusinessDB
{
    public class DBEngine
    {
        public string connectionstring;
        SqlConnection dbcon;
        public SqlConnection DBopen()
        {
            connectionstring = @"Data Source=LAPTOP-UDQPO2MH; Initial Catalog=librarydb; User ID=libadmin; Password=Misha4632#";
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

        public DTOUser autheticateuser(string usrname, string psswd)
        {
            DTOUser userinfo = new DTOUser();
            string sqlstring = "select username,psswd,firstname,lastname,lstatus,accountstatus,emailid,phoneno,streetaddress,city,pincode,rolename,userid from userlist, rolelist where rolelist.roleid=userlist.roleid and userlist.username='" + usrname + "' and psswd='" + psswd + "'";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
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

        public void insertuserdata(DTOUser u)
        {
            string sqlstring = "userinsert";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            int rolenametoid = 0;
            int returnresult;
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
                DBclose();

        }
        public List<DTOUser> viewuserdata(string username)
        {
            List<DTOUser> userlist = new List<DTOUser>();
            string sqlstring;
            if (username == String.Empty)
                sqlstring = "select username,psswd,firstname,lastname,lstatus,accountstatus,emailid,phoneno,streetaddress,city,pincode,rolename,userid from userlist, rolelist where rolelist.roleid=userlist.roleid";
            else
                sqlstring = "select username,psswd,firstname,lastname,lstatus,accountstatus,emailid,phoneno,streetaddress,city,pincode,rolename,userid from userlist, rolelist where rolelist.roleid=userlist.roleid and userlist.username='" + username + "'";
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
                    role = sqldata[11].ToString(),
                    userid=Convert.ToInt32(sqldata[12])
                }
                );

            }
            // foreach (var i in userlist)
            //  Console.WriteLine(i.username);
            DBclose();
            return userlist;
        }

        public DTOUser viewuserdata(int userid)
        {
            DTOUser userlist = new DTOUser();
            string sqlstring;
            if (userid > 0)
            {
                sqlstring = "select username,psswd,firstname,lastname,lstatus,accountstatus,emailid,phoneno,streetaddress,city,pincode,rolename,userid from userlist, rolelist where rolelist.roleid=userlist.roleid and userlist.userid=" + userid;
                SqlCommand sqlcmd;
                SqlDataReader sqldata;
                sqlcmd = new SqlCommand(sqlstring, DBopen());
                sqldata = sqlcmd.ExecuteReader();
                while (sqldata.Read())
                {
                    userlist=(new DTOUser
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
                        role = sqldata[11].ToString(),
                        userid = Convert.ToInt32(sqldata[12])
                    }
                    );

                }
                // foreach (var i in userlist)
                //  Console.WriteLine(i.username);
                DBclose();
            }
            return userlist;
        }

        public int EditUser(DTOUser u)
        {
            string sqlstring = "bsuserupdate";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlParameter returnparam;
            returnparam = new SqlParameter("@returnval", SqlDbType.Int);
            returnparam.Direction = ParameterDirection.Output;
            int retval = 0;
            sqlcmd.Parameters.Add(new SqlParameter("@usrname", u.username));
            sqlcmd.Parameters.Add(new SqlParameter("@lastname", u.lastname));
            sqlcmd.Parameters.Add(new SqlParameter("@emailid", u.emailid));
            sqlcmd.Parameters.Add(new SqlParameter("@streetaddress", u.streetaddress));
            sqlcmd.Parameters.Add(new SqlParameter("@city", u.city));
            sqlcmd.Parameters.Add(new SqlParameter("@pincode", u.pincode));
            sqlcmd.Parameters.Add(new SqlParameter("@phoneno", u.phoneno));
            sqlcmd.Parameters.Add(new SqlParameter("@userid", u.userid));
            sqlcmd.Parameters.Add(new SqlParameter("@rolename", u.role));
            sqlcmd.Parameters.Add(new SqlParameter("@accountstatus", u.accountstatus));
            sqlcmd.Parameters.Add(returnparam);
            sqldata = sqlcmd.ExecuteReader();
            retval = (int)sqlcmd.Parameters["@returnval"].Value;
            sqlcmd.Parameters.Clear();
            sqldata.Close();

            DBclose();
            return retval;
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
                //Console.WriteLine("Role list from Database Failed" + ex.Errors);
            }


            return roles;

        }

        public int getroleid(string rolename)
        {
            int roleid;
            string sqlstring = "select roleid from rolelist where rolename='" + rolename + "'";
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
        public List<DTOMedia> viewmediadata(List<DTOMedia> medialist, string medianame)
        {
            string sqlstring;
            if (medianame == String.Empty)
                sqlstring = "select mediaid,medianame,mediatype,mediagenre,mediaauthor,numberofcopies from medialist";
            else
                sqlstring = "select mediaid,medianame,mediatype,mediagenre,mediaauthor,numberofcopies from medialist where medianame like '%" + medianame + "%'";
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

        public void mediainsert(DTOMedia medialist)
        {
            string sqlstring = "mediainsert";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@medianame", medialist.medianame));
                sqlcmd.Parameters.Add(new SqlParameter("@mediatype", medialist.mediatype));
                sqlcmd.Parameters.Add(new SqlParameter("@mediagenre", medialist.mediagenre));
                sqlcmd.Parameters.Add(new SqlParameter("@mediaauthor", medialist.mediaauthor));
                sqlcmd.Parameters.Add(new SqlParameter("@numberofcopies", medialist.numberofcopies));
                sqldata = sqlcmd.ExecuteReader();
                sqlcmd.Parameters.Clear();
                sqldata.Close();
                DBclose();

        }

        public DTOMedia viewmediadata(int mediaid)
        {
            string sqlstring;
            DTOMedia media = new DTOMedia();
            if (mediaid > 0)
            {
                sqlstring = "select mediaid,medianame,mediatype,mediagenre,mediaauthor,numberofcopies from medialist where mediaid=" + mediaid;
                SqlCommand sqlcmd;
                SqlDataReader sqldata;
                sqlcmd = new SqlCommand(sqlstring, DBopen());
                sqldata = sqlcmd.ExecuteReader();
                while (sqldata.Read())
                {

                    media.mediaid = Convert.ToInt32(sqldata[0]);
                    media.medianame = sqldata[1].ToString();
                    media.mediatype = sqldata[2].ToString();
                    media.mediagenre = sqldata[3].ToString();
                    media.mediaauthor = sqldata[4].ToString();
                    media.numberofcopies = Convert.ToInt32(sqldata[5]);
                  }

                DBclose();
            }
         
       
            return media;
        }

        public void inserttransaction(DTOTran tranlist)
        {
            string sqlstring = "traninsert";
            SqlCommand sqlcmd;
            SqlDataReader sqldata;
            sqlcmd = new SqlCommand(sqlstring, DBopen());
            sqlcmd.CommandType = CommandType.StoredProcedure;
                 sqlcmd.Parameters.Add(new SqlParameter("@mediaid", tranlist.mediaid));
                sqlcmd.Parameters.Add(new SqlParameter("@userid", tranlist.userid));
                sqlcmd.Parameters.Add(new SqlParameter("@mediaqty", tranlist.mediaqty));
                sqlcmd.Parameters.Add(new SqlParameter("@transactiontype", tranlist.transactiontype));
                sqlcmd.Parameters.Add(new SqlParameter("@transactionstatus", tranlist.transactionstatus));
                sqldata = sqlcmd.ExecuteReader();
                sqlcmd.Parameters.Clear();
                sqldata.Close();

            DBclose();


        }

        public List<DTOTran> viewtransaction(int userid)
        {
            List<DTOTran> tranlist=new List<DTOTran>();
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

    }
}
