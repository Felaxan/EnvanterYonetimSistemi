
using Microsoft.Data.SqlClient;
using System.Net.Mail;


namespace EnvanterYonetimSistemi
{

    partial class ResetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ımageList1 = new ImageList(components);
            label4 = new Label();
            refresh_ShowPass = new CheckBox();
            pictureBox7 = new PictureBox();
            txtResetPassVer = new TextBox();
            pictureBox4 = new PictureBox();
            btn_refresh = new Button();
            txtResetPass = new TextBox();
            panel2 = new Panel();
            close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(145, 75);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 1;
            label4.Text = "Şifre Yenileme";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // refresh_ShowPass
            // 
            refresh_ShowPass.AutoSize = true;
            refresh_ShowPass.Location = new Point(241, 211);
            refresh_ShowPass.Margin = new Padding(3, 2, 3, 2);
            refresh_ShowPass.Name = "refresh_ShowPass";
            refresh_ShowPass.Size = new Size(95, 19);
            refresh_ShowPass.TabIndex = 12;
            refresh_ShowPass.Text = "Şifreyi Göster";
            refresh_ShowPass.UseVisualStyleBackColor = true;
            refresh_ShowPass.CheckedChanged += refresh_ShowPass_CheckedChanged;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources._lock;
            pictureBox7.Location = new Point(112, 175);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(39, 42);
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // txtResetPassVer
            // 
            txtResetPassVer.Font = new Font("Microsoft Sans Serif", 12F);
            txtResetPassVer.Location = new Point(145, 181);
            txtResetPassVer.Margin = new Padding(3, 2, 3, 2);
            txtResetPassVer.Name = "txtResetPassVer";
            txtResetPassVer.PasswordChar = '*';
            txtResetPassVer.Size = new Size(191, 26);
            txtResetPassVer.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.Location = new Point(112, 130);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 41);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.RosyBrown;
            btn_refresh.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_refresh.ForeColor = SystemColors.ButtonHighlight;
            btn_refresh.Location = new Point(112, 234);
            btn_refresh.Margin = new Padding(3, 2, 3, 2);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(236, 32);
            btn_refresh.TabIndex = 4;
            btn_refresh.Text = "Yenile";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // txtResetPass
            // 
            txtResetPass.Font = new Font("Microsoft Sans Serif", 12F);
            txtResetPass.Location = new Point(145, 136);
            txtResetPass.Margin = new Padding(3, 2, 3, 2);
            txtResetPass.Name = "txtResetPass";
            txtResetPass.PasswordChar = '*';
            txtResetPass.Size = new Size(191, 26);
            txtResetPass.TabIndex = 3;
            txtResetPass.TextChanged += txtResetPass_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(refresh_ShowPass);
            panel2.Controls.Add(txtResetPassVer);
            panel2.Controls.Add(btn_refresh);
            panel2.Controls.Add(txtResetPass);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox7);
            panel2.Location = new Point(66, 34);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 336);
            panel2.TabIndex = 4;
            // 
            // close
            // 
            close.BackColor = Color.Red;
            close.FlatStyle = FlatStyle.Flat;
            close.Location = new Point(556, 9);
            close.Margin = new Padding(3, 2, 3, 2);
            close.Name = "close";
            close.Size = new Size(46, 22);
            close.TabIndex = 5;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(612, 381);
            Controls.Add(panel2);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPassword";
            Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
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

        #endregion

        private ImageList ımageList1;
        private Label label4;
        private CheckBox refresh_ShowPass;
        private PictureBox pictureBox7;
        private TextBox txtResetPassVer;
        private PictureBox pictureBox4;
        private Button btn_refresh;
        private TextBox txtResetPass;
        private Panel panel2;
        private Button close;
    }
}