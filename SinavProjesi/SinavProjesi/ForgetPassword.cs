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
        SqlConnection con = new SqlConnection(@"Data Source=TALHAGERGIN;Initial Catalog=ExamApplication;Integrated Security=True");
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
                    String mailadresin = "burakyazilim44@gmail.com";
                    String sifre = "burakyazilim4444";
                    String smptsrvr = "smtp.gmail.com";
                    String kime = (dr["emailAdresi"].ToString());
                    String konu = ("Sifre hatırlatma Maili");
                    String yaz = ("Sayın," + dr["Ad"].ToString() + dr["Soyad"].ToString() + "\n" + "Bizden " + tarih + " tarihinde sifre hatırlatma talebinde bulundunuz" +
                        "\n" + "Paralonız:" + dr["kullaniciPassword"].ToString() + "\nİyi Günler");
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
                    bilgi = MessageBox.Show("Girmis Oldugunuz bilgiler uyusuyor.Sifreniz mail adresinize gonderilmistir.");
                    this.Hide();
                    con.Close();
                }

                catch (Exception hata)
                {
                    MessageBox.Show("Mail gonderme hatasi", hata.Message);
                }

            }
            else if (emailForgotTxt.Text == "")
            {
                MessageBox.Show("Email adresi boş bırakılamaz");
            }
            else
            {
                MessageBox.Show("Email adresi yanlış");
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

