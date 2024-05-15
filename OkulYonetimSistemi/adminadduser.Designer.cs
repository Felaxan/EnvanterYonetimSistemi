namespace EnvanterYonetimSistemi
{
    partial class adminadduser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            addUsers_email = new TextBox();
            addUsers_password = new TextBox();
            addUsers_clearBtn = new Button();
            addUsers_removeBtn = new Button();
            addUsers_updateBtn = new Button();
            addUsers_addBtn = new Button();
            label4 = new Label();
            addUsers_status = new ComboBox();
            label3 = new Label();
            addUsers_role = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            addUsers_username = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(addUsers_email);
            panel1.Controls.Add(addUsers_password);
            panel1.Controls.Add(addUsers_clearBtn);
            panel1.Controls.Add(addUsers_removeBtn);
            panel1.Controls.Add(addUsers_updateBtn);
            panel1.Controls.Add(addUsers_addBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addUsers_status);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUsers_role);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(addUsers_username);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(18, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 628);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(18, 96);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 14;
            label6.Text = "Şifre";
            // 
            // addUsers_email
            // 
            addUsers_email.Font = new Font("Segoe UI", 12F);
            addUsers_email.Location = new Point(18, 120);
            addUsers_email.Name = "addUsers_email";
            addUsers_email.Size = new Size(217, 29);
            addUsers_email.TabIndex = 13;
            // 
            // addUsers_password
            // 
            addUsers_password.Font = new Font("Segoe UI", 12F);
            addUsers_password.Location = new Point(18, 189);
            addUsers_password.Name = "addUsers_password";
            addUsers_password.Size = new Size(217, 29);
            addUsers_password.TabIndex = 3;
            // 
            // addUsers_clearBtn
            // 
            addUsers_clearBtn.Font = new Font("Segoe UI", 12F);
            addUsers_clearBtn.Location = new Point(154, 490);
            addUsers_clearBtn.Name = "addUsers_clearBtn";
            addUsers_clearBtn.Size = new Size(112, 53);
            addUsers_clearBtn.TabIndex = 12;
            addUsers_clearBtn.Text = "Temizle";
            addUsers_clearBtn.UseVisualStyleBackColor = true;
            addUsers_clearBtn.Click += addUsers_clearBtn_Click;
            // 
            // addUsers_removeBtn
            // 
            addUsers_removeBtn.Font = new Font("Segoe UI", 12F);
            addUsers_removeBtn.Location = new Point(14, 490);
            addUsers_removeBtn.Name = "addUsers_removeBtn";
            addUsers_removeBtn.Size = new Size(112, 53);
            addUsers_removeBtn.TabIndex = 11;
            addUsers_removeBtn.Text = "Sil";
            addUsers_removeBtn.UseVisualStyleBackColor = true;
            addUsers_removeBtn.Click += addUsers_removeBtn_Click;
            // 
            // addUsers_updateBtn
            // 
            addUsers_updateBtn.Font = new Font("Segoe UI", 12F);
            addUsers_updateBtn.Location = new Point(154, 400);
            addUsers_updateBtn.Name = "addUsers_updateBtn";
            addUsers_updateBtn.Size = new Size(112, 53);
            addUsers_updateBtn.TabIndex = 10;
            addUsers_updateBtn.Text = "Güncelle";
            addUsers_updateBtn.UseVisualStyleBackColor = true;
            addUsers_updateBtn.Click += addUsers_updateBtn_Click;
            // 
            // addUsers_addBtn
            // 
            addUsers_addBtn.Font = new Font("Segoe UI", 12F);
            addUsers_addBtn.Location = new Point(14, 400);
            addUsers_addBtn.Name = "addUsers_addBtn";
            addUsers_addBtn.Size = new Size(112, 53);
            addUsers_addBtn.TabIndex = 9;
            addUsers_addBtn.Text = "Ekle";
            addUsers_addBtn.UseVisualStyleBackColor = true;
            addUsers_addBtn.Click += addUsers_addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(18, 307);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 8;
            label4.Text = "Durum";
            // 
            // addUsers_status
            // 
            addUsers_status.Font = new Font("Segoe UI", 12F);
            addUsers_status.FormattingEnabled = true;
            addUsers_status.Items.AddRange(new object[] { "Aktif", "İnaktif", "Onaylı" });
            addUsers_status.Location = new Point(18, 341);
            addUsers_status.Name = "addUsers_status";
            addUsers_status.Size = new Size(217, 29);
            addUsers_status.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 233);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 6;
            label3.Text = "Rol";
            // 
            // addUsers_role
            // 
            addUsers_role.Font = new Font("Segoe UI", 12F);
            addUsers_role.FormattingEnabled = true;
            addUsers_role.Items.AddRange(new object[] { "Admin", "Kasa" });
            addUsers_role.Location = new Point(18, 263);
            addUsers_role.Name = "addUsers_role";
            addUsers_role.Size = new Size(217, 29);
            addUsers_role.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 165);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // addUsers_username
            // 
            addUsers_username.Font = new Font("Segoe UI", 12F);
            addUsers_username.Location = new Point(18, 46);
            addUsers_username.Name = "addUsers_username";
            addUsers_username.Size = new Size(217, 29);
            addUsers_username.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(343, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 628);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(18, 14);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 13;
            label5.Text = "Kullanıcı Datası";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(18, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(709, 579);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // adminadduser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "adminadduser";
            Size = new Size(1099, 729);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox addUsers_username;
        private Label label1;
        private Label label4;
        private ComboBox addUsers_status;
        private Label label3;
        private ComboBox addUsers_role;
        private Label label2;
        private TextBox addUsers_password;
        private Button addUsers_clearBtn;
        private Button addUsers_removeBtn;
        private Button addUsers_updateBtn;
        private Button addUsers_addBtn;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private TextBox addUsers_email;
    }
}
