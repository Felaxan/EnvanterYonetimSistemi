using Microsoft.Data.SqlClient;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace EnvanterYonetimSistemi
{
    public partial class ResetPassword : Form
    {
        // Şifre sıfırlama işlemi için kullanılacak olan kullanıcı adını depolamak için değişken

        string username = SendCode.to;


        public ResetPassword()
        {
            InitializeComponent();


        }
        // Formu kapatmak için kullanılan close_Click metodu

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_refresh_Click(object sender, EventArgs e, int _)
        {
            // Girilen yeni şifrenin doğruluğunu kontrol eder
            if (string.IsNullOrWhiteSpace(txtResetPass.Text) || string.IsNullOrWhiteSpace(txtResetPassVer.Text))
            {
                MessageBox.Show("Şifre alanlarını boş bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtResetPass.Text != txtResetPassVer.Text)
            {
                MessageBox.Show("Yeni şifreniz birbiriyle eşleşmiyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtResetPass.Text.Length < 8 || !txtResetPass.Text.Any(char.IsUpper) || !txtResetPass.Text.Any(char.IsLower) || !txtResetPass.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Yeni şifreniz en az 8 karakter uzunluğunda ve en az bir büyük harf, bir küçük harf ve bir sayı içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yeni şifreyle birlikte veritabanında güncelleme işlemi gerçekleştirilir
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ayinr\\OneDrive\\Belgeler\\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

            string newPassword = txtResetPass.Text;

            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[users] SET [password] = @pass WHERE [email] = @email", conn);
            cmd.Parameters.AddWithValue("@pass", newPassword);
            cmd.Parameters.AddWithValue("@email", Degiskenler.getMail());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            // Kullanıcıya şifrenin başarıyla güncellendiği bilgisi verilir
            MessageBox.Show("Şifreniz başarıyla yenilendi");

            // Yeniden giriş formunu açar ve mevcut formu gizler
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void refresh_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Şifre alanlarında karakterleri göstermek veya gizlemek için kontrol yapılır
            txtResetPass.PasswordChar = refresh_ShowPass.Checked ? '\0' : '*';
            txtResetPassVer.PasswordChar = refresh_ShowPass.Checked ? '\0' : '*';
        }

        private void txtResetPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
