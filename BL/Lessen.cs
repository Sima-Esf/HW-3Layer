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
    public class Lessen:DataAccess
    {
        public int lid;

        public void insert()
        {
            base.connect();
            string query = "insert into TLessen1(lid) values('{0}')";
            query = string.Format(query, lid);
            base.docommand(query);
            base.disconnect();
        }

        public void delete()
        {
            base.connect();
            string query = "delete from TLessen1 where lid={0}";
            query = string.Format(query, lid);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from TLessen1";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }

        public DataTable selectone()
        {
            base.connect();
            string query = "select * from TLessen1 where lid={0}";
            query = string.Format(query, lid);
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
