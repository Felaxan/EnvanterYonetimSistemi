using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace EnvanterYonetimSistemi
{
    internal class UseraData
    {
        public int ID { set; get; }

        public string Username {  set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
        
        public string Role { set; get; }
        public string Status { set; get; }

        public string Date { set; get; }



        public List<UseraData> AllUsersData()
        {
            List<UseraData> listData = new List<UseraData>();

            using(SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ayinr\OneDrive\Belgeler\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"))
            {
                connect.Open();
                string selectData = "SELECT * FROM users";


                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UseraData uData = new UseraData();
                        uData.ID = (int)reader["id"];
                        uData.Username = reader["username"].ToString();
                        uData.Password = reader["password"].ToString();
                        uData.Email = reader["email"].ToString();
                        uData.Role = reader["role"].ToString();
                        uData.Status = reader["status"].ToString();
                        uData.Date = reader["date"].ToString();


                        listData.Add(uData);

                    }
                }
            }
            return listData;
        }


    }
}
