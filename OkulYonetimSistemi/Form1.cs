using Microsoft.Data.SqlClient;
using System.Data;
namespace EnvanterYonetimSistemi
{
    public partial class Form1 : Form
    {

        public static string username;
        // SQL Server veritaban�na ba�lanmak i�in SqlConnection nesnesi olu�turulurdum
        // Ba�lant� dizesinde veritaban�n�n konumu, ad� ve di�er ba�lant� ayarlar� yazmakta.

        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ayinr\\OneDrive\\Belgeler\\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public Form1()
        {
            InitializeComponent();
            // InitializeComponent metodu �a�r�larak formun bile�enleri ba�lat�l�r.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            // Uygulamay� kapatmak i�in Application.Exit() metodu �a�r�l�r.
            Application.Exit();
        }

        private void register_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kay�t formunu a�mak i�in yeni bir RegisterForm �rne�i olu�turulur.
            RegisterForm regForm = new RegisterForm();

            // Kay�t formu g�sterilir.
            regForm.Show();

            // Mevcut form gizlenir.
            this.Hide();

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            // "�ifreyi g�ster" onay kutusunun durumuna ba�l� olarak, 
            // �ifre metni kutusunun karakterini gizlemek veya g�stermek i�in ayar yap�l�r.
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }


        public bool checkConnection()
        {
            // Veritaban� ba�lant�s� kapal�ysa, true de�eri d�nd�r�l�r.
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            // Aksi halde, false de�eri d�nd�r�l�r.
            return false;
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            // Veritaban� ba�lant�s� kontrol edilir.
            if (checkConnection())
            {
                try
                {
                    // Veritaban� ba�lant�s� a��l�r.
                    connect.Open();

                    // Kullan�c� ad� ve �ifre ile veritaban�nda bir kullan�c� aran�r.
                    string selectData = "SELECT COUNT(*) FROM users WHERE username = @usern AND password = @pass AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Aktif");

                        int rowCount = (int)cmd.ExecuteScalar();
                     

                       
                      

                        // Kullan�c� ad� ve �ifre do�ruysa yeni bir ana form a��l�r.
                        if (rowCount > 0)
                        {

                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using(SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern",login_username.Text.Trim());   
                                getRole.Parameters.AddWithValue("@pass",login_password.Text.Trim()) ;   

                                string userRole = getRole.ExecuteScalar() as string;

                                MessageBox.Show("Giri� Ba�ar�l�!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                        // Kullan�c� ad� veya �ifre yanl��sa veya admin onay� yoksa bir hata mesaj� g�sterilir.
                        else
                        {
                            // Kullan�c� ad� veya �ifre bo�luklar�n�n doldurulmas� istenilir
                            if (login_username.Text == "" || login_password.Text == "" )
                            {
                                MessageBox.Show("L�tfen t�m bo�luklar� doldurunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            // Kullan�c� ad� veya �ifre yanl��sa veya admin onay� yoksa bir hata mesaj� g�sterilir.
                            {
                                MessageBox.Show("Kullan�c� Ad�/�ifre yanl�� veya admin onay� yok... ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    }
                }
                // Ba�lant� veya sorgu s�ras�nda bir hata olu�ursa bir hata mesaj� g�sterilir.
                catch (Exception ex)
                {
                    MessageBox.Show("Ba�lant� Hatas�: " + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Ba�lant� her durumda kapat�l�r.
                finally
                {
                    connect.Close();
                }
            }
        }


        private void ForgetPass_Click(object sender, EventArgs e)
        {
            // �ifre s�f�rlama formunu a�mak i�in yeni bir SendCode �rne�i olu�turulur.
            SendCode sc = new SendCode();

            // Mevcut form gizlenir.
            this.Hide();

            // �ifre s�f�rlama formu g�sterilir.
            sc.Show();
        }

    }
}
