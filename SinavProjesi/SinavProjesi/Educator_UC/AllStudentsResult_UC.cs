using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SinavProjesi.Educator_UC
{
    public partial class AllStudentsResult_UC : UserControl
    {
        public AllStudentsResult_UC()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True");
        void LoadResult()
        {
            try
            {
                string Myquery = "Select * from Results";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgwStudentResult.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

                MessageBox.Show("Error!");
            }
        }

        private void AllStudentsResult_UC_Load(object sender, EventArgs e)
        {
            LoadResult();
        }
    }
}
