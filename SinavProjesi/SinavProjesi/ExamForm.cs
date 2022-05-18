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
using System.IO;

namespace SinavProjesi
{
    public partial class ExamForm : Form
    {
        Random random = new Random();
        DataSet ds;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True");
        public static DataTable dt;
        int studentsId,QuestionId,LessonId,UnitId,TrueOpt;
        string QuestionText, OptA, OptB, OptC, OptD;
        bool isFinish = false;
        int trueQuest, falseQuest, nullQuest; //doğru yanlış ve boş soru sayılarını tutacak
        public ExamForm()
        {
            InitializeComponent();
        }
        public ExamForm(int studentId) : this()
        {
            this.studentsId = studentId;
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            ControlExam();
            DeleteOldAnswer();
            for (int i = 1; i < 11; i++)
            {
                isFinish = true;
                GetPanelQuestion(i);//işaretlenen cevapları veritabanına göndermek için fonksiyon
            }
            MessageBox.Show("Exams has finished!");
            this.Hide();           
        }
        public void ControlExam()//buraya ekleme yapılacak sonuçları veritabanına atama 
        {
            
            using (SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True"))
            {
                ds = new DataSet();
                cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandText = "select *from CheckQuestionAnswer cq inner join Questions q on cq.QuestionId = q.QuestionId";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                int c = ds.Tables[0].Rows.Count;
                if (c == 0)
                {
                    con.Close();
                    return;
                }
                for (int i = 0; i < 10; i++)
                {
                    object[] dt = ds.Tables[0].Rows[i].ItemArray;
                    int CheckId = Convert.ToInt32(dt[0]);
                    int StudentId = Convert.ToInt32(dt[2]);
                    int StudentAnswer = Convert.ToInt32(dt[3]);
                    DateTime AnsweredTime = Convert.ToDateTime(dt[4]);
                    int TrueOpt = Convert.ToInt32(dt[13]);
                    if (StudentAnswer == TrueOpt) { trueQuest++; }
                    else if (StudentAnswer == 0) { nullQuest++; }
                    else { falseQuest++; }
                    CheckQuestion check = new CheckQuestion(CheckId,studentsId, AnsweredTime, trueQuest, falseQuest, nullQuest);
                    if (i == 9)
                    {
                        check.AddResult();
                    }
                    
                }
                con.Close();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            DeletePanelQuestions();
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
            studentsScreen.LeftPanel.Visible = false;

            GetQuestion();
        }
        int temp = 1;
        public void GetQuestion()
        {
            int c;
            int lastRow = 0;

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
                if (c == 0)
                {
                    con.Close();
                    return;
                }
                for (int x = 0; x < 10; x++)
                {
                    int row = random.Next(0, c);


                    object[] dt = ds.Tables[0].Rows[row].ItemArray;
                    QuestionId = Convert.ToInt32(dt[0]);
                    LessonId = Convert.ToInt32(dt[1]);
                    UnitId = Convert.ToInt32(dt[2]);
                    QuestionText = dt[3].ToString();
                    OptA = dt[4].ToString();
                    OptB = dt[5].ToString();
                    OptC = dt[6].ToString();
                    OptD = dt[7].ToString();
                    TrueOpt = Convert.ToInt32(dt[8]);

                    //Panel numaralarına özgü olarak soruları ve panel numaraları veritabanına atıyor.
                    using (SqlConnection conn = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True"))
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        var sql = "INSERT INTO PanelQuestion VALUES (@panelNumber,@questionId)";
                        using (var cmd = new SqlCommand(sql, conn))
                        {                           
                            cmd.Parameters.AddWithValue("@questionId", QuestionId);
                            cmd.Parameters.AddWithValue("@panelNumber", temp);
                            temp++;
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    Questions questions = new Questions(QuestionId, LessonId, UnitId, QuestionText, OptA, OptB, OptC, OptD, TrueOpt);
                    ConnectionControl();
                    con.Close();
                    lastRow = row;
                }
            }
        }
        private void ConnectionControl()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void DeleteOldAnswer()
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("delete from CheckQuestionAnswer where StudentId=" + studentsId + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeletePanelQuestions() //panellere çekilen soruları sınav bittiğinde veritabanından siler
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("delete from PanelQuestion",con);
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
                cmd.CommandText = "select *from PanelQuestion pq inner join Questions q on pq.QuestionId = q.QuestionId where pq.PanelNumber = '" + panelNumber + "'";
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
                TrueOpt = Convert.ToInt32(dt[10]);
                con.Close();
                lblA.Text = OptA;
                lblB.Text = OptB;
                lblC.Text = OptC;
                lblD.Text = OptD;
                txtQuestion.Text = QuestionText;
                if (isFinish == true)//sınav bittiyse fonksiyon çalışır
                {
                    //AnswerControl(panelNumber) fonksiyonu cevapları veritabanına aktarır
                    ds = new DataSet();
                    cmd = new SqlCommand();
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO CheckQuestionAnswer values(" + QuestionId + ","+studentsId+"," + AnswerControl(panelNumber) + ",GETDATE())";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void ViewPicture(int questionId)
        {
            try
            {
                string sql = "SELECT QuestionImage FROM Questions Where QuestionId='" + questionId + "'";
                ConnectionControl();
                cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
                    if (img == null)
                    {
                        pictureQuestionBox.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureQuestionBox.Image = Image.FromStream(ms);
                        
                    }
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Image Does not Exist!");
                }
            }
            catch 
            {
              MessageBox.Show("Error!");
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
            else if (panelNo == 2)
            {
                if (btnA2.Checked == true) { answer = 1; }
                else if (btnB2.Checked == true) { answer = 2; }
                else if (btnC2.Checked == true) { answer = 3; }
                else if (btnD2.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 3)
            {
                if (btnA3.Checked == true) { answer = 1; }
                else if (btnB3.Checked == true) { answer = 2; }
                else if (btnC3.Checked == true) { answer = 3; }
                else if (btnD3.Checked == true) { answer = 4; }
                else { answer = 0; }
            }
            else if (panelNo == 4)
            {
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
        int timer;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer = Convert.ToInt32(lblTime.Text);
            timer = timer - 1;
            lblTime.Text = timer.ToString();
            if(timer==0)
            {
                timer1.Enabled = false;
                ControlExam();
                DeleteOldAnswer();
                for (int i = 1; i < 11; i++)
                {
                    isFinish = true;
                    GetPanelQuestion(i);//işaretlenen cevapları veritabanına göndermek için fonksiyon
                }
                MessageBox.Show("Exams has finished!");
                this.Hide();

            }
        }
        private void pnl1_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "1";
            pnl1.BackColor = Color.Yellow;
            pnl2.BackColor = Color.NavajoWhite;
            pnl3.BackColor = Color.NavajoWhite;
            pnl4.BackColor = Color.NavajoWhite;
            pnl5.BackColor = Color.NavajoWhite;
            pnl6.BackColor = Color.NavajoWhite;
            pnl7.BackColor = Color.NavajoWhite;
            pnl8.BackColor = Color.NavajoWhite;
            pnl9.BackColor = Color.NavajoWhite;
            pnl10.BackColor = Color.NavajoWhite;
            GetPanelQuestion(1);
        }

        private void pnl2_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "2";
            pnl2.BackColor = Color.Yellow;
            pnl1.BackColor = Color.NavajoWhite;
            pnl3.BackColor = Color.NavajoWhite;
            pnl4.BackColor = Color.NavajoWhite;
            pnl5.BackColor = Color.NavajoWhite;
            pnl6.BackColor = Color.NavajoWhite;
            pnl7.BackColor = Color.NavajoWhite;
            pnl8.BackColor = Color.NavajoWhite;
            pnl9.BackColor = Color.NavajoWhite;
            pnl10.BackColor = Color.NavajoWhite;
            GetPanelQuestion(2);
        }

        private void pnl3_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "3";
            pnl3.BackColor = Color.Yellow;
            pnl2.BackColor = Color.NavajoWhite;
            pnl1.BackColor = Color.NavajoWhite;
            pnl4.BackColor = Color.NavajoWhite;
            pnl5.BackColor = Color.NavajoWhite;
            pnl6.BackColor = Color.NavajoWhite;
            pnl7.BackColor = Color.NavajoWhite;
            pnl8.BackColor = Color.NavajoWhite;
            pnl9.BackColor = Color.NavajoWhite;
            pnl10.BackColor = Color.NavajoWhite;
            GetPanelQuestion(3);
        }

        private void pnl4_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "4";
            pnl4.BackColor = Color.Yellow;
            pnl2.BackColor = Color.NavajoWhite;
            pnl3.BackColor = Color.NavajoWhite;
            pnl1.BackColor = Color.NavajoWhite;
            pnl5.BackColor = Color.NavajoWhite;
            pnl6.BackColor = Color.NavajoWhite;
            pnl7.BackColor = Color.NavajoWhite;
            pnl8.BackColor = Color.NavajoWhite;
            pnl9.BackColor = Color.NavajoWhite;
            pnl10.BackColor = Color.NavajoWhite;
            GetPanelQuestion(4);
        }

        private void pnl5_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "5";
            pnl5.BackColor = Color.Yellow;
            pnl2.BackColor = Color.NavajoWhite;
            pnl3.BackColor = Color.NavajoWhite;
            pnl4.BackColor = Color.NavajoWhite;
            pnl1.BackColor = Color.NavajoWhite;
            pnl6.BackColor = Color.NavajoWhite;
            pnl7.BackColor = Color.NavajoWhite;
            pnl8.BackColor = Color.NavajoWhite;
            pnl9.BackColor = Color.NavajoWhite;
            pnl10.BackColor = Color.NavajoWhite;
            GetPanelQuestion(5);
        }

        private void pnl6_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "6";
            pnl6.BackColor = Color.Yellow;
            pnl2.BackColor = Color.NavajoWhite;
            pnl3.BackColor = Color.NavajoWhite;
            pnl4.BackColor = Color.NavajoWhite;
            pnl5.BackColor = Color.NavajoWhite;
            pnl1.BackColor = Color.NavajoWhite;
            pnl7.BackColor = Color.NavajoWhite;
            pnl8.BackColor = Color.NavajoWhite;
            pnl9.BackColor = Color.NavajoWhite;
            pnl10.BackColor = Color.NavajoWhite;
            GetPanelQuestion(6);
        }

        private void pnl7_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "7";
            pnl7.BackColor = Color.Yellow;
            pnl2.BackColor = Color.NavajoWhite;
            pnl3.BackColor = Color.NavajoWhite;
            pnl4.BackColor = Color.NavajoWhite;
            pnl5.BackColor = Color.NavajoWhite;
            pnl6.BackColor = Color.NavajoWhite;
            pnl1.BackColor = Color.NavajoWhite;
            pnl8.BackColor = Color.NavajoWhite;
            pnl9.BackColor = Color.NavajoWhite;
            pnl10.BackColor = Color.NavajoWhite;
            GetPanelQuestion(7);
        }

        private void pnl8_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "8";
            pnl8.BackColor = Color.Yellow;
            pnl2.BackColor = Color.NavajoWhite;
            pnl3.BackColor = Color.NavajoWhite;
            pnl4.BackColor = Color.NavajoWhite;
            pnl5.BackColor = Color.NavajoWhite;
            pnl6.BackColor = Color.NavajoWhite;
            pnl7.BackColor = Color.NavajoWhite;
            pnl1.BackColor = Color.NavajoWhite;
            pnl9.BackColor = Color.NavajoWhite;
            pnl10.BackColor = Color.NavajoWhite;
            GetPanelQuestion(8);
        }

        private void pnl9_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "9";
            pnl9.BackColor = Color.Yellow;
            pnl2.BackColor = Color.NavajoWhite;
            pnl3.BackColor = Color.NavajoWhite;
            pnl4.BackColor = Color.NavajoWhite;
            pnl5.BackColor = Color.NavajoWhite;
            pnl6.BackColor = Color.NavajoWhite;
            pnl7.BackColor = Color.NavajoWhite;
            pnl8.BackColor = Color.NavajoWhite;
            pnl1.BackColor = Color.NavajoWhite;
            pnl10.BackColor = Color.NavajoWhite;
            GetPanelQuestion(9);
        }

        private void pnl10_MouseClick(object sender, MouseEventArgs e)
        {
            lblQuestionNumber.Text = "10";
            pnl10.BackColor = Color.Yellow;
            pnl2.BackColor = Color.NavajoWhite;
            pnl3.BackColor = Color.NavajoWhite;
            pnl4.BackColor = Color.NavajoWhite;
            pnl5.BackColor = Color.NavajoWhite;
            pnl6.BackColor = Color.NavajoWhite;
            pnl7.BackColor = Color.NavajoWhite;
            pnl8.BackColor = Color.NavajoWhite;
            pnl9.BackColor = Color.NavajoWhite;
            pnl1.BackColor = Color.NavajoWhite;
            GetPanelQuestion(10);
            GetPanelQuestion(10);
        }

    }
}
