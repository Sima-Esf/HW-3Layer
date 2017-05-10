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
    public class Student : DataAccess
    {
        public int stid;
        public string stname;
        public string stfamily;
        public string staddress;
        public int sttell;
        public string stgender;
        public int fid;

        public void insert()
        {
            base.connect();
            string query = "insert into TStudent1(stid, stname, stfamily, staddress, sttell, stgender, fid) values('{0}', N'{1}', N'{2}', N'{3}', '{4}', N'{5}', '{6}')";
            query = string.Format(query,stid, stname, stfamily, staddress, sttell, stgender, fid);
            base.docommand(query);
            base.disconnect();
        }

        public void delete()
        {
            base.connect();
            string query = "delete from TStudent1 where stid={0}";
            query = string.Format(query, stid);
            base.docommand(query);
            base.disconnect();
        }

        public void update()
        {
            base.connect();
            string query = "update TStudent1 SET stname=N'{0}', stfamily=N'{1}', staddress=N'{2}', sttell='{3}', stgender=N'{4}', fid='{5}' where stid='{6}'";
            query = string.Format(query, stname, stfamily, staddress, sttell, stgender, fid, stid);
            base.docommand(query);
            base.disconnect();
        }

        public DataTable select()
        {
            base.connect();
            string query = "select * from TStudent1";
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }

        public DataTable selectone()
        {
            base.connect();
            string query = "select * from TStudent1 where stid={0}";
            query = string.Format(query, stid);
            DataTable dt = base.select(query);
            base.disconnect();
            return dt;
        }
    }
}
