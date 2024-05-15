using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYonetimSistemi
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
            displayUsername();
        }
        public void displayUsername()

        {
         
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 LoginForm = new Form1();
                LoginForm.Show();
                this.Hide();
            }
        }

        private void closes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_Btn_Click(object sender, EventArgs e)
        {
            adminyonetici1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierOrder1.Visible = false;
            cashierCustomerForm1.Visible = false;


            adminyonetici adForm = adminyonetici1 as adminyonetici;

            if (adForm != null)
            {
                adForm.refreshData();
            }

        }

        private void addCategory_Btn_Click(object sender, EventArgs e)
        {
            adminyonetici1.Visible = false;
            cashierOrder1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomerForm1.Visible = false;


            AdminAddProducts adForm = adminAddProducts1 as AdminAddProducts;
            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void customers_Btn_Click(object sender, EventArgs e)
        {
            adminyonetici1.Visible = false;
            cashierOrder1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;


            CashierOrder adForm = cashierOrder1 as CashierOrder;
            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void cashierOrder1_Load(object sender, EventArgs e)
        {

        }

        private void addProducts_Btn_Click(object sender, EventArgs e)
        {
            adminyonetici1.Visible = false;
            cashierOrder1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = true;


            CashierCustomerForm adForm = cashierCustomerForm1 as CashierCustomerForm;
            if (adForm != null)
            {
                adForm.refreshData();
            }
        }
    }
}
