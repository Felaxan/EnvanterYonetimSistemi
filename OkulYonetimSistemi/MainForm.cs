namespace EnvanterYonetimSistemi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayUsername();
        }

        public void displayUsername()

        {

        }

        private void closes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            adminyonetici1.Visible = true;
            adminadduser1.Visible = false;
            adminAddCategory1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminyonetici adForm = adminyonetici1 as adminyonetici;

            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void addUsers_Btn_Click(object sender, EventArgs e)
        {
            adminyonetici1.Visible = false;
            adminadduser1.Visible = true;
            adminAddCategory1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            adminadduser adForm = adminadduser1 as adminadduser;
            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void addCategory_Btn_Click(object sender, EventArgs e)
        {
            adminyonetici1.Visible = false;
            adminadduser1.Visible = false;
            adminAddCategory1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            AdminAddCategory adForm = adminAddCategory1 as AdminAddCategory;
            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void addProducts_Btn_Click(object sender, EventArgs e)
        {
            adminyonetici1.Visible = false;
            adminadduser1.Visible = false;
            adminAddCategory1.Visible = false;
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
            adminadduser1.Visible = false;
            adminAddCategory1.Visible = false;
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

    
