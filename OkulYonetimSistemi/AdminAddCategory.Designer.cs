namespace EnvanterYonetimSistemi
{
    partial class AdminAddCategory
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
            dataGridView1 = new DataGridView();
            addCategories_clearBtn = new Button();
            addCategories_removeBtn = new Button();
            addCategories_updateBtn = new Button();
            addCategories_addBtn = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label1 = new Label();
            addCategories_category = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // addCategories_clearBtn
            // 
            addCategories_clearBtn.Font = new Font("Segoe UI", 12F);
            addCategories_clearBtn.Location = new Point(158, 221);
            addCategories_clearBtn.Name = "addCategories_clearBtn";
            addCategories_clearBtn.Size = new Size(112, 53);
            addCategories_clearBtn.TabIndex = 12;
            addCategories_clearBtn.Text = "Temizle";
            addCategories_clearBtn.UseVisualStyleBackColor = true;
            addCategories_clearBtn.Click += addCategories_clearBtn_Click;
            // 
            // addCategories_removeBtn
            // 
            addCategories_removeBtn.Font = new Font("Segoe UI", 12F);
            addCategories_removeBtn.Location = new Point(18, 221);
            addCategories_removeBtn.Name = "addCategories_removeBtn";
            addCategories_removeBtn.Size = new Size(112, 53);
            addCategories_removeBtn.TabIndex = 11;
            addCategories_removeBtn.Text = "Sil";
            addCategories_removeBtn.UseVisualStyleBackColor = true;
            addCategories_removeBtn.Click += addCategories_removeBtn_Click;
            // 
            // addCategories_updateBtn
            // 
            addCategories_updateBtn.Font = new Font("Segoe UI", 12F);
            addCategories_updateBtn.Location = new Point(158, 131);
            addCategories_updateBtn.Name = "addCategories_updateBtn";
            addCategories_updateBtn.Size = new Size(112, 53);
            addCategories_updateBtn.TabIndex = 10;
            addCategories_updateBtn.Text = "Güncelle";
            addCategories_updateBtn.UseVisualStyleBackColor = true;
            addCategories_updateBtn.Click += addCategories_updateBtn_Click;
            // 
            // addCategories_addBtn
            // 
            addCategories_addBtn.Font = new Font("Segoe UI", 12F);
            addCategories_addBtn.Location = new Point(18, 131);
            addCategories_addBtn.Name = "addCategories_addBtn";
            addCategories_addBtn.Size = new Size(112, 53);
            addCategories_addBtn.TabIndex = 9;
            addCategories_addBtn.Text = "Ekle";
            addCategories_addBtn.UseVisualStyleBackColor = true;
            addCategories_addBtn.Click += addCategories_addBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(341, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 628);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(18, 14);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 13;
            label5.Text = "Tüm Kategoriler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 2;
            label1.Text = "Kategori";
            // 
            // addCategories_category
            // 
            addCategories_category.Font = new Font("Segoe UI", 12F);
            addCategories_category.Location = new Point(18, 46);
            addCategories_category.Name = "addCategories_category";
            addCategories_category.Size = new Size(217, 29);
            addCategories_category.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addCategories_clearBtn);
            panel1.Controls.Add(addCategories_removeBtn);
            panel1.Controls.Add(addCategories_updateBtn);
            panel1.Controls.Add(addCategories_addBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(addCategories_category);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(16, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 628);
            panel1.TabIndex = 2;
            // 
            // AdminAddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddCategory";
            Size = new Size(1099, 729);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addCategories_clearBtn;
        private Button addCategories_removeBtn;
        private Button addCategories_updateBtn;
        private Button addCategories_addBtn;
        private Panel panel2;
        private Label label5;
        private Label label1;
        private TextBox addCategories_category;
        private Panel panel1;
    }
}
