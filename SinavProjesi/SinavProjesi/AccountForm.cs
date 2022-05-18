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
    public partial class AccountForm : Form
    {
        User student;
     //   Students students;
        DataSet ds;
        SqlCommand cmd;
        public static DataTable dt;
        public AccountForm()
        {
            InitializeComponent();
        }
        public AccountForm(User student) : this()
        {
            this.student = student;
            txtId.Text = student.UserId.ToString();
            txtUsername.Text = student.UserName;
            txtName.Text = student.Name;
            txtSurname.Text = student.Surname;
            txtEmail.Text = student.Email;
            txtPassword.Text = student.Password;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            int StudentId;
            int UserId;
            bool Gender;
            DateTime Birthday;
            string Province;
            string District;
            int Grade;
            int SchoolNumber;
            int c;
            UserId = student.UserId;
            using (SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True"))
            {
                ds = new DataSet();
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Students where UserId='" + student.UserId + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                c = ds.Tables[0].Rows.Count;
                if (c == 0)
                {
                    con.Close();
                    return;
                }
                object[] dt = ds.Tables[0].Rows[0].ItemArray;
                StudentId = Convert.ToInt32(dt[0]);
                Gender = Convert.ToBoolean(dt[2]);
                Birthday = Convert.ToDateTime(dt[3]);
                Province = dt[4].ToString();
                District = dt[5].ToString();
                Grade = Convert.ToInt32(dt[6]);
                SchoolNumber = Convert.ToInt32(dt[7]);
                con.Close();
                if (Gender == true)
                {
                    cmbGender.Text = "Man";
                }
                else { cmbGender.Text = "Woman"; }
                txtProvince.Text = Province;
                txtDistrict.Text = District;
                txtGrade.Text = Grade.ToString();
                txtSchoolNumber.Text = SchoolNumber.ToString();

            }
        }
    }
}
