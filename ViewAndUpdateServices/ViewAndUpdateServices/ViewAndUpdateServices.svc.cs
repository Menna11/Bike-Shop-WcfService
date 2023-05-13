using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ViewAndUpdateServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ViewAndUpdateServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ViewAndUpdateServices.svc or ViewAndUpdateServices.svc.cs at the Solution Explorer and start debugging.
    public class ViewAndUpdateServices : IViewAndUpdateServices
    {
        public void DoWork()
        {
        }

        string IViewAndUpdateServices.viewAddress(int id)
        {
            string add="";

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select address from [user] where userId=@x", con);
            SqlParameter p1 = new SqlParameter("@x", id);
            cmd.Parameters.Add(p1);
            SqlDataReader s=cmd.ExecuteReader();
            if (s.HasRows)
            {
                while (s.Read())
                {
                    add = s.GetString(0);
                }
                
            }
            else
            {
                add = "none";
            }
            con.Close();
            return add;
        }

        string IViewAndUpdateServices.viewCreditNumber(int id)
        {
            string creditNum="";

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select credit_number from [user] where userId=@x", con);
            SqlParameter p1 = new SqlParameter("@x", id);
            cmd.Parameters.Add(p1);
            SqlDataReader s = cmd.ExecuteReader();
            if (s.HasRows)
            {
                while (s.Read())
                {
                    creditNum = s.GetString(0);
                }

            }
            else
            {
                creditNum ="";
            }
            con.Close();
            return creditNum;
        }

        string IViewAndUpdateServices.viewCreditPassword(int id)
        {
            string creditPass = "";

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select credit_password from [user] where userId=@x", con);
            SqlParameter p1 = new SqlParameter("@x", id);
            cmd.Parameters.Add(p1);
            SqlDataReader s = cmd.ExecuteReader();
            if (s.HasRows)
            {
                while (s.Read())
                {
                    creditPass = s.GetString(0);
                }

            }
            else
            {
                creditPass = "";
            }
            con.Close();
            return creditPass;
        }

        string IViewAndUpdateServices.viewEmail(int id)
        {
            string email = "";

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select email from [user] where userId=@x", con);
            SqlParameter p1 = new SqlParameter("@x", id);
            cmd.Parameters.Add(p1);
            SqlDataReader s = cmd.ExecuteReader();
            if (s.HasRows)
            {
                while (s.Read())
                {
                    email = s.GetString(0);
                }

            }
            else
            {
                email = "none";
            }
            con.Close();
            return email;
        }

        string IViewAndUpdateServices.viewMobileNumber(int id)
        {
            string mobile = "";

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select mobile_number from [user] where userId=@x", con);
            SqlParameter p1 = new SqlParameter("@x", id);
            cmd.Parameters.Add(p1);
            SqlDataReader s = cmd.ExecuteReader();
            if (s.HasRows)
            {
                while (s.Read())
                {
                    mobile = s.GetString(0);
                }

            }
            else
            {
                mobile = "none";
            }
            con.Close();
            return mobile;
        }

        string IViewAndUpdateServices.viewName(int id)
        {
            string name = "";

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select name from [user] where userId=@x", con);
            SqlParameter p1 = new SqlParameter("@x", id);
            cmd.Parameters.Add(p1);
            SqlDataReader s = cmd.ExecuteReader();
            if (s.HasRows)
            {
                while (s.Read())
                {
                    name = s.GetString(0);
                }

            }
            else
            {
                name = "none";
            }
            con.Close();
            return name;
        }

        string IViewAndUpdateServices.viewPassword(int id)
        {
            string pass = "";

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select password from [user] where userId=@x", con);
            SqlParameter p1 = new SqlParameter("@x", id);
            cmd.Parameters.Add(p1);
            SqlDataReader s = cmd.ExecuteReader();
            if (s.HasRows)
            {
                while (s.Read())
                {
                    pass = s.GetString(0);
                }

            }
            else
            {
                pass = "none";
            }
            con.Close();
            return pass;
        }

        string IViewAndUpdateServices.viewUserName(int id)
        {
            string username = "";

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select username from [user] where userId=@x", con);
            SqlParameter p1 = new SqlParameter("@x", id);
            cmd.Parameters.Add(p1);
            SqlDataReader s = cmd.ExecuteReader();
            if (s.HasRows)
            {
                while (s.Read())
                {
                    username = s.GetString(0);
                }

            }
            else
            {
                username = "none";
            }
            con.Close();
            return username;
        }
    }
}
