using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virality
{
    public partial class frmSignup : Form
    {
        String randomCode;
        public static string to;

        public frmSignup()
        {
            InitializeComponent();
        }


        private void frmSignup_Load(object sender, EventArgs e)
        {

        }

        private void btnOtp_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {

        }


        private void btnOtp_Click_2(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "tazzyb61@gmail.com";
            pass = "glncnewfxtdezyof";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Restting Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Sent Sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnVerifyS_Click_1(object sender, EventArgs e)
        {
            if (randomCode == (txtVerOtp.Text).ToString())
            {
                to = txtEmail.Text;
                frmMain rp = new frmMain();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("You have typed an incorrect code!");
            }
        }
    }
}
