using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace SinavProjesi
{
   public class Crud
    {
        static DataTable dt;
        public static DataTable List(string sql)
        {
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, Connect.con);
            da.Fill(dt);
            return dt;
        }
    }
}
