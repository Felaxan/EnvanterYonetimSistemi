using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvanterYonetimSistemi
{
   public class Degiskenler
    {
        private static string username;
        
        private static string email;
      
        private static string password;
        public static string getUsername()
        {
            return username;
        }
        public static void setUsername(string username)
        {
            Degiskenler.username = username;
        }
      
        public static string getMail()
        {
            return email;
        }
        public static void setMail(string email)
        {
            Degiskenler.email = email;
        }
       
        public static string getPassword()
        {
            return password;
        }
        public static void setPassword(string password)
        {
            Degiskenler.password = password;
        }

    }
}
