using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DA;
using BL;

namespace BL
{
    public class Login : DataAccess
    {
        public static bool lup1 = false;
        public static bool lup2 = false;
        public static bool lup3 = false;
        public static bool lup4 = false;

        public void permission(string luser)
        {
            base.connect();
            string query = "select * from TLogin where luser='{0}'";
            query = string.Format(query, luser);
            DataTable dt = base.select(query);
            lup1 = Convert.ToBoolean(dt.Rows[0]["lup1"].ToString());
            lup2 = Convert.ToBoolean(dt.Rows[0]["lup2"].ToString());
            lup3 = Convert.ToBoolean(dt.Rows[0]["lup3"].ToString());
            lup4 = Convert.ToBoolean(dt.Rows[0]["lup4"].ToString());
            base.disconnect();
        }

        public bool login(string luser, string lpass)
        {
            base.connect();
            string query = "select count(*) from TLogin where luser='{0}' AND lpass='{1}'";
            query = string.Format(query, luser, lpass);
            DataTable dt = base.select(query);
            base.disconnect();

            bool enter = false;
            if (dt.Rows[0][0].ToString() == "1")
                enter = true;
            return enter;


        }
    }
}
