namespace EnvanterYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            close = new Button();
            panel2 = new Panel();
            ForgetPass = new Label();
            login_showPass = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            register_label = new LinkLabel();
            label3 = new Label();
            login_btn = new Button();
            login_password = new TextBox();
            login_username = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(94, 47);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 288);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lock_icon1;
            pictureBox2.Location = new Point(89, 183);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 34);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Users_Name_icon1;
            pictureBox3.Location = new Point(91, 120);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 35);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.man_icon__1_;
            pictureBox1.Location = new Point(166, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 60);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(224, 263);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(96, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Hesap Oluşturun";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 263);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Hesabınız yokmu ?";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(136, 218);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(144, 27);
            button2.TabIndex = 4;
            button2.Text = "Giriş Yap";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F);
            textBox2.Location = new Point(136, 183);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 26);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(136, 120);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 26);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 84);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 1;
            label1.Text = "Giriş ";
            label1.Click += label1_Click;
            // 
            // close
            // 
            close.BackColor = Color.Red;
            close.FlatStyle = FlatStyle.Flat;
            close.Location = new Point(556, 9);
            close.Margin = new Padding(3, 2, 3, 2);
            close.Name = "close";
            close.Size = new Size(46, 22);
            close.TabIndex = 0;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ForgetPass);
            panel2.Controls.Add(login_showPass);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(register_label);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(login_btn);
            panel2.Controls.Add(login_password);
            panel2.Controls.Add(login_username);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(94, 47);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 288);
            panel2.TabIndex = 0;
            // 
            // ForgetPass
            // 
            ForgetPass.AutoSize = true;
            ForgetPass.Location = new Point(109, 184);
            ForgetPass.Name = "ForgetPass";
            ForgetPass.Size = new Size(98, 15);
            ForgetPass.TabIndex = 11;
            ForgetPass.Text = "Şifremi Unuttum ";
            ForgetPass.Click += ForgetPass_Click;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(236, 183);
            login_showPass.Margin = new Padding(3, 2, 3, 2);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(95, 19);
            login_showPass.TabIndex = 10;
            login_showPass.Text = "Şifreyi Göster";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.Location = new Point(116, 147);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 32);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user;
            pictureBox5.Location = new Point(116, 113);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 25);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
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
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.Location = new Point(237, 263);
            register_label.Name = "register_label";
            register_label.Size = new Size(96, 15);
            register_label.TabIndex = 6;
            register_label.TabStop = true;
            register_label.Text = "Hesap Oluşturun";
            register_label.TextAlign = ContentAlignment.TopCenter;
            register_label.LinkClicked += register_label_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 263);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 5;
            label3.Text = "Hesabınız yokmu ?";
            label3.Click += label2_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.RosyBrown;
            login_btn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(116, 219);
            login_btn.Margin = new Padding(3, 2, 3, 2);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(236, 32);
            login_btn.TabIndex = 4;
            login_btn.Text = "Giriş Yap";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_password
            // 
            login_password.Font = new Font("Microsoft Sans Serif", 12F);
            login_password.Location = new Point(150, 156);
            login_password.Margin = new Padding(3, 2, 3, 2);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(191, 26);
            login_password.TabIndex = 3;
            // 
            // login_username
            // 
            login_username.Font = new Font("Microsoft Sans Serif", 12F);
            login_username.Location = new Point(150, 116);
            login_username.Margin = new Padding(3, 2, 3, 2);
            login_username.Name = "login_username";
            login_username.Size = new Size(191, 26);
            login_username.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 71);
            label4.Name = "label4";
            label4.Size = new Size(134, 23);
            label4.TabIndex = 1;
            label4.Text = "Hesaba Giriş";
            label4.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(612, 381);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button close;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private LinkLabel register_label;
        private Label label3;
        private Button login_btn;
        private TextBox login_password;
        private TextBox login_username;
        private Label label4;
        private CheckBox login_showPass;
        private Label ForgetPass;
    }
}
