namespace EnvanterYonetimSistemi
{
    partial class CashierMainForm
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
            dashboard_Btn = new Button();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            adminyonetici1 = new adminyonetici();
            adminAddProducts1 = new AdminAddProducts();
            cashierCustomerForm1 = new CashierCustomerForm();
            cashierOrder1 = new CashierOrder();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 9;
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
            label4.Size = new Size(321, 18);
            label4.TabIndex = 6;
            label4.Text = "Envanter Yönetim Sistemi  | Kasa Paneli";
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
            panel2.Controls.Add(dashboard_Btn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 724);
            panel2.TabIndex = 10;
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
            customers_Btn.Location = new Point(2, 406);
            customers_Btn.Name = "customers_Btn";
            customers_Btn.Size = new Size(217, 39);
            customers_Btn.TabIndex = 12;
            customers_Btn.Text = "Sipariş";
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
            addProducts_Btn.Location = new Point(3, 361);
            addProducts_Btn.Name = "addProducts_Btn";
            addProducts_Btn.Size = new Size(217, 39);
            addProducts_Btn.TabIndex = 11;
            addProducts_Btn.Text = "Müşteriler";
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
            addCategory_Btn.Location = new Point(3, 316);
            addCategory_Btn.Name = "addCategory_Btn";
            addCategory_Btn.Size = new Size(217, 39);
            addCategory_Btn.TabIndex = 10;
            addCategory_Btn.Text = "Ürün Ekle";
            addCategory_Btn.UseVisualStyleBackColor = true;
            addCategory_Btn.Click += addCategory_Btn_Click;
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
            dashboard_Btn.Click += dashboard_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 162);
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
            // panel3
            // 
            panel3.Controls.Add(adminyonetici1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierCustomerForm1);
            panel3.Controls.Add(cashierOrder1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(222, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(1125, 724);
            panel3.TabIndex = 11;
            // 
            // adminyonetici1
            // 
            adminyonetici1.Location = new Point(0, -1);
            adminyonetici1.Name = "adminyonetici1";
            adminyonetici1.Size = new Size(1125, 725);
            adminyonetici1.TabIndex = 3;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Font = new Font("Segoe UI", 9F);
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1099, 729);
            adminAddProducts1.TabIndex = 2;
            // 
            // cashierCustomerForm1
            // 
            cashierCustomerForm1.Location = new Point(0, -1);
            cashierCustomerForm1.Name = "cashierCustomerForm1";
            cashierCustomerForm1.Size = new Size(1099, 725);
            cashierCustomerForm1.TabIndex = 1;
            // 
            // cashierOrder1
            // 
            cashierOrder1.Location = new Point(0, -1);
            cashierOrder1.Name = "cashierOrder1";
            cashierOrder1.Size = new Size(1099, 729);
            cashierOrder1.TabIndex = 0;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 770);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private Button closes;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button logout;
        private Button customers_Btn;
        private Button addProducts_Btn;
        private Button addCategory_Btn;
        private Button dashboard_Btn;
        private Label label1;
        private PictureBox pictureBox6;
        private Panel panel3;
        private adminyonetici adminyonetici1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomerForm cashierCustomerForm1;
        private CashierOrder cashierOrder1;
    }
}