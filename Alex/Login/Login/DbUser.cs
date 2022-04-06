using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class DbUser
    {
        static string[] Users = new string[] { "Admin", "MyPass", "User", "upass" };
        public string Username { get; set; }
        

        public string Password { get; set; }

        public DbUser(string username)
        {
            this.Username = username;
        }

        public void CheckLogin()
        {
            foreach(string login in Users)
            {
                if (login == this.Username)
                {
                    Console.WriteLine("Welcome, {0}", login);
                    Console.WriteLine("Please enter your password");
                    this.Password = (Console.ReadLine());
                    break;
                }
                else
                {
                    Console.WriteLine("Login incorrect. Let's good buy.");
                    break;
                }
            }
        }
    }
}
