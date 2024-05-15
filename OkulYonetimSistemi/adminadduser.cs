using Microsoft.Data.SqlClient;
using System.Data;

namespace EnvanterYonetimSistemi
{
    public partial class adminadduser : UserControl
    {

        SqlConnection
        connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ayinr\OneDrive\Belgeler\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public void displayAllUsersData()
        {
            UseraData uData = new UseraData();

            List<UseraData> listdata = uData.AllUsersData();

            dataGridView1.DataSource = listdata;
        }
        public adminadduser()
        {
            InitializeComponent();

            displayAllUsersData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAllUsersData();
        }


        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_role.SelectedIndex == -1)
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

                        string checkUsername = "SELECT * FROM users WHERE username = @usern";
                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(addUsers_username.Text.Trim() + "Bu zaten alındı", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username,password,role,status,date,email)" + " VALUES(@usern,@pass,@role,@status,@date,@email)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", addUsers_email.Text.Trim());
                                    insertD.Parameters.AddWithValue("@email", addUsers_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);
                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAllUsersData();

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
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_email.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_role.SelectedIndex == -1)
            {
                MessageBox.Show("Boş Bırakmayınız !", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Kullanıcıyı Güncelllemek istediğinize emin misiniz ? Kullanıcı ID: " + getID +"?","Onay Mesajı",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
                {

                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                                string updateData = "UPDATE users SET username = @usern," + "email=@email, password=@pass,role = @role , status = @status WHERE id =@id";

                                using (SqlCommand updateD = new SqlCommand(updateData, connect)) 
                                {
                                    updateD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                    updateD.Parameters.AddWithValue("@pass", addUsers_email.Text.Trim());
                                    updateD.Parameters.AddWithValue("@email", addUsers_password.Text.Trim());
                                    updateD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                    updateD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                                    updateD.Parameters.AddWithValue("@id", getID);

                                     updateD.ExecuteNonQuery();
                                     displayAllUsersData();
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

        private void addUsers_removeBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_role.SelectedIndex == -1)
            {
                MessageBox.Show("Boş Bırakmayınız !", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz ? Kullanıcı ID: " + getID + "?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "DELETE FROM users WHERE id =@id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                               
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                displayAllUsersData();
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
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                string username = row.Cells[1].Value.ToString();
                string email = row.Cells[2].Value.ToString();
                string password = row.Cells[3].Value.ToString();
                string role = row.Cells[4].Value.ToString();
                string status = row.Cells[5].Value.ToString();

                addUsers_username.Text = username;
                addUsers_password.Text = email;
                addUsers_email.Text = password;
                addUsers_role.Text = role;
                addUsers_status.Text = status;

            }
        }
    }
}
