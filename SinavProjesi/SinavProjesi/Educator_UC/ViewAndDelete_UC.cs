using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavProjesi.Educator_UC
{
    public partial class ViewAndDelete_UC : UserControl
    {
        Function fn = new Function();
        String query;

        public ViewAndDelete_UC()
        {
            InitializeComponent();
        }

        private void ViewAndDelete_UC_Load(object sender, EventArgs e)
        {
            comboSet.Items.Clear();
            comboSet.Items.Add("All Questions");
            query = "select distinct LessonId from Questions";
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
                query = "select QuestionId,QuestionText,OptA,OptB,OptC,OptD,TrueOpt,QuestionNo from Questions where LessonId = '" + comboSet.Text + "'";
                DataSet ds = fn.GetData(query);
                dgwViewDelete.DataSource = ds.Tables[0];

            }
            else
            {
                query = "select QuestionId,QuestionText,OptA,OptB,OptC,OptD,TrueOpt,QuestionNo from Questions";
                DataSet ds = fn.GetData(query);
                dgwViewDelete.DataSource = ds.Tables[0];
            }
        }
        int id, QuestionNo;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dgwViewDelete.Rows[e.RowIndex].Cells["QuestionId"].Value.ToString());
                QuestionNo = int.Parse(dgwViewDelete.Rows[e.RowIndex].Cells["QuestionNo"].Value.ToString());
            }
            catch
            {

            }
        }    
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from Questions where QuestionId = " + id + "";
                fn.setData(query, "Question Deleated");
                ViewAndDelete_UC_Load(this, null);
            }
        }
    }
}
