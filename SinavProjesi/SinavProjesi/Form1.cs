using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace SinavProjesi
{
    public partial class Form1 : Form
    {
     
        bool isAnimation = true;
        const int MAX_WIDTH = 585;
        const int MIN_WIDTH = 92;
        Timer animationTimer = new Timer();
        int movedepth = 13;
        Timer animationTimer2 = new Timer();
        bool  isAnimation2 = false;

        
        SqlDataReader dr;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            animationTimer.Interval = 20;
            animationTimer.Tick += KaydirmaPanelAnimation_Tick;
            animationTimer2.Tick += KaydirmaPanelAnimation2_Tick;
            animationTimer2.Interval = 20;
            hidePasswordPicture.Location = showPasswordPicture.Location;
            LoginPanel.Controls.Add(hidePasswordPicture);
            LoginPanel.Controls.Add(showPasswordPicture);
            showPasswordPicture.Visible = false;
        }

        bool durum = false;
        SqlConnection con = new SqlConnection(@"Data Source=ALI;Initial Catalog=SinavProjesi;Integrated Security=True");

        void tekrar()
        {
            con.Open();
            SqlCommand cmd = cmd = new SqlCommand("Select * from Users where kullaniciAdi=@p1", con);
            cmd.Parameters.AddWithValue("@p1", userNameTxt.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            con.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void KaydirmaPanelAnimation_Tick(object sender, EventArgs e)
        {
            if (KaydirmaPanel.Height>=MIN_WIDTH)
            {
                KaydirmaPanel.Height -= movedepth;

            }
            else
            {
                KaydirmaPanel.Height = MIN_WIDTH;
                animationTimer.Stop();
                isAnimation2 = false;

            }

        }
        private void KaydirmaPanelAnimation2_Tick(object sender, EventArgs e)
        {
            if (KaydirmaPanel.Height <= MAX_WIDTH)
            {
                KaydirmaPanel.Height += movedepth;

            }
            else
            {
                KaydirmaPanel.Height = MAX_WIDTH;
                animationTimer2.Stop();
                isAnimation = false;

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from Users where kullaniciAdi='"+emailLoginTxt.Text+"' and kullaniciPassword='"+passwordLoginTxt.Text+"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = userCombo.SelectedItem.ToString();

            if (dt.Rows.Count>0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["userTypeID"].ToString()==cmbItemValue)
                    {
                        if (userCombo.SelectedIndex==0)
                        {
                            StudentForm frm2 = new StudentForm();
                            frm2.ShowDialog();

                        }
                        else
                        {
                            adminForm adm = new adminForm();
                            adm.ShowDialog();
                        }
                    }
                }
                {

                }
            }
            else
            {
                MessageBox.Show("error");
            }
            con.Close();

            if (isAnimation)
            {
                return;
            }


            isAnimation = true;
            animationTimer.Start();
            SignUpButton.Visible = true;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (isAnimation2)
            {
                return;
            }
            animationTimer2.Start();
            isAnimation2 = true;
            SignUpButton.Visible = false;

        }

        private void showPasswordPicture_Click(object sender, EventArgs e)
        {
            
            if (passwordLoginTxt.PasswordChar=='\0')
            {

                passwordLoginTxt.PasswordChar = '*';
                showPasswordPicture.Visible = false;
                hidePasswordPicture.Visible = true;
            }
 
        }

        private void hidePasswordPicture_Click(object sender, EventArgs e)
        {
            
            if (passwordLoginTxt.PasswordChar == '*')
            {
                
                passwordLoginTxt.PasswordChar = '\0';
                hidePasswordPicture.Visible = false;
                showPasswordPicture.Visible = true;
            }
          
        }

        private void signUp2Button_Click(object sender, EventArgs e)
        {
            tekrar();
            if (durum == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Users (kullaniciAdi,emailAdresi,kullaniciPassword,Ad,Soyad) values(@kullaniciAdi,@emailAdresi,@kullaniciPassword,@ad,@soyad)", con);
                cmd.Parameters.AddWithValue("@kullaniciAdi", userNameTxt.Text);
                cmd.Parameters.AddWithValue("@kullaniciPassword", passwordRegisterTxt.Text);
                cmd.Parameters.AddWithValue("@emailAdresi", emailRegisterTxt.Text);
                cmd.Parameters.AddWithValue("@ad", nameTxt.Text);
                cmd.Parameters.AddWithValue("@soyad", nameSurname.Text);
                

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("kayıt tamam");
            }
            else
            {
                MessageBox.Show("kayıt var");
            }
        }

        private void ForgotTextBox_Click(object sender, EventArgs e)
        {
            ForgotForm frm = new ForgotForm();
            frm.ShowDialog();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            StudentForm frm2 = new StudentForm();
            frm2.ShowDialog();

        }
    }
}
