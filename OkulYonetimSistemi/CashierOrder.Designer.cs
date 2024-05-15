namespace EnvanterYonetimSistemi
{
    partial class CashierOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            cashierOrder_clearBtn = new Button();
            cashierOrder_removeBtn = new Button();
            cashierOrder_addBtn = new Button();
            cashierOrder_qty = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            cashierOrder_prodName = new Label();
            cashierOrder_price = new Label();
            label4 = new Label();
            cashierOrder_prodID = new ComboBox();
            label3 = new Label();
            cashierOrder_category = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            cashierOrder_receipt = new Button();
            cashierOrder_payOrders = new Button();
            cashierOrder_change = new Label();
            label11 = new Label();
            cashierOrder_amount = new TextBox();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            cashierOrder_totalPrice = new Label();
            label12 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 342);
            panel1.TabIndex = 0;
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
            dataGridView1.Location = new Point(5, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(650, 300);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(19, 13);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 1;
            label1.Text = "Mevcut Ürünler";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cashierOrder_clearBtn);
            panel2.Controls.Add(cashierOrder_removeBtn);
            panel2.Controls.Add(cashierOrder_addBtn);
            panel2.Controls.Add(cashierOrder_qty);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cashierOrder_prodName);
            panel2.Controls.Add(cashierOrder_price);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cashierOrder_prodID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cashierOrder_category);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(658, 357);
            panel2.TabIndex = 1;
            // 
            // cashierOrder_clearBtn
            // 
            cashierOrder_clearBtn.Font = new Font("Segoe UI", 12F);
            cashierOrder_clearBtn.Location = new Point(350, 263);
            cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            cashierOrder_clearBtn.Size = new Size(112, 53);
            cashierOrder_clearBtn.TabIndex = 13;
            cashierOrder_clearBtn.Text = "Temizle";
            cashierOrder_clearBtn.UseVisualStyleBackColor = true;
            cashierOrder_clearBtn.Click += cashierOrder_clearBtn_Click;
            // 
            // cashierOrder_removeBtn
            // 
            cashierOrder_removeBtn.Font = new Font("Segoe UI", 12F);
            cashierOrder_removeBtn.Location = new Point(199, 263);
            cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            cashierOrder_removeBtn.Size = new Size(112, 53);
            cashierOrder_removeBtn.TabIndex = 12;
            cashierOrder_removeBtn.Text = "Kaldır";
            cashierOrder_removeBtn.UseVisualStyleBackColor = true;
            cashierOrder_removeBtn.Click += cashierOrder_removeBtn_Click;
            // 
            // cashierOrder_addBtn
            // 
            cashierOrder_addBtn.Font = new Font("Segoe UI", 12F);
            cashierOrder_addBtn.Location = new Point(36, 263);
            cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            cashierOrder_addBtn.Size = new Size(112, 53);
            cashierOrder_addBtn.TabIndex = 11;
            cashierOrder_addBtn.Text = "Ekle";
            cashierOrder_addBtn.UseVisualStyleBackColor = true;
            cashierOrder_addBtn.Click += cashierOrder_addBtn_Click;
            // 
            // cashierOrder_qty
            // 
            cashierOrder_qty.Location = new Point(510, 158);
            cashierOrder_qty.Name = "cashierOrder_qty";
            cashierOrder_qty.Size = new Size(120, 23);
            cashierOrder_qty.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(350, 158);
            label8.Name = "label8";
            label8.Size = new Size(154, 21);
            label8.TabIndex = 9;
            label8.Text = "Talep Edilen Miktar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.Location = new Point(25, 181);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 8;
            label7.Text = "Fiyat:";
            // 
            // cashierOrder_prodName
            // 
            cashierOrder_prodName.AutoSize = true;
            cashierOrder_prodName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            cashierOrder_prodName.Location = new Point(125, 122);
            cashierOrder_prodName.Name = "cashierOrder_prodName";
            cashierOrder_prodName.Size = new Size(76, 21);
            cashierOrder_prodName.TabIndex = 7;
            cashierOrder_prodName.Text = "Kategori:";
            // 
            // cashierOrder_price
            // 
            cashierOrder_price.AutoSize = true;
            cashierOrder_price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            cashierOrder_price.Location = new Point(125, 181);
            cashierOrder_price.Name = "cashierOrder_price";
            cashierOrder_price.Size = new Size(76, 21);
            cashierOrder_price.TabIndex = 7;
            cashierOrder_price.Text = "Kategori:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(22, 122);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 6;
            label4.Text = "Ürün İsmi";
            // 
            // cashierOrder_prodID
            // 
            cashierOrder_prodID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cashierOrder_prodID.FormattingEnabled = true;
            cashierOrder_prodID.Location = new Point(428, 30);
            cashierOrder_prodID.Name = "cashierOrder_prodID";
            cashierOrder_prodID.Size = new Size(197, 29);
            cashierOrder_prodID.TabIndex = 5;
            cashierOrder_prodID.SelectedIndexChanged += cashierOrder_prodID_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(350, 33);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 4;
            label3.Text = "Ürün ID:";
            // 
            // cashierOrder_category
            // 
            cashierOrder_category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cashierOrder_category.FormattingEnabled = true;
            cashierOrder_category.Location = new Point(100, 30);
            cashierOrder_category.Name = "cashierOrder_category";
            cashierOrder_category.Size = new Size(197, 29);
            cashierOrder_category.TabIndex = 3;
            cashierOrder_category.SelectedIndexChanged += cashierOrder_category_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(22, 33);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Kategori:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cashierOrder_receipt);
            panel3.Controls.Add(cashierOrder_payOrders);
            panel3.Controls.Add(cashierOrder_change);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(cashierOrder_amount);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(cashierOrder_totalPrice);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(687, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 705);
            panel3.TabIndex = 2;
            // 
            // cashierOrder_receipt
            // 
            cashierOrder_receipt.Font = new Font("Segoe UI", 12F);
            cashierOrder_receipt.Location = new Point(12, 637);
            cashierOrder_receipt.Name = "cashierOrder_receipt";
            cashierOrder_receipt.Size = new Size(345, 38);
            cashierOrder_receipt.TabIndex = 22;
            cashierOrder_receipt.Text = "Fiş";
            cashierOrder_receipt.UseVisualStyleBackColor = true;
            cashierOrder_receipt.Click += cashierOrder_receipt_Click;
            // 
            // cashierOrder_payOrders
            // 
            cashierOrder_payOrders.Font = new Font("Segoe UI", 12F);
            cashierOrder_payOrders.Location = new Point(12, 580);
            cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            cashierOrder_payOrders.Size = new Size(345, 38);
            cashierOrder_payOrders.TabIndex = 15;
            cashierOrder_payOrders.Text = "Ödeme";
            cashierOrder_payOrders.UseVisualStyleBackColor = true;
            cashierOrder_payOrders.Click += cashierOrder_payOrders_Click;
            // 
            // cashierOrder_change
            // 
            cashierOrder_change.AutoSize = true;
            cashierOrder_change.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            cashierOrder_change.Location = new Point(210, 506);
            cashierOrder_change.Name = "cashierOrder_change";
            cashierOrder_change.Size = new Size(41, 21);
            cashierOrder_change.TabIndex = 21;
            cashierOrder_change.Text = "0.00";
            cashierOrder_change.Click += cashierOrder_change_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label11.Location = new Point(95, 506);
            label11.Name = "label11";
            label11.Size = new Size(74, 21);
            label11.TabIndex = 20;
            label11.Text = "Değişim:";
            // 
            // cashierOrder_amount
            // 
            cashierOrder_amount.Font = new Font("Segoe UI", 12F);
            cashierOrder_amount.Location = new Point(162, 437);
            cashierOrder_amount.Name = "cashierOrder_amount";
            cashierOrder_amount.Size = new Size(129, 29);
            cashierOrder_amount.TabIndex = 19;
            cashierOrder_amount.KeyDown += cashierOrder_amount_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label9.Location = new Point(35, 445);
            label9.Name = "label9";
            label9.Size = new Size(121, 21);
            label9.TabIndex = 18;
            label9.Text = "Ödenen Miktar:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 13);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(345, 329);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // cashierOrder_totalPrice
            // 
            cashierOrder_totalPrice.AutoSize = true;
            cashierOrder_totalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            cashierOrder_totalPrice.Location = new Point(210, 386);
            cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            cashierOrder_totalPrice.Size = new Size(41, 21);
            cashierOrder_totalPrice.TabIndex = 16;
            cashierOrder_totalPrice.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label12.Location = new Point(95, 386);
            label12.Name = "label12";
            label12.Size = new Size(109, 21);
            label12.TabIndex = 15;
            label12.Text = "Toplam Fiyat:";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // CashierOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CashierOrder";
            Size = new Size(1099, 729);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView2;
        private Label label1;
        private NumericUpDown cashierOrder_qty;
        private Label label8;
        private Label label7;
        private Label cashierOrder_prodName;
        private Label cashierOrder_price;
        private Label label4;
        private ComboBox cashierOrder_prodID;
        private Label label3;
        private ComboBox cashierOrder_category;
        private Label label2;
        private Button button3;
        private Button cashierOrder_clearBtn;
        private Button cashierOrder_removeBtn;
        private Button cashierOrder_addBtn;
        private Button cashierOrder_receipt;
        private Button cashierOrder_payOrders;
        private Label cashierOrder_change;
        private Label label11;
        private TextBox cashierOrder_amount;
        private Label label9;
        private Label cashierOrder_totalPrice;
        private Label label12;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridView dataGridView1;
    }
}
