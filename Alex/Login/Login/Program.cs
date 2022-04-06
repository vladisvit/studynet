using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your login");
            DbUser user = new DbUser(Console.ReadLine());

            user.CheckLogin();

            Console.ReadKey();
        }
    }
}
