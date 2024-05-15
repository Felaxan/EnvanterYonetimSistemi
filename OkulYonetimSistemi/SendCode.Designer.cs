namespace EnvanterYonetimSistemi
{
    partial class SendCode
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
            close = new Button();
            panel2 = new Panel();
            txtEmail = new TextBox();
            pictureBox8 = new PictureBox();
            txtSend = new Button();
            pictureBox4 = new PictureBox();
            txtVerify = new Button();
            txtVerCode = new TextBox();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            close.TabIndex = 1;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(txtSend);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(txtVerify);
            panel2.Controls.Add(txtVerCode);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(92, 46);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 288);
            panel2.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(150, 100);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 26);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Custom_Icon_Design_Mono_General_2_Mail_32;
            pictureBox8.Location = new Point(116, 100);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(39, 33);
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            // 
            // txtSend
            // 
            txtSend.BackColor = Color.RosyBrown;
            txtSend.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSend.ForeColor = SystemColors.ButtonHighlight;
            txtSend.Location = new Point(244, 130);
            txtSend.Margin = new Padding(3, 2, 3, 2);
            txtSend.Name = "txtSend";
            txtSend.Size = new Size(97, 30);
            txtSend.TabIndex = 10;
            txtSend.Text = "Gönder";
            txtSend.UseVisualStyleBackColor = false;
            txtSend.Click += txtSend_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.Location = new Point(116, 172);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 32);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // txtVerify
            // 
            txtVerify.BackColor = Color.RosyBrown;
            txtVerify.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVerify.ForeColor = SystemColors.ButtonHighlight;
            txtVerify.Location = new Point(244, 219);
            txtVerify.Margin = new Padding(3, 2, 3, 2);
            txtVerify.Name = "txtVerify";
            txtVerify.Size = new Size(97, 32);
            txtVerify.TabIndex = 4;
            txtVerify.Text = "Onayla";
            txtVerify.UseVisualStyleBackColor = false;
            txtVerify.Click += txtVerify_Click;
            // 
            // txtVerCode
            // 
            txtVerCode.Font = new Font("Microsoft Sans Serif", 12F);
            txtVerCode.Location = new Point(150, 178);
            txtVerCode.Margin = new Padding(3, 2, 3, 2);
            txtVerCode.Name = "txtVerCode";
            txtVerCode.PasswordChar = '*';
            txtVerCode.Size = new Size(191, 26);
            txtVerCode.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 33);
            label4.Name = "label4";
            label4.Size = new Size(134, 23);
            label4.TabIndex = 1;
            label4.Text = "Şifreyi Yenile";
            // 
            // SendCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(612, 381);
            Controls.Add(panel2);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SendCode";
            Text = "SendCode";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button close;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Button txtVerify;
        private TextBox txtVerCode;
        private TextBox txtEmail;
        private Label label4;
        private Button txtSend;
        private PictureBox pictureBox8;
    }
}