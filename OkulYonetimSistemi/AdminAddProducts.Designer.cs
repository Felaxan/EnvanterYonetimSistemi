namespace EnvanterYonetimSistemi
{
    partial class AdminAddProducts
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            addProducts_clearBtn = new Button();
            addProducts_removeBtn = new Button();
            addProducts_updateBtn = new Button();
            addProducts_addBtn = new Button();
            label7 = new Label();
            addProducts_status = new ComboBox();
            addProducts_stock = new TextBox();
            label6 = new Label();
            addProducts_price = new TextBox();
            label5 = new Label();
            label4 = new Label();
            addProducts_category = new ComboBox();
            addProducts_prodName = new TextBox();
            label3 = new Label();
            addProducts_prodID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 347);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 1;
            label1.Text = "Tüm Ürünler";
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
            dataGridView1.Location = new Point(12, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1050, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(addProducts_clearBtn);
            panel2.Controls.Add(addProducts_removeBtn);
            panel2.Controls.Add(addProducts_updateBtn);
            panel2.Controls.Add(addProducts_addBtn);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(addProducts_status);
            panel2.Controls.Add(addProducts_stock);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addProducts_price);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addProducts_category);
            panel2.Controls.Add(addProducts_prodName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addProducts_prodID);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(1075, 303);
            panel2.TabIndex = 1;
            // 
            // addProducts_clearBtn
            // 
            addProducts_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            addProducts_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            addProducts_clearBtn.Location = new Point(489, 228);
            addProducts_clearBtn.Name = "addProducts_clearBtn";
            addProducts_clearBtn.Size = new Size(98, 40);
            addProducts_clearBtn.TabIndex = 17;
            addProducts_clearBtn.Text = "Clear";
            addProducts_clearBtn.UseVisualStyleBackColor = true;
            addProducts_clearBtn.Click += addProducts_clearBtn_Click;
            // 
            // addProducts_removeBtn
            // 
            addProducts_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            addProducts_removeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            addProducts_removeBtn.Location = new Point(353, 228);
            addProducts_removeBtn.Name = "addProducts_removeBtn";
            addProducts_removeBtn.Size = new Size(98, 40);
            addProducts_removeBtn.TabIndex = 16;
            addProducts_removeBtn.Text = "Remove";
            addProducts_removeBtn.UseVisualStyleBackColor = true;
            addProducts_removeBtn.Click += addProducts_removeBtn_Click;
            // 
            // addProducts_updateBtn
            // 
            addProducts_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            addProducts_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            addProducts_updateBtn.Location = new Point(182, 228);
            addProducts_updateBtn.Name = "addProducts_updateBtn";
            addProducts_updateBtn.Size = new Size(98, 40);
            addProducts_updateBtn.TabIndex = 15;
            addProducts_updateBtn.Text = "Update";
            addProducts_updateBtn.UseVisualStyleBackColor = true;
            addProducts_updateBtn.Click += addProducts_updateBtn_Click;
            // 
            // addProducts_addBtn
            // 
            addProducts_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 180);
            addProducts_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 180, 180);
            addProducts_addBtn.Location = new Point(56, 228);
            addProducts_addBtn.Name = "addProducts_addBtn";
            addProducts_addBtn.Size = new Size(98, 40);
            addProducts_addBtn.TabIndex = 14;
            addProducts_addBtn.Text = "Add";
            addProducts_addBtn.UseVisualStyleBackColor = true;
            addProducts_addBtn.Click += addProducts_addBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(386, 153);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 11;
            label7.Text = "Durum:";
            // 
            // addProducts_status
            // 
            addProducts_status.Font = new Font("Segoe UI", 12F);
            addProducts_status.FormattingEnabled = true;
            addProducts_status.Items.AddRange(new object[] { "Mevcut", "Mevcut Değil" });
            addProducts_status.Location = new Point(439, 145);
            addProducts_status.Name = "addProducts_status";
            addProducts_status.Size = new Size(170, 29);
            addProducts_status.TabIndex = 10;
            // 
            // addProducts_stock
            // 
            addProducts_stock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addProducts_stock.Location = new Point(439, 94);
            addProducts_stock.Name = "addProducts_stock";
            addProducts_stock.Size = new Size(135, 29);
            addProducts_stock.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(400, 102);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 8;
            label6.Text = "Stok:";
            // 
            // addProducts_price
            // 
            addProducts_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addProducts_price.Location = new Point(439, 40);
            addProducts_price.Name = "addProducts_price";
            addProducts_price.Size = new Size(135, 29);
            addProducts_price.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(384, 48);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 6;
            label5.Text = "Fiyat(₺):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(25, 153);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Kategori:";
            // 
            // addProducts_category
            // 
            addProducts_category.Font = new Font("Segoe UI", 12F);
            addProducts_category.FormattingEnabled = true;
            addProducts_category.Location = new Point(85, 145);
            addProducts_category.Name = "addProducts_category";
            addProducts_category.Size = new Size(170, 29);
            addProducts_category.TabIndex = 4;
            // 
            // addProducts_prodName
            // 
            addProducts_prodName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addProducts_prodName.Location = new Point(85, 94);
            addProducts_prodName.Name = "addProducts_prodName";
            addProducts_prodName.Size = new Size(170, 29);
            addProducts_prodName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(18, 102);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Ürün İsmi:";
            // 
            // addProducts_prodID
            // 
            addProducts_prodID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addProducts_prodID.Location = new Point(85, 40);
            addProducts_prodID.Name = "addProducts_prodID";
            addProducts_prodID.Size = new Size(135, 29);
            addProducts_prodID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(29, 48);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "Ürün ID:";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            Name = "AdminAddProducts";
            Size = new Size(1099, 729);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label4;
        private ComboBox addProducts_category;
        private TextBox addProducts_prodName;
        private Label label3;
        private TextBox addProducts_prodID;
        private Label label2;
        private Label label7;
        private ComboBox addProducts_status;
        private TextBox addProducts_stock;
        private Label label6;
        private TextBox addProducts_price;
        private Label label5;
        private Button addProducts_clearBtn;
        private Button addProducts_removeBtn;
        private Button addProducts_updateBtn;
        private Button addProducts_addBtn;
    }
}
