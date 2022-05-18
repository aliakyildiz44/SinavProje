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
using System.Net;
using System.Net.Mail;
using System.Security;
namespace SinavProjesi
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ALI;Initial Catalog=ExamApplication;Integrated Security=True");
      
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }
            SqlCommand cmd = cmd = new SqlCommand("Select * from Users where Email='" + emailForgotTxt.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    String mailadresin = "altamanager44@gmail.com";
                    String sifre = "alta12345.";
                    String smptsrvr = "smtp.gmail.com";
                    String kime = (dr["Email"].ToString());
                    String konu = ("Password Reminder");
                    String yaz = ("Dear," + dr["Name"].ToString() +" "+ dr["Surname"].ToString() + "\n" + "You requested a password reminder from us on " + tarih + " " +
                        "\n" + "Your password:" + dr["Password"].ToString() + "\nHave a nice day");
                    smtpserver.Credentials = new NetworkCredential(mailadresin, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("The information you entered is correct. Your password has been sent to your e-mail address.");
                    this.Hide();
                    con.Close();
                }

                catch (Exception hata)
                {
                    MessageBox.Show("Error sending mail", hata.Message);
                }

            }
            else if (emailForgotTxt.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else
            {
                MessageBox.Show("Email address is incorrect");
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

