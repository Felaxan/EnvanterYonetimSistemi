using Microsoft.Data.SqlClient;
using System.Data;
namespace EnvanterYonetimSistemi
{
    public partial class Form1 : Form
    {

        public static string username;
        // SQL Server veritabanýna baðlanmak için SqlConnection nesnesi oluþturulurdum
        // Baðlantý dizesinde veritabanýnýn konumu, adý ve diðer baðlantý ayarlarý yazmakta.

        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ayinr\\OneDrive\\Belgeler\\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public Form1()
        {
            InitializeComponent();
            // InitializeComponent metodu çaðrýlarak formun bileþenleri baþlatýlýr.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            // Uygulamayý kapatmak için Application.Exit() metodu çaðrýlýr.
            Application.Exit();
        }

        private void register_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kayýt formunu açmak için yeni bir RegisterForm örneði oluþturulur.
            RegisterForm regForm = new RegisterForm();

            // Kayýt formu gösterilir.
            regForm.Show();

            // Mevcut form gizlenir.
            this.Hide();

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            // "Þifreyi göster" onay kutusunun durumuna baðlý olarak, 
            // þifre metni kutusunun karakterini gizlemek veya göstermek için ayar yapýlýr.
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }


        public bool checkConnection()
        {
            // Veritabaný baðlantýsý kapalýysa, true deðeri döndürülür.
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            // Aksi halde, false deðeri döndürülür.
            return false;
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            // Veritabaný baðlantýsý kontrol edilir.
            if (checkConnection())
            {
                try
                {
                    // Veritabaný baðlantýsý açýlýr.
                    connect.Open();

                    // Kullanýcý adý ve þifre ile veritabanýnda bir kullanýcý aranýr.
                    string selectData = "SELECT COUNT(*) FROM users WHERE username = @usern AND password = @pass AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Aktif");

                        int rowCount = (int)cmd.ExecuteScalar();
                     

                       
                      

                        // Kullanýcý adý ve þifre doðruysa yeni bir ana form açýlýr.
                        if (rowCount > 0)
                        {

                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using(SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern",login_username.Text.Trim());   
                                getRole.Parameters.AddWithValue("@pass",login_password.Text.Trim()) ;   

                                string userRole = getRole.ExecuteScalar() as string;

                                MessageBox.Show("Giriþ Baþarýlý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                if(userRole == "Admin") 
                                {
                                 MainForm mForm = new MainForm();
                                    mForm.Show();
                                    this.Hide();

                                }
                                else if(userRole == "Kasa")
                                {
                                    CashierMainForm cmForm = new CashierMainForm(); 
                                    cmForm.Show();
                                    this.Hide();
                                }
                            }
                          
                        }
                        // Kullanýcý adý veya þifre yanlýþsa veya admin onayý yoksa bir hata mesajý gösterilir.
                        else
                        {
                            // Kullanýcý adý veya þifre boþluklarýnýn doldurulmasý istenilir
                            if (login_username.Text == "" || login_password.Text == "" )
                            {
                                MessageBox.Show("Lütfen tüm boþluklarý doldurunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            // Kullanýcý adý veya þifre yanlýþsa veya admin onayý yoksa bir hata mesajý gösterilir.
                            {
                                MessageBox.Show("Kullanýcý Adý/Þifre yanlýþ veya admin onayý yok... ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    }
                }
                // Baðlantý veya sorgu sýrasýnda bir hata oluþursa bir hata mesajý gösterilir.
                catch (Exception ex)
                {
                    MessageBox.Show("Baðlantý Hatasý: " + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Baðlantý her durumda kapatýlýr.
                finally
                {
                    connect.Close();
                }
            }
        }


        private void ForgetPass_Click(object sender, EventArgs e)
        {
            // Þifre sýfýrlama formunu açmak için yeni bir SendCode örneði oluþturulur.
            SendCode sc = new SendCode();

            // Mevcut form gizlenir.
            this.Hide();

            // Þifre sýfýrlama formu gösterilir.
            sc.Show();
        }

    }
}
