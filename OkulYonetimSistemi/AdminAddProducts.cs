using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace EnvanterYonetimSistemi
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection
        connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ayinr\OneDrive\Belgeler\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public AdminAddProducts()
        {
            InitializeComponent();
            displayCategories();
            displayAllProducts();
        }

        public void displayAllProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllProductsData();
            dataGridView1.DataSource = listData;
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategories();
            displayAllProducts();
        }
        


        public bool EmptyFiels()
        {
            if (addProducts_prodID.Text == "" || addProducts_prodName.Text == "" || addProducts_category.SelectedIndex == -1 || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM categories";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                addProducts_category.Items.Add(reader["category"].ToString());
                                addProducts_category.Refresh();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından veri alınırken bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }




        }

        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (EmptyFiels())
            {
                MessageBox.Show("Boş alan bırkamayın", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products WHERE prod_id = @prodID";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Ürün ID: " + addProducts_prodID.Text.Trim() + "Bu zaten var!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {



                            string insertData = "INSERT INTO " +
                                "products(prod_id,prod_name,category,price,stock,status,date_insert)"
                                + " VALUES(@prodID,@prodName,@cat,@price,@stock,@status,@date)";
                            using (SqlCommand insertD = new SqlCommand(insertData, connect))
                            {
                                insertD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                insertD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                insertD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem.ToString());
                                insertD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                insertD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                insertD.Parameters.AddWithValue("@status", addProducts_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                insertD.Parameters.AddWithValue("@date", today);
                                insertD.ExecuteNonQuery();
                                clearFields();
                                displayAllProducts();


                                MessageBox.Show("Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



                            }
                        }
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı Hatası", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }

            }
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void clearFields()
        {
            addProducts_prodID.Text = "";
            addProducts_prodName.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_price.Text = "";
            addProducts_stock.Text = "";
            addProducts_status.SelectedIndex = -1;

        }
        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_prodName.Text = row.Cells[2].Value.ToString();
                addProducts_category.Text = row.Cells[3].Value.ToString();
                addProducts_price.Text = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();
                addProducts_status.Text = row.Cells[6].Value.ToString();

            }
        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (EmptyFiels())
            {
                MessageBox.Show("Boş alan bırkamayın", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                if (MessageBox.Show("Ürünü Güncellemek istediğinize emin misiniz ? Ürün ID: " + addProducts_prodID.Text.Trim() + "?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE products SET prod_id = @prodID, prod_name = @prodName, category = @cat ,price= @price, stock=@stock , status= @status WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                updateD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                updateD.Parameters.AddWithValue("@status", addProducts_status.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllProducts();



                                MessageBox.Show("Başarıyla Güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bağlantı Hatası", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            connect.Close();
                        }

                    }
                }
            }
        }

        private void addProducts_removeBtn_Click(object sender, EventArgs e)
        {
            if (EmptyFiels())
            {
                MessageBox.Show("Boş Bırakmayınız !", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Kategoriyi silmek istediğinize emin misiniz ? Kullanıcı ID: " + getID + "?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string DeleteData = "DELETE FROM products WHERE id =@id";

                            using (SqlCommand DeleteD= new SqlCommand(DeleteData, connect))
                            {

                                DeleteD.Parameters.AddWithValue("@id", getID);

                                DeleteD.ExecuteNonQuery();
                                displayAllProducts();
                                clearFields();



                                MessageBox.Show("Başarıyla Silindi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bağlantı Hatası", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            connect.Close();
                        }

                    }
                }
            }
        }
    }


}
