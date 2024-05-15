namespace EnvanterYonetimSistemi
{
    partial class RegisterForm
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
            close = new Button();
            ımageList1 = new ImageList(components);
            register_username = new TextBox();
            register_password = new TextBox();
            register_btn = new Button();
            label3 = new Label();
            login_label = new LinkLabel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            register_cPassword = new TextBox();
            pictureBox7 = new PictureBox();
            register_showPass = new CheckBox();
            label4 = new Label();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            txtEmail = new TextBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.BackColor = Color.Red;
            close.FlatStyle = FlatStyle.Flat;
            close.Location = new Point(556, 9);
            close.Margin = new Padding(3, 2, 3, 2);
            close.Name = "close";
            close.Size = new Size(46, 22);
            close.TabIndex = 3;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // register_username
            // 
            register_username.Font = new Font("Microsoft Sans Serif", 9F);
            register_username.Location = new Point(143, 104);
            register_username.Margin = new Padding(3, 2, 3, 2);
            register_username.Name = "register_username";
            register_username.Size = new Size(191, 21);
            register_username.TabIndex = 2;
            // 
            // register_password
            // 
            register_password.Font = new Font("Microsoft Sans Serif", 12F);
            register_password.Location = new Point(143, 164);
            register_password.Margin = new Padding(3, 2, 3, 2);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(191, 26);
            register_password.TabIndex = 3;
            register_password.TextChanged += register_password_TextChanged;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.RosyBrown;
            register_btn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = SystemColors.ButtonHighlight;
            register_btn.Location = new Point(116, 280);
            register_btn.Margin = new Padding(3, 2, 3, 2);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(236, 32);
            register_btn.TabIndex = 4;
            register_btn.Text = "Kayıt Ol";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 314);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 5;
            label3.Text = "Hesabınız Var mı ?";
            label3.Click += label3_Click;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Location = new Point(290, 314);
            login_label.Name = "login_label";
            login_label.Size = new Size(62, 15);
            login_label.TabIndex = 6;
            login_label.TabStop = true;
            login_label.Text = "Giriş Yapın";
            login_label.TextAlign = ContentAlignment.TopCenter;
            login_label.LinkClicked += login_label_LinkClicked;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user;
            pictureBox5.Location = new Point(109, 100);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 25);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.Location = new Point(109, 158);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 32);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // register_cPassword
            // 
            register_cPassword.Font = new Font("Microsoft Sans Serif", 12F);
            register_cPassword.Location = new Point(143, 199);
            register_cPassword.Margin = new Padding(3, 2, 3, 2);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(191, 26);
            register_cPassword.TabIndex = 10;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources._lock;
            pictureBox7.Location = new Point(110, 199);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(28, 32);
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Location = new Point(257, 252);
            register_showPass.Margin = new Padding(3, 2, 3, 2);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(95, 19);
            register_showPass.TabIndex = 12;
            register_showPass.Text = "Şifreyi Göster";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(174, 71);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 1;
            label4.Text = "Kayıt Ol";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.man_icon__1_;
            pictureBox6.Location = new Point(184, 9);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 60);
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(register_showPass);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(register_cPassword);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(login_label);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(register_btn);
            panel2.Controls.Add(register_password);
            panel2.Controls.Add(register_username);
            panel2.Controls.Add(pictureBox8);
            panel2.Location = new Point(94, 34);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 336);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.Location = new Point(143, 129);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 21);
            txtEmail.TabIndex = 13;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Custom_Icon_Design_Mono_General_2_Mail_32;
            pictureBox8.Location = new Point(109, 126);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(39, 33);
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(612, 381);
            Controls.Add(panel2);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button close;
        private Panel panel2;
        private PictureBox pictureBox7;
        private TextBox register_cPassword;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private LinkLabel login_label;
        private Label label3;
        private Button register_btn;
        private TextBox register_password;
        private TextBox register_username;
        private Label label4;
        private CheckBox register_showPass;
        private ImageList ımageList1;
        private TextBox txtEmail;
        private PictureBox pictureBox8;
    }
}