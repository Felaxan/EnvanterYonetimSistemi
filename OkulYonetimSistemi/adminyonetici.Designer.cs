namespace EnvanterYonetimSistemi
{
    partial class adminyonetici
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
            panel4 = new Panel();
            label9 = new Label();
            dashboard_totalIncome = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dashboard_AU = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label7 = new Label();
            dashboard_TI = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            dashboard_AC = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.RosyBrown;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(dashboard_totalIncome);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(800, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 138);
            panel4.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(128, 103);
            label9.Name = "label9";
            label9.Size = new Size(97, 21);
            label9.TabIndex = 9;
            label9.Text = "Toplam Gelir";
            // 
            // dashboard_totalIncome
            // 
            dashboard_totalIncome.AutoSize = true;
            dashboard_totalIncome.Font = new Font("Segoe UI", 12F);
            dashboard_totalIncome.ForeColor = Color.White;
            dashboard_totalIncome.Location = new Point(128, 11);
            dashboard_totalIncome.Name = "dashboard_totalIncome";
            dashboard_totalIncome.Size = new Size(49, 21);
            dashboard_totalIncome.TabIndex = 8;
            dashboard_totalIncome.Text = "₺0.00";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pngegg__1_;
            pictureBox4.Location = new Point(12, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(110, 100);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dataGridView1);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(26, 254);
            panel6.Name = "panel6";
            panel6.Size = new Size(1055, 455);
            panel6.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(20, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1020, 399);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(38, 16);
            label1.Name = "label1";
            label1.Size = new Size(197, 21);
            label1.TabIndex = 1;
            label1.Text = "Bugün ki Tüm Müşteriler";
            // 
            // dashboard_AU
            // 
            dashboard_AU.AutoSize = true;
            dashboard_AU.Font = new Font("Segoe UI", 12F);
            dashboard_AU.ForeColor = Color.White;
            dashboard_AU.Location = new Point(134, 11);
            dashboard_AU.Name = "dashboard_AU";
            dashboard_AU.Size = new Size(19, 21);
            dashboard_AU.TabIndex = 2;
            dashboard_AU.Text = "0";
            dashboard_AU.Click += dashboard_AU_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngegg__4_1;
            pictureBox1.Location = new Point(17, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 100);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.RosyBrown;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(dashboard_TI);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(548, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 138);
            panel5.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(133, 103);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 7;
            label7.Text = "Günün Geliri";
            // 
            // dashboard_TI
            // 
            dashboard_TI.AutoSize = true;
            dashboard_TI.Font = new Font("Segoe UI", 12F);
            dashboard_TI.ForeColor = Color.White;
            dashboard_TI.Location = new Point(133, 11);
            dashboard_TI.Name = "dashboard_TI";
            dashboard_TI.Size = new Size(49, 21);
            dashboard_TI.TabIndex = 6;
            dashboard_TI.Text = "₺0.00";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngegg__3_1;
            pictureBox3.Location = new Point(16, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 100);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(133, 103);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 3;
            label3.Text = "Tüm Kullanıcılar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(133, 103);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 5;
            label5.Text = "Tüm Müşteriler";
            // 
            // dashboard_AC
            // 
            dashboard_AC.AutoSize = true;
            dashboard_AC.Font = new Font("Segoe UI", 12F);
            dashboard_AC.ForeColor = Color.White;
            dashboard_AC.Location = new Point(133, 11);
            dashboard_AC.Name = "dashboard_AC";
            dashboard_AC.Size = new Size(19, 21);
            dashboard_AC.TabIndex = 4;
            dashboard_AC.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngegg__5_2;
            pictureBox2.Location = new Point(16, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 100);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dashboard_AC);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(283, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 138);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dashboard_AU);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 138);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(17, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 189);
            panel1.TabIndex = 6;
            // 
            // adminyonetici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "adminyonetici";
            Size = new Size(1099, 729);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Label label9;
        private Label dashboard_totalIncome;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Label label1;
        private Label dashboard_AU;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label7;
        private Label dashboard_TI;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label5;
        private Label dashboard_AC;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}
