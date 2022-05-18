using System;
using System.Data;
using System.Data.SqlClient;
namespace SinavProjesi
{
    internal class CheckQuestion
    {
        SqlCommand cmd;
        DataSet ds;
        SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True");
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public DateTime AnsweredTime { get; set; }
        public int TrueQuestNumber { get; set; }
        public int FalseQuestNumber { get; set; }
        public int NullQuestNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public CheckQuestion(int CheckId, int StudentId, DateTime AnsweredTime, int trueQuest, int falseQuest, int nullQuest)
        {
            this.ExamId = CheckId;
            this.StudentId = StudentId;
            this.AnsweredTime = AnsweredTime;
            this.TrueQuestNumber = trueQuest;
            this.FalseQuestNumber = falseQuest;
            this.NullQuestNumber = nullQuest;
        }
        public void AddResult()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            ds = new DataSet();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd = con.CreateCommand();
            cmd.CommandText = "select *from Students s inner join Users u on s.UserId=u.UserId where s.StudentId='" + StudentId + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            object[] dt = ds.Tables[0].Rows[0].ItemArray;
            StudentName = dt[10].ToString();
            StudentSurname = dt[11].ToString();
            var sql = "INSERT INTO Results VALUES (@examId,@studentId,@studentName,@studentSurname,@trueQuestNumber,@falseQuestNumber,@nullQuestNumber,GETDATE())";
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@examId", ExamId);
                cmd.Parameters.AddWithValue("@studentId",StudentId );
                cmd.Parameters.AddWithValue("@studentName", StudentName);
                cmd.Parameters.AddWithValue("@studentSurname", StudentSurname);
                cmd.Parameters.AddWithValue("@trueQuestNumber", TrueQuestNumber);
                cmd.Parameters.AddWithValue("@falseQuestNumber", FalseQuestNumber);
                cmd.Parameters.AddWithValue("@nullQuestNumber", NullQuestNumber);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        }
    }
