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
    public partial class CashierCustomerForm : UserControl
    {
        public CashierCustomerForm()
        {
            InitializeComponent();
            displayCustomers();
        }

        public void displayCustomers()
        {
            CustomersData cData = new CustomersData();
            List<CustomersData> listData = cData.allCustomers();
            dataGridView1.DataSource = listData;    
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomers();

        }
    }
}
