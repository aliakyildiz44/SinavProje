using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavProjesi.Educator_UC
{
    public partial class UpdateQuestions_UC : UserControl
    {
        Function fn = new Function();
        String query;

        public UpdateQuestions_UC()
        {
            InitializeComponent();
        }

        private void UpdateQuestions_UC_Load(object sender, EventArgs e)
        {
            comboSet.Items.Clear();
            query = "select distinct LessonId from Questions";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboQuestionNo.Items.Clear();
            query = "select QuestionNo from Questions where LessonId = '" + comboSet.Text + "'";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboQuestionNo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboQuestionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select QuestionText,optA,optB,optC,optD,TrueOpt from Questions where LessonId = '" + comboSet.Text + "' and QuestionNo = '" + comboQuestionNo.Text + "'";
            DataSet ds = fn.GetData(query);
            txtQuestion.Text = ds.Tables[0].Rows[0][0].ToString();
            txtOption1.Text = ds.Tables[0].Rows[0][1].ToString();
            txtOption2.Text = ds.Tables[0].Rows[0][2].ToString();
            txtOption3.Text = ds.Tables[0].Rows[0][3].ToString();
            txtOption4.Text = ds.Tables[0].Rows[0][4].ToString();
            txtAnswer.Text = ds.Tables[0].Rows[0][5].ToString();
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            clearAll();
        }
        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
            comboSet.SelectedIndex = -1;
            comboQuestionNo.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboQuestionNo.SelectedIndex != -1)
            {
                String LessonId = comboSet.Text;
                String QuestionText = txtQuestion.Text;
                String OptA = txtOption1.Text;
                String OptB = txtOption2.Text;
                String OptC = txtOption3.Text;
                String OptD = txtOption4.Text;
                String TrueOpt = txtAnswer.Text;
                String QuestionNo = comboQuestionNo.Text;
                //Image QuestionImage = pictureBox1.Image;

                query = "update Questions set QuestionText ='"+QuestionText+ "',OptA ='" + OptA + "',OptB ='" +OptB + "',OptC ='" +OptC+ "',OptD ='" +OptD + "',TrueOpt ='" + TrueOpt + "' where LessonId = '"+LessonId+"' and QuestionNo = '"+QuestionNo+"'";
                fn.setData(query,"Question No : "+QuestionNo+" \n Lesson ID : "+LessonId+"\n is Updated.");

            }
            else
            {
                MessageBox.Show("Select Question First.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UpdateQuestions_UC_Load(this, null);
        }

        private void lblSet_Click(object sender, EventArgs e)
        {

        }
    }
}
