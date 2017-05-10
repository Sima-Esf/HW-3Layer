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
    public class Choice:DataAccess
    {
        public int cid;
        public int fid;
        public string cnamelessen;
        public string cnameteacher;
        public string cdate;

        public void insert()
        {
            base.connect();
            string query = "insert into TChoice1(cid, fid, cnamelessen, cnameteacher, cdate) values('{0}', '{1}', N'{2}', N'{3}', N'{4}')";
            query = string.Format(query, cid, fid, cnamelessen, cnameteacher, cdate);
            base.docommand(query);
            base.disconnect();
        }

        public void delete()
        {
            base.connect();
            string query = "delete from TChoice1 where cid={0}";
            query = string.Format(query, cid);
            base.docommand(query);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string query = "update TChoice1 SET fid='{0}', cnamelessen=N'{1}', cnameteacher=N'{2}', cdate='{3}' where cid='{4}'";
            query = string.Format(query, fid, cnamelessen, cnameteacher, cdate, cid);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from TChoice1";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }

        public DataTable selectone()
        {
            base.connect();
            string query = "select * from TChoice1 where cid={0}";
            query = string.Format(query, cid);
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
