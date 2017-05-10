using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DA;

namespace DA
{
    public class DataAccess
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataTable dt;

        public DataAccess()
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            adp = new SqlDataAdapter();
            cmd.Connection = con;
            adp.SelectCommand = cmd;
        }

        public void connect()
        {
            con.ConnectionString = "Data Source=.; initial catalog=db3layer; integrated security=true";
            con.Open();
        }

        public void disconnect()
        {
            con.Close();
        }

        public DataTable select(string query)
        {
            cmd.CommandText = query;
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public void docommand(string query)
        {
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
    }
}
