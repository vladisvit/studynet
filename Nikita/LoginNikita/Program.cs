using System;

namespace LoginProgram
{
    public partial class Program
    {

        static void Main()
        {
            var user = new LogPasMain(); //create an object 'user' of LogPasMain 
            Console.WriteLine("Hello fellow, ");

            Console.WriteLine("Please enter your login");

            var userNickName = Console.ReadLine();
            Console.WriteLine($"Your username is: {userNickName}");

            Console.WriteLine("And your password");
            var userPassword = Console.ReadLine();
            Console.WriteLine($"Your password is: {userPassword}");
            user.Usernick = userNickName ?? string.Empty;
            user.Userpass = userPassword ?? string.Empty;
            Thread.Sleep(1000);
            Console.Clear();
            //--NEW TIMER-- (NOT DONE)
            //await Task.Run(() =>
            //{
            //    int loop = 0;
            //     for (loop = 0; loop <= 1000; loop++);
            //     { }
            //     Console.WriteLine("PLEASE WAIT{0}", loop);
            // });

            //--OLD TIMER--
            // static void TimerCallback(Object o) => Console.Write(".");
            //Console.Write("PLEASE WAIT");
            //Timer t = new Timer(TimerCallback, null, 0, 1000);
            //Thread.Sleep(6000);
            //t.Dispose();
            //Console.Clear();
            //Console.ResetColor();

            var userValidation = new UserValidation(); //create an object 'userValidation' of UserValidaion type
            if (userValidation.Validation(user))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Login success!");
                Console.ResetColor();
                Console.WriteLine("Welcome back! Press enter to exit.");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Login failed...");
                Console.WriteLine("Please, try again.");
                while (Console.KeyAvailable) Console.ReadKey(true);
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();      
                //goto LoginStep;
            }
            while (Console.KeyAvailable) Console.ReadKey(true);
            Console.ReadKey();
        }
    }
}