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

namespace SinavProjesi
{
    public partial class ExamForm : Form
    {
        Random random = new Random();
        DataSet ds;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True");
        public static DataTable dt;
        int studentsId;
        public ExamForm()
        {
            InitializeComponent();
        }
        public ExamForm(int studentId) : this()
        {
            this.studentsId= studentId;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            pnlAnswer.Visible = true;
            pnlOption.Visible = true;
            pnlQuestion.Visible = true;
            pnlPicture.Visible = true;
            lblTime.Visible = true;
            label55.Visible = true;
            StudentsScreen studentsScreen = new StudentsScreen();
            studentsScreen.btnAccount.Enabled = false;
            studentsScreen.btnExam.Enabled = false;
            studentsScreen.guna2GradientPanel1.Visible = false;
           
            GetQuestion();

        }
        int QuestionId;
        int LessonId;
        int UnitId;
        string QuestionText, OptA, OptB, OptC, OptD, TrueOpt;
        bool isFinish = false;
        public void GetQuestion()
        {
        
            //DateTime AddedTime, AnsweredTime;
            //Image image;
            int c,temp;//temp random oluşturulan sayıyı geçici tutar ayn olup olmaması kontrolü için
            int lastRow=0;
            
            using (SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True"))
            {
                ds = new DataSet();
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd = con.CreateCommand();
                cmd.CommandText = "Select *from Questions";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                c = ds.Tables[0].Rows.Count;
                if (c == 0) { con.Close();
                    return;
                }
                for (int x = 0; x < 3; x++)
                {
                   int row=random.Next(0,c);
                   

                    object[] dt = ds.Tables[0].Rows[row].ItemArray;
                    QuestionId = Convert.ToInt32(dt[0]);
                    LessonId = Convert.ToInt32(dt[1]);
                    UnitId = Convert.ToInt32(dt[2]);
                    QuestionText = dt[3].ToString();
                    OptA = dt[4].ToString();
                    OptB = dt[5].ToString();
                    OptC = dt[6].ToString();
                    OptD = dt[7].ToString();
                    TrueOpt = dt[8].ToString();
                    //AddedTime = Convert.ToDateTime(dt[8]);
                    //AnsweredTime = Convert.ToDateTime(dt[9]);
                    //Panel numaralarına özgü olarak soruları ve panel numaraları veritabanına atıyor.
                    using (var connection = new SqlConnection(@"Data Source = TALHAGERGIN; Initial Catalog = ExamApplication; Integrated Security = True"))
                    {
                        if(connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        var sql = "INSERT INTO PanelQuestion VALUES (@questionId)";
                        using (var cmd = new SqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@questionId", QuestionId);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    Questions questions = new Questions(QuestionId, LessonId, UnitId, QuestionText, OptA, OptB, OptC, OptD, TrueOpt);
                    //panelChangeched(questions);//x panel numarası
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    con.Close();
                    lastRow = row;
                  
                }
              
            }
        }
        /*
        public  void  panelChangeched(Questions questions) //soru tipi, soru numarası ve panel numarası tipinde değişkenler alır
        {
            this.questions = questions;
            lblQuestionNumber.Text = questions.QuestionId.ToString();
            tbxQuestionText.Text = questions.QuestionText;
            lblA.Text = questions.OptA;
            lblB.Text = questions.OptB;
            lblC.Text = questions.OptC;
            lblD.Text = questions.OptD;
           
        
        }*/
        private void ConnectionControl()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void pnl3_MouseClick(object sender, MouseEventArgs e)
        {
            GetPanelQuestion(3);
            MessageBox.Show("3");
        }

        private void pnlAnswer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DeleteOldAnswer();
            for (int i = 1; i < 10; i++) {
                isFinish = true;
                GetPanelQuestion(i);//işaretlenen cevapları veritabanına göndermek için fonksiyon
                }
            MessageBox.Show("Exams has finished!");
            ControlExam();
        }
        public void ControlExam()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True"))
            {
                ConnectionControl();
                SqlCommand cmd = new SqlCommand("");
            }
            }
        public void  DeleteOldAnswer()
        {
            ConnectionControl();
           
            SqlCommand cmd = new SqlCommand("delete from CheckQuestionAnswer where StudentId=" + studentsId + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void GetPanelQuestion(int panelNumber)
        {
           
            using (SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True"))
            {
                ConnectionControl();

                ds = new DataSet();
                cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandText = "select *from PanelQuestion pq inner join Questions q on pq.QuestionId = q.QuestionId where pq.PanelNumber = '"+panelNumber+"'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                int c = ds.Tables[0].Rows.Count;
                if (c == 0)
                {
                    con.Close();
                    return;
                }

                object[] dt = ds.Tables[0].Rows[0].ItemArray;
                QuestionId = Convert.ToInt32(dt[1]);
                LessonId = Convert.ToInt32(dt[3]);
                UnitId = Convert.ToInt32(dt[4]);
                QuestionText = dt[5].ToString();
                OptA = dt[6].ToString();
                OptB = dt[7].ToString();
                OptC = dt[8].ToString();
                OptD = dt[9].ToString();
                TrueOpt = dt[10].ToString();
                con.Close();
               // Questions questions = new Questions(QuestionId, LessonId, UnitId, QuestionText, OptA, OptB, OptC, OptD, TrueOpt);
               // panelChangeched(questions);
               tbxQuestionText.Text=QuestionText;
                lblA.Text = OptA;
                lblB.Text = OptB;
                lblC.Text = OptC;
                lblD.Text = OptD;
                lblQuestionNumber.Text = QuestionId.ToString();
                if (isFinish == true)
                {
                    //AnswerControl(panelNumber) fonksiyonu cevapları veritabanına aktarır
                    ds = new DataSet();
                    cmd = new SqlCommand();
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO CheckQuestionAnswer values(" + QuestionId + "," + studentsId + "," + AnswerControl(panelNumber) + ")";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public int AnswerControl(int panelNo)
        {
            int answer = 0;//radio buttonlardaki cevapları tutar
            if (panelNo == 1)
            {
                if (btnA1.Checked == true) { answer = 1; }
                else if (btnB1.Checked == true) { answer = 2; }
                else if (btnC1.Checked == true) { answer = 3; }
                else if (btnD1.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 2) {
                if (btnA2.Checked == true) { answer = 1; }
                else if (btnB2.Checked == true) { answer = 2; }
                else if (btnC2.Checked == true) { answer = 3; }
                else if (btnD2.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 3) {
                if (btnA3.Checked == true) { answer = 1; }
                else if (btnB3.Checked == true) { answer = 2; }
                else if (btnC3.Checked == true) { answer = 3; }
                else if (btnD3.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 4) {
                if (btnA4.Checked == true) { answer = 1; }
                else if (btnB4.Checked == true) { answer = 2; }
                else if (btnC4.Checked == true) { answer = 3; }
                else if (btnD4.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 5)
            {
                if (btnA5.Checked == true) { answer = 1; }
                else if (btnB5.Checked == true) { answer = 2; }
                else if (btnC5.Checked == true) { answer = 3; }
                else if (btnD5.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 6)
            {
                if (btnA6.Checked == true) { answer = 1; }
                else if (btnB6.Checked == true) { answer = 2; }
                else if (btnC6.Checked == true) { answer = 3; }
                else if (btnD6.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 7)
            {
                if (btnA7.Checked == true) { answer = 1; }
                else if (btnB7.Checked == true) { answer = 2; }
                else if (btnC7.Checked == true) { answer = 3; }
                else if (btnD7.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 8)
            {
                if (btnA8.Checked == true) { answer = 1; }
                else if (btnB8.Checked == true) { answer = 2; }
                else if (btnC8.Checked == true) { answer = 3; }
                else if (btnD8.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 9)
            {
                if (btnA9.Checked == true) { answer = 1; }
                else if (btnB9.Checked == true) { answer = 2; }
                else if (btnC9.Checked == true) { answer = 3; }
                else if (btnD9.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 10)
            {
                if (btnA10.Checked == true) { answer = 1; }
                else if (btnB10.Checked == true) { answer = 2; }
                else if (btnC10.Checked == true) { answer = 3; }
                else if (btnD10.Checked == true) { answer = 4; }
                else { answer = 0; }
            }

            return answer;
        }
        private void pnlPicture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnl1_MouseClick(object sender, MouseEventArgs e)
        {

            GetPanelQuestion(1);
            MessageBox.Show("1");
        }

        private void pnl2_MouseClick(object sender, MouseEventArgs e)
        {
            GetPanelQuestion(2);
            MessageBox.Show("2");
        }
    }
}
