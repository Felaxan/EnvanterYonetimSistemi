using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;


namespace EnvanterYonetimSistemi
{
    public partial class RegisterForm : Form
    {
        // SQL Server veritabanına bağlanmak için SqlConnection nesnesi oluşturulurdum
        // Bağlantı dizesinde veritabanının konumu, adı ve diğer bağlantı ayarları yazmakta.
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ayinr\OneDrive\Belgeler\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public RegisterForm()
        {
            InitializeComponent();
            // InitializeComponent metodu çağrılarak formun bileşenleri başlatılır.

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü yapılır.
            if (register_username.Text == "" || txtEmail.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Lütfen tüm boşlukları doldurunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Veritabanı bağlantısı kontrol edilir.
                if (checkConnection())
                {
                    try
                    {
                        // Veritabanı bağlantısı açılır.
                        connect.Open();

                        // Kullanıcı adının kullanılabilirliği kontrol edilir.
                        string checkUsername = "SELECT * FROM users WHERE username= @usern ";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim() + " Bu isim alınmış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                // Şifre uzunluğu kontrolü yapılır.
                                MessageBox.Show(register_username.Text.Trim() + " Şifrede hata var lütfen 8 harf uzunluğunda kullanın ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (!Regex.IsMatch(txtEmail.Text, emailPattern))
                            {

                                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Eğer e-posta formatı geçerli değilse kullanıcıdan geçerli bir format isteriz
                            }
                            else if (!register_password.Text.Any(char.IsUpper) || !register_password.Text.Any(char.IsLower) || !register_password.Text.Any(char.IsDigit))
                            {
                                // Şifrede en az bir küçük harf, bir büyük harf ve bir sayı olması gerektiğini kontrol eder.
                                MessageBox.Show(register_username.Text.Trim() + " Şifre en az bir küçük harf, bir büyük harf ve bir sayı içermelidir ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Trim() != register_cPassword.Text.Trim())
                            {
                                // Şifre eşleşme kontrolü yapılır.
                                MessageBox.Show(register_username.Text.Trim() + " Şifre Eşleşmiyor! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // E-posta adresinin veritabanında olup olmadığını kontrol etmek için sorgu
                                string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @email";
                                SqlCommand checkCmd = new SqlCommand(checkQuery, connect);
                                checkCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                                // E-posta adresiyle eşleşen kayıt sayısını al
                                int EmailCount = (int)checkCmd.ExecuteScalar();

                                if (EmailCount > 0)
                                {
                                    // E-posta adresi veritabanında bulunduğunda kullanıcıyı kaydetmeyi engelleyin
                                    MessageBox.Show("Bu e-posta adresi zaten kullanımda.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    // Yeni kullanıcı veritabanına eklenir.
                                    string insertData = "INSERT INTO users(username,password,role,status,date,email)" + " VALUES(@usern,@pass,@role,@status,@date,@email)";
                                    using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                    {
                                        // Yeni kullanıcıyı veritabanına eklemek için gerekli parametreler belirlenir.
                                        insertD.Parameters.AddWithValue("@usern", register_username.Text.Trim()); // Kullanıcı adı
                                        insertD.Parameters.AddWithValue("@email", txtEmail.Text.Trim()); // E-posta
                                        insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim()); // Şifre
                                        insertD.Parameters.AddWithValue("@role", "Kasa"); // Kullanıcı rolü (örneğin: Kasa)
                                        insertD.Parameters.AddWithValue("@status", "Aktif"); // Kullanıcı durumu (örneğin: Aktif)

                                        DateTime today = DateTime.Today; // Şu anki tarih alınır.

                                        insertD.Parameters.AddWithValue("@date", today); // Kayıt tarihi
                                        insertD.ExecuteNonQuery(); // Sorgu çalıştırılır ve yeni kullanıcı eklenir.

                                        MessageBox.Show(register_username.Text.Trim() + " Başarıyla Kayıt Olundu ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Başarılı kayıt mesajı gösterilir.
                                        Form1 loginForm = new Form1(); // Yeni giriş formu oluşturulur.
                                        loginForm.Show(); // Yeni giriş formu gösterilir.
                                        this.Hide(); // Mevcut kayıt formu gizlenir.
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(register_username.Text.Trim() + "Bağlantı Hatası " + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }



        public bool checkConnection()
        {
            // Bağlantı kapalıysa, true değeri döndürülür.
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            // Aksi halde, false değeri döndürülür.
            return false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            // Uygulamayı kapatmak için Application.Exit() metodu çağrılır.
            Application.Exit();
        }

        private void login_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Giriş bağlantısına tıklandığında yeni bir giriş formu açılır, mevcut form gizlenir.
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            // "Şifreyi Göster" onay kutusunun durumuna bağlı olarak, şifre metin kutusunun karakterleri görünür veya gizlenir.
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }


        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void register_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
