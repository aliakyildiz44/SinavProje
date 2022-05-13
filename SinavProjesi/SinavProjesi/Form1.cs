using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlClient;


namespace SinavProjesi
{
    public partial class Form1 : Form
    {
        bool isAnimation = true;
        const int MAX_WIDTH = 559;
        const int MIN_WIDTH = 80;
        Timer animationTimer = new Timer();
        int movedepth = 13;
        Timer animationTimer2 = new Timer();
        bool  isAnimation2 = false;
        Task t1;

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
            Init_Data();
        }
      
        SqlCommand cmd;
        DataSet ds;
        bool durum = false;
        SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True");

       void toControl()
        {
            con.Open();
            SqlCommand cmd = cmd = new SqlCommand("Select * from Users where Email=@p1", con);
            cmd.Parameters.AddWithValue("@p1", emailRegisterTxt.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("This Email is using.You can choose another Email.");
                durum = false;
            }
            else
            {
                durum = true;
            }
            con.Close();
        }
        void toEmailControl()
        {
            int count = 0;
            using (SqlConnection sql = new SqlConnection(@"Data Source = TALHAGERGIN; Initial Catalog = ExamApplication; Integrated Security = True"))
            {
                sql.Open();
                cmd = sql.CreateCommand();
                cmd.CommandText = @"SELECT *FROM Users WHERE Email='" + emailLoginTxt + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                count = dt.Rows.Count;
                sql.Close();
            }
            if (count < 0)
            {
                MessageBox.Show("Email is wrong");
                durum = false;
            }
            else
            {
                durum = true;
            }
        }
        void toPassControl()
        {
            if (durum == true)
            {
                int count = 0;
                using (SqlConnection sql = new SqlConnection(@"Data Source = TALHAGERGIN; Initial Catalog = ExamApplication; Integrated Security = True"))
                {
                    sql.Open();
                    cmd = sql.CreateCommand();
                    cmd.CommandText = @"SELECT *FROM Users WHERE Password='" + passwordLoginTxt.Text + "'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    count = dt.Rows.Count;
                    sql.Close();
                }
                if (count <= 0)
                {
                    MessageBox.Show("Password is wrong");
                    durum = false;
                }
                durum = true;
            }
            else { return; }
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
            int Id;
            string Username;
            string Name;
            string Surname;
            string Email;
            string Password;
            int UserTypeId;
            int c;
            bool control=false;
            durum = false;
            using (SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True"))
            {
                ds = new DataSet();
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Users where Email='" + useremail + "'AND Password='" + userpassword + "'";


                if (emailRegisterTxt.Text == "" && passwordLoginTxt.Text == "")

                    MessageBox.Show("Email veya Şifre boş bırakılamaz");
                else
                {
                    while (durum==false)
                    {
                        toEmailControl();
                        toPassControl();
                    }
                }
               
                    if (control == false)
                    {
                        cmd = con.CreateCommand();
                        cmd.CommandText = "Select * from Users where Email='" + useremail + "'AND Password='" + userpassword + "'";
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ds);
                        c = ds.Tables[0].Rows.Count;
                        if (c == 0)
                        {
                            con.Close();
                            return;
                        }

                        object[] dt = ds.Tables[0].Rows[0].ItemArray;
                        Id = Convert.ToInt32(dt[0]);
                        Username = dt[1].ToString();
                        Name = dt[2].ToString();
                        Surname = dt[3].ToString();
                        Email = dt[4].ToString();
                        Password = dt[5].ToString();
                        UserTypeId = Convert.ToInt32(dt[6]);
                        con.Close();

                        if (UserTypeId == 1)
                        {
                            User student = new User(Id, Username, Name, Surname, Email, Password);
                            StudentsScreen studentScreen = new StudentsScreen(student);
                            studentScreen.Show();
                            MessageBox.Show("Student");
                        this.Hide();
                        }
                        else if (UserTypeId == 2)
                        {
                            User admin = new User(Id, Username, Name, Surname, Email, Password);
                            AdminScreen adminScreen = new AdminScreen();
                            adminScreen.Show();
                            MessageBox.Show("admin");

                            this.Dispose();
                        }
                        else
                        {
                            User educator = new User(Id, Username, Name, Surname, Email, Password);
                            EducatorScreen educatorScreen = new EducatorScreen();
                            educatorScreen.Show();
                            MessageBox.Show("educator");
                        this.Hide();
                        }
                        control = true;

                    
                }
            }
           
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

            Guna.UI2.WinForms.Guna2TextBox emailB = this.Controls["emailRegisterTxt"] as Guna.UI2.WinForms.Guna2TextBox;
            Guna.UI2.WinForms.Guna2TextBox username1B = this.Controls["userNameTxt"] as Guna.UI2.WinForms.Guna2TextBox;
            Regex rEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (emailB != null)
            {
                if (!rEmail.IsMatch(emailB.Text))
                {
                    t1 = new Task(() =>
                    {
                        MessageBox.Show("Email is not valid");
                    });
                    t1.Start();
                }

                          
                toControl();
                if (durum == false) { MessageBox.Show("Error!"); }
                else
                {
                    ControlInfo();
                    if (durum == true)
                    {
                        int i = 0;
                        if (cmbType.SelectedIndex == 0) { i = 1; } else if (cmbType.SelectedIndex == 1) { i = 2; } else { i = 3; }
                        try
                        {
                            InsertUser(userNameTxt.Text, nameTxt.Text, nameSurname.Text, emailRegisterTxt.Text, passwordRegisterTxt.Text, i);
                            MessageBox.Show("You have successfully registered");
                            clean();
                        }
                        catch
                        {
                            MessageBox.Show("Error!");
                        }
                    }
                    else { MessageBox.Show("Error"); }
                }
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

        void clean()
        {
            userNameTxt.Clear();
            nameTxt.Clear();
            nameSurname.Clear();
            emailRegisterTxt.Clear();
            passwordRegisterTxt.Clear();
            userNameTxt.Focus();
        }
        private async void InsertUser(string UserName,string Name,string Surname,string Email,string Password,int UserTypeId)
        {
            await Task.Run(() =>
            {
                using (SqlConnection sql = new SqlConnection(@"Data Source = TALHAGERGIN; Initial Catalog = ExamApplication; Integrated Security = True"))
                {
                    sql.Open();
                    cmd = sql.CreateCommand();
                    cmd.CommandText = @"INSERT INTO Users (UserName,Name,Surname,Email,Password,UserTypeId) VALUES ('" + UserName + "','" + Name + "','" + Surname + "','" + Email + "','" + Password + "','"+UserTypeId+"')";
                    cmd.ExecuteNonQuery();
                    sql.Close();
                }
            });
        }

        private void emailRegisterTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
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

        private void emailLoginTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
