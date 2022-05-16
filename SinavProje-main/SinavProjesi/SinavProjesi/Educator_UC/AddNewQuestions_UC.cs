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
    public partial class AddNewQuestions_UC : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        Int64 questionNo = 1;

        public AddNewQuestions_UC()
        {
            InitializeComponent();
        }
       

        private void AddNewQuestions_UC_Load(object sender, EventArgs e)
        {
            query = "select max(QuestionID) from Questions";
            ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString()!="")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtSet.Text = (id + 1).ToString();
            }
            else
            {
                txtSet.Text = "1";
            }
            lblQuestion.Text = questionNo.ToString();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String LessonId = txtSet.Text;
            String QuestionText = txtQuestion.Text;
            String OptA = txtOption1.Text;
            String OptB = txtOption2.Text;
            String OptC = txtOption3.Text;
            String OptD = txtOption4.Text;
            String TrueOpt = txtAnswer.Text; 
            String QuestionNo = questionNo.ToString();
            Image QuestionImage = pictureBox1.Image;
            //DateTime AddedDate = DateTime.Now;
            //AddedDate.ToString("dddd, dd MMMM yyyy");

            query = "insert into Questions (LessonId,QuestionText,OptA,OptB,OptC,OptD,TrueOpt,QuestionNo,QuestionImage) values ('" + LessonId + "','" + QuestionText + "','" + OptA + "','" + OptB + "','" + OptC + "','" + OptD + "','" + TrueOpt + "','" + QuestionNo + "','" + QuestionImage + "')";
            fn.setData(query, "Question Added");
            clearAll();
            questionNo++;
            lblQuestion.Text = questionNo.ToString();
        }
        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will be Lost","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)

            {
                clearAll();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Set will be changed.","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                txtSet.Text = (Int64.Parse(txtSet.Text.ToString()) + 1).ToString();
                lblQuestion.Text = "1";

            }
        }

        private void txtSet_TextChanged(object sender, EventArgs e)
        {
            if (txtSet.Text!="")
            {
                clearAll();
                query = "select QuestionNo from Questions where LessonId = '" + txtSet.Text + "'";
                ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0].ToString() != "") 
                {
                    lblQuestion.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Int64.Parse(lblQuestion.Text.ToString());
                }
                else
                {
                    lblQuestion.Text = "1";
                    questionNo = Int64.Parse(lblQuestion.Text.ToString());

                }
            }
        }
    }
}
