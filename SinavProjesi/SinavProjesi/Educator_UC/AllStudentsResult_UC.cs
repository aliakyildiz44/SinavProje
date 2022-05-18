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
        Function fn = new Function();
        String query;
        public AllStudentsResult_UC()
        {
            InitializeComponent();
        }
        

        private void AllStudentsResult_UC_Load(object sender, EventArgs e)
        {
            comboSet.Items.Clear();
            comboSet.Items.Add("All Students");
            query = "select distinct StudentId from Results";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSet.SelectedIndex != 0)
            {
                query = "select ResultId,QuestionId,StudentId,UnitId,LessonId from Results where StudentId = '" + comboSet.Text + "'";
                DataSet ds = fn.GetData(query);
                dgwStudentResult.DataSource = ds.Tables[0];

            }
            else
            {
                query = "select ResultId,QuestionId,StudentId,UnitId,LessonId  from Results";
                DataSet ds = fn.GetData(query);
                dgwStudentResult.DataSource = ds.Tables[0];
            }
        }
    }
}
