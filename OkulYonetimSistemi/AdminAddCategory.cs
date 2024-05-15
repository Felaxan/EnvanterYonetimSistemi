using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace EnvanterYonetimSistemi
{
    public partial class AdminAddCategory : UserControl
    {


        SqlConnection
        connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ayinr\OneDrive\Belgeler\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");




        public AdminAddCategory()
        {
            InitializeComponent();

            displayCategoriesData();
        }



        public void displayCategoriesData()
        {
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listData = cData.AllCategoriesData();

            dataGridView1.DataSource = listData;
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoriesData();
        }


        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız !", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkCat = "SELECT * FROM categories WHERE category = @cat";
                        using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(addCategories_category.Text.Trim() + "Bu zaten alındı", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO categories (category,date) VALUES(@cat,@date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    displayCategoriesData();
                                    clearFields();
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
            addCategories_category.Text = "";
        }

        private void addCategories_clearBtn_Click(object sender, EventArgs e)
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
                addCategories_category.Text = row.Cells[1].Value.ToString();
            }
        }

        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız !", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Kategoriyi Güncellemek istediğinize emin misiniz ? Kategori ID: " + getID + "?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE categories SET category = @cat WHERE id =@id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());

                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                displayCategoriesData();
                                clearFields();



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

        private void addCategories_removeBtn_Click(object sender, EventArgs e)
        {

            if (addCategories_category.Text == "" )
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

                            string updateData = "DELETE FROM categories WHERE id =@id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {

                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                displayCategoriesData();
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
