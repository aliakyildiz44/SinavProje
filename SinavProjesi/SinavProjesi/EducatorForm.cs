using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavProjesi
{
    public partial class EducatorForm : Form
    {
        public EducatorForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EducatorForm_Load(object sender, EventArgs e)
        {
            addNewQuestions_UC1.Visible = false;
            updateQuestions_UC1.Visible = false;
            viewAndDelete_UC1.Visible = false;
            allStudentsResult_UC1.Visible = false;
            
            
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            addNewQuestions_UC1.Visible = true;
            addNewQuestions_UC1.BringToFront();
        }

        private void addNewQuestions_UC1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateQuestions_Click(object sender, EventArgs e)
        {
            updateQuestions_UC1.Visible = true;
            updateQuestions_UC1.BringToFront();
        }

        private void btnViewDeleteQuestions_Click(object sender, EventArgs e)
        {
            viewAndDelete_UC1.Visible = true;
            viewAndDelete_UC1.BringToFront();
        }

        private void StudentResult_Click(object sender, EventArgs e)
        {
            allStudentsResult_UC1.Visible = true;
            allStudentsResult_UC1.BringToFront();
        }
    }
}
