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
        DataSet ds;
        SqlCommand cmd;
        Function fn = new Function();
        String query;

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
        bool Gender;
        public void LoadData()
        {
            int StudentId;
            int UserId;
            
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int UserId = Convert.ToInt32(txtId.Text);
            String Province = txtProvince.Text;
            String District = txtDistrict.Text;
            int Grade = Convert.ToInt32(txtGrade.Text);
            int SchoolNumber = Convert.ToInt32(txtSchoolNumber.Text);
          

            query = "update Students set Gender ='" + Gender + "',Province ='" + Province + "',District ='" + District + "',Grade ='" + Grade + "',SchoolNumber ='" + SchoolNumber + "' where UserId = '" + UserId + "'";
            fn.setData(query, "SchoolNumber : " + SchoolNumber + "  is Updated.");
        }
    }
}
