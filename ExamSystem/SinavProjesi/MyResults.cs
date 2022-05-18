﻿using System;
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
    public partial class MyResults : Form
    {
        int studentsId;
        public MyResults()
        {
            InitializeComponent();
        }
        public MyResults(int studentId) :this()
        {
            this.studentsId = studentId;
        }
        SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True");
        void LoadResult()
        {
            try
            {
                string Myquery = "Select * from Results where StudentId='"+studentsId+"'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgwMyResult.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
        private void MyResults_Load(object sender, EventArgs e)
        {
            LoadResult();
        }     
    }
}
