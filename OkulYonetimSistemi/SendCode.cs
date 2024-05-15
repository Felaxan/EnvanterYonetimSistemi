using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace EnvanterYonetimSistemi
{


    public partial class SendCode : Form
    {
        // Şifre sıfırlama işlemi için kullanılacak random kodu depolamak için girilen bir değişeken

        string randomCode;
        // E-posta alıcısını geçici olarak depolamak için kullanılan static bir değişken

        public static string to;


        public SendCode()
        {
            InitializeComponent();
        }

        // Formu kapatmak için kullanılan close_Click metodu

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Kod gönderme butonuna tıklandığında çalışacak metot

        private void txtSend_Click(object sender, EventArgs e)
        {
            // Yeni bir SendCode formu oluşturuluyor
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Lütfen mail boşluğunu doldurunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Eğer e-posta alanı boşsa kullanıcıdan doldurulması istenir.
            }

            // E-posta formatını kontrol etmek için düzenli ifade (regular expression) kullanıyoruz
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Eğer e-posta formatı geçerli değilse kullanıcıdan geçerli bir format isteriz
            }

            // E-posta gönderme işlemleri

            SendCode sendCodeForm = new SendCode();
            Degiskenler.setMail(txtEmail.Text);
            string from, pass, messageBody;
            Random rand = new Random();
            // Rastgele bir kod oluşturma işlemi

            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            string to = (txtEmail.Text).ToString();
            from = "renasayin3@gmail.com";
            pass = "twbt lidc smjp bsyj";

            // E-posta mesajının içeriği 

            messageBody = "Şifre yenileme kodunuz " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Şifre yenileme kodu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                // E-posta gönderme işlemi gerçekleştiriliyor

                smtp.Send(message);
                MessageBox.Show("Kod başarıyla gönderildi");

            }
            catch (Exception ex)
            {
                // Eğer bir hata oluşursa kullanıcıya bilgi veriliyor

                MessageBox.Show(ex.Message);
            }

        }

        // Doğrulama kodunu kontrol etme işlemini yapan metot

        private void txtVerify_Click(object sender, EventArgs e)
        {
            // Girilen kodun doğruluğunu kontrol ediyor

            if (randomCode == (txtVerCode.Text).ToString())
            {
                // Eğer kod doğruysa, e-posta adresi bir değişkene atanır ve şifre sıfırlama formu gösterilir

                to = txtEmail.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();
                rp.Show();


            }
            else
            {
                // Eğer kod yanlışsa, kullanıcıya bilgi verilir

                MessageBox.Show("Yanlış kod");
            }
        }


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

          
        }
    }
}