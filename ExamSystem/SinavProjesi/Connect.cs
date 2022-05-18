using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SinavProjesi
{
    internal class Connect
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True");
    }
}
