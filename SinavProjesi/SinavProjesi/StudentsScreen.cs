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
    public partial class StudentsScreen : Form
    {
        User student;
        public StudentsScreen()
        {
            InitializeComponent();
        }
        int StudentId;
        public StudentsScreen(User student) : this()
        {
            this.student = student;
           lblUserName.Text= student.Name;
            StudentId = student.UserId;
        }
       
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            loadForm(new ExamForm(StudentId));
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            loadForm(new AccountForm(student));
        }
        private void StudentsScreen_Load(object sender, EventArgs e)
        {
        
        }
    }
}
