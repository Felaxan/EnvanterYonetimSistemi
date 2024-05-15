namespace EnvanterYonetimSistemi
{
    partial class MainForm
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
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            closes = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            logout = new Button();
            customers_Btn = new Button();
            addProducts_Btn = new Button();
            addCategory_Btn = new Button();
            addUsers_Btn = new Button();
            dashboard_Btn = new Button();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            adminyonetici1 = new adminyonetici();
            adminadduser1 = new adminadduser();
            adminAddCategory1 = new AdminAddCategory();
            adminAddProducts1 = new AdminAddProducts();
            cashierCustomerForm1 = new CashierCustomerForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // close
            // 
            close.BackColor = Color.Red;
            close.FlatStyle = FlatStyle.Flat;
            close.Location = new Point(1352, 11);
            close.Margin = new Padding(3, 2, 3, 2);
            close.Name = "close";
            close.Size = new Size(46, 22);
            close.TabIndex = 1;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(closes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1347, 46);
            panel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(217, 45);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1118, 677);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(11, 10);
            label4.Name = "label4";
            label4.Size = new Size(344, 18);
            label4.TabIndex = 6;
            label4.Text = "Envanter Yönetim Sistemi  | Yönetici Paneli";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // closes
            // 
            closes.BackColor = Color.Red;
            closes.FlatStyle = FlatStyle.Flat;
            closes.Font = new Font("Segoe UI", 8F);
            closes.Location = new Point(1297, 11);
            closes.Margin = new Padding(3, 2, 3, 2);
            closes.Name = "closes";
            closes.Size = new Size(46, 22);
            closes.TabIndex = 4;
            closes.Text = "X";
            closes.UseVisualStyleBackColor = false;
            closes.Click += closes_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(logout);
            panel2.Controls.Add(customers_Btn);
            panel2.Controls.Add(addProducts_Btn);
            panel2.Controls.Add(addCategory_Btn);
            panel2.Controls.Add(addUsers_Btn);
            panel2.Controls.Add(dashboard_Btn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 724);
            panel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(222, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1121, 711);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // logout
            // 
            logout.BackColor = Color.FromArgb(220, 196, 196);
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 12F);
            logout.ForeColor = Color.White;
            logout.Location = new Point(3, 639);
            logout.Name = "logout";
            logout.Size = new Size(217, 39);
            logout.TabIndex = 13;
            logout.Text = "Çıkış Yap";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // customers_Btn
            // 
            customers_Btn.FlatAppearance.BorderSize = 0;
            customers_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            customers_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            customers_Btn.FlatStyle = FlatStyle.Flat;
            customers_Btn.Font = new Font("Segoe UI", 12F);
            customers_Btn.ForeColor = Color.White;
            customers_Btn.Location = new Point(3, 451);
            customers_Btn.Name = "customers_Btn";
            customers_Btn.Size = new Size(217, 39);
            customers_Btn.TabIndex = 12;
            customers_Btn.Text = "Müşteriler";
            customers_Btn.UseVisualStyleBackColor = true;
            customers_Btn.Click += customers_Btn_Click;
            // 
            // addProducts_Btn
            // 
            addProducts_Btn.FlatAppearance.BorderSize = 0;
            addProducts_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            addProducts_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            addProducts_Btn.FlatStyle = FlatStyle.Flat;
            addProducts_Btn.Font = new Font("Segoe UI", 12F);
            addProducts_Btn.ForeColor = Color.White;
            addProducts_Btn.Location = new Point(3, 406);
            addProducts_Btn.Name = "addProducts_Btn";
            addProducts_Btn.Size = new Size(217, 39);
            addProducts_Btn.TabIndex = 11;
            addProducts_Btn.Text = "Ürün Ekle";
            addProducts_Btn.UseVisualStyleBackColor = true;
            addProducts_Btn.Click += addProducts_Btn_Click;
            // 
            // addCategory_Btn
            // 
            addCategory_Btn.FlatAppearance.BorderSize = 0;
            addCategory_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            addCategory_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            addCategory_Btn.FlatStyle = FlatStyle.Flat;
            addCategory_Btn.Font = new Font("Segoe UI", 12F);
            addCategory_Btn.ForeColor = Color.White;
            addCategory_Btn.Location = new Point(3, 361);
            addCategory_Btn.Name = "addCategory_Btn";
            addCategory_Btn.Size = new Size(217, 39);
            addCategory_Btn.TabIndex = 10;
            addCategory_Btn.Text = "Kategori Ekle";
            addCategory_Btn.UseVisualStyleBackColor = true;
            addCategory_Btn.Click += addCategory_Btn_Click;
            // 
            // addUsers_Btn
            // 
            addUsers_Btn.FlatAppearance.BorderSize = 0;
            addUsers_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            addUsers_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            addUsers_Btn.FlatStyle = FlatStyle.Flat;
            addUsers_Btn.Font = new Font("Segoe UI", 12F);
            addUsers_Btn.ForeColor = Color.White;
            addUsers_Btn.Location = new Point(3, 316);
            addUsers_Btn.Name = "addUsers_Btn";
            addUsers_Btn.Size = new Size(217, 39);
            addUsers_Btn.TabIndex = 9;
            addUsers_Btn.Text = "Kullanıcı Ekle";
            addUsers_Btn.UseVisualStyleBackColor = true;
            addUsers_Btn.Click += addUsers_Btn_Click;
            // 
            // dashboard_Btn
            // 
            dashboard_Btn.FlatAppearance.BorderSize = 0;
            dashboard_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            dashboard_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            dashboard_Btn.FlatStyle = FlatStyle.Flat;
            dashboard_Btn.Font = new Font("Segoe UI", 12F);
            dashboard_Btn.ForeColor = Color.White;
            dashboard_Btn.Location = new Point(3, 271);
            dashboard_Btn.Name = "dashboard_Btn";
            dashboard_Btn.Size = new Size(217, 39);
            dashboard_Btn.TabIndex = 8;
            dashboard_Btn.Text = "Kontrol Paneli";
            dashboard_Btn.UseVisualStyleBackColor = true;
            dashboard_Btn.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 160);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Hoşgeldiniz ,";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.man_icon__1_;
            pictureBox6.Location = new Point(72, 69);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 60);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(adminyonetici1);
            flowLayoutPanel3.Controls.Add(adminadduser1);
            flowLayoutPanel3.Controls.Add(adminAddCategory1);
            flowLayoutPanel3.Controls.Add(adminAddProducts1);
            flowLayoutPanel3.Controls.Add(cashierCustomerForm1);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(222, 46);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1125, 724);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // adminyonetici1
            // 
            adminyonetici1.Location = new Point(0, 0);
            adminyonetici1.Margin = new Padding(0);
            adminyonetici1.Name = "adminyonetici1";
            adminyonetici1.Size = new Size(1100, 728);
            adminyonetici1.TabIndex = 3;
            // 
            // adminadduser1
            // 
            adminadduser1.Location = new Point(19, 749);
            adminadduser1.Margin = new Padding(19, 21, 19, 21);
            adminadduser1.Name = "adminadduser1";
            adminadduser1.Size = new Size(6908, 5152);
            adminadduser1.TabIndex = 2;
            // 
            // adminAddCategory1
            // 
            adminAddCategory1.Location = new Point(19, 5943);
            adminAddCategory1.Margin = new Padding(19, 21, 19, 21);
            adminAddCategory1.Name = "adminAddCategory1";
            adminAddCategory1.Size = new Size(7053, 5095);
            adminAddCategory1.TabIndex = 1;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Font = new Font("Segoe UI", 9F);
            adminAddProducts1.Location = new Point(3, 11062);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1099, 729);
            adminAddProducts1.TabIndex = 0;
            // 
            // cashierCustomerForm1
            // 
            cashierCustomerForm1.Location = new Point(19, 11815);
            cashierCustomerForm1.Margin = new Padding(19, 21, 19, 21);
            cashierCustomerForm1.Name = "cashierCustomerForm1";
            cashierCustomerForm1.Size = new Size(6908, 5152);
            cashierCustomerForm1.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(44F, 106F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 770);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(close);
            Font = new Font("Segoe UI", 60F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(19, 21, 19, 21);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button close;
        private Panel panel1;
        private Button closes;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox6;
        private Label label1;
        private Button dashboard_Btn;
        private Button logout;
        private Button customers_Btn;
        private Button addProducts_Btn;
        private Button addCategory_Btn;
        private Button addUsers_Btn;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private adminyonetici adminyonetici1;
        private adminadduser adminadduser1;
        private AdminAddCategory adminAddCategory1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomerForm cashierCustomerForm1;
    }
}