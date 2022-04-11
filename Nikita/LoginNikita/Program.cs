using System;

public class Program
{
    internal class LogPasMain
    {
        public string Usernick;
        public string Userpass;
    }

    internal class DbUser
    {
        public static string[] Users = new string[] { "Admin", "MyPass", "User", "upass" };
    }

    internal class UserValidation
    {
        public bool Validation(LogPasMain user)
        {
            for (int i = 0; i < DbUser.Users.Length; i++)
            {
                if (user.Usernick.Equals(DbUser.Users[i]) && user.Userpass.Equals(DbUser.Users[++i]))
                {
                    return true;
                }
            }
            return false;
        }
    }

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

        var userValidation = new UserValidation(); //create an object 'userValidation' of UserValidaion type
        if (userValidation.Validation(user))
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Login!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Login failed");
        }
    }
}