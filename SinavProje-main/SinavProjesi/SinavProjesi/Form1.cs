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
    public partial class LoginForm : Form
    {
        bool isAnimation = true;
        const int MAX_WIDTH = 559;
        const int MIN_WIDTH = 80;
        Timer animationTimer = new Timer();
        int movedepth = 13;
        Timer animationTimer2 = new Timer();
        bool  isAnimation2 = false;

        
        SqlDataReader dr;
        SqlCommand cmd;


        public LoginForm()
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
            Init_Data();
        }

        bool durum = false;
        SqlConnection con = new SqlConnection(@"Data Source=ALI;Initial Catalog=SinavProjesi;Integrated Security=True");

        void tekrar()
        {
            con.Open();
            SqlCommand cmd = cmd = new SqlCommand("Select * from Users where emailAdresi=@p1", con);
            cmd.Parameters.AddWithValue("@p1", emailRegisterTxt.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("This Username is using.You can choose another username.");
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
            KaydirmaPanel.Location = new Point(0, 472);
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
        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {                     
                Save_Data();
                string useremail = emailLoginTxt.Text;
                string userpassword = passwordLoginTxt.Text;

                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select * from Users where emailAdresi='" + emailLoginTxt.Text + "'AND kullaniciPassword='" + passwordLoginTxt.Text + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş başarılı");
                }
                else if (emailRegisterTxt.Text == "" && passwordLoginTxt.Text == "")
                {
                    MessageBox.Show("Email veya Şifre boş bırakılamaz");
                }
                else
                {
                    MessageBox.Show("Hatalı Email Ya Da Şifre!");
                    emailLoginTxt.Text = string.Empty;
                    passwordLoginTxt.Text = string.Empty;
                }
                con.Close();

                
                
            
           
        }
       
        private void Init_Data()
        {
            if (Properties.Settings.Default.Email != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    emailLoginTxt.Text = Properties.Settings.Default.Email;
                    passwordLoginTxt.Text = Properties.Settings.Default.Password;
                    RememberSwitch.Checked = true;
                }
                else
                {
                    emailLoginTxt.Text = Properties.Settings.Default.Email;
                    passwordLoginTxt.Text = Properties.Settings.Default.Email;
                }
            }
        }
        private void Save_Data()
        {
            if (RememberSwitch.Checked)
            {
                Properties.Settings.Default.Email = emailLoginTxt.Text.Trim();
                Properties.Settings.Default.Password = passwordLoginTxt.Text.Trim();
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Email = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
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
            btnBack.Visible = true;
            btnBack.Enabled = true;
            LoginButton.Visible = false;
            LoginButton.Enabled = false;

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
            if (durum == false) { MessageBox.Show("Error!"); }
            else { ControlInfo();
                if (durum == true)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Users (kullaniciAdi,emailAdresi,kullaniciPassword,Ad,Soyad) values(@kullaniciAdi,@emailAdresi,@kullaniciPassword,@ad,@soyad)", con);
                    cmd.Parameters.AddWithValue("@kullaniciAdi", userNameTxt.Text);
                    cmd.Parameters.AddWithValue("@kullaniciPassword", passwordRegisterTxt.Text);
                    cmd.Parameters.AddWithValue("@emailAdresi", emailRegisterTxt.Text);
                    cmd.Parameters.AddWithValue("@ad", nameTxt.Text);
                    cmd.Parameters.AddWithValue("@soyad", nameSurname.Text);
                    SqlCommand cmd2 = new SqlCommand("insert into Users (userTypeID) values (@userTypeId)", con);
                    if (cmbType.SelectedIndex == 0)
                    {
                        cmd2.Parameters.AddWithValue("@userTypeId", 1);
                    }
                    else if (cmbType.SelectedIndex == 1)
                    {
                        cmd2.Parameters.AddWithValue("@userTypeId", 2);
                    }
                    else if (cmbType.SelectedIndex == 2)
                    {
                        cmd2.Parameters.AddWithValue("@userTypeId", 3);
                    }
                    else
                    {
                        cmd2.Parameters.AddWithValue("@userTypeId", 1);
                        MessageBox.Show("You didn't choose user type!");
                    }

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registered");

                }
                else{ MessageBox.Show("Error"); }
            }
        }
        void ControlInfo()
        {
            durum = false;
            if (ConfirmPasswordTxt.Text != "" && emailRegisterTxt.Text != "" && passwordRegisterTxt.Text != "" && nameTxt.Text != "" && nameSurname.Text != "" && userNameTxt.Text != "" && cmbType.Text!="")
            {
                durum = true;               
            }           
            else
            {
                MessageBox.Show("Please Correct!");
            }
        }
        private void ForgotTextBox_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isAnimation)
            {
                return;
            }
            isAnimation = true;
            animationTimer.Start();
            SignUpButton.Visible = true;
            LoginButton.Visible = true;
            LoginButton.Enabled = true;
            btnBack.Visible = false;
            btnBack.Enabled = false;

        }
        private void ConfirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordRegisterTxt.Text != ConfirmPasswordTxt.Text)
            {
                lblWarning.Visible = true;
                signUp2Button.Enabled = false;
            }
            else
            {
                lblWarning.Visible = false;
                signUp2Button.Enabled = true;
            }
        }
    }
}
