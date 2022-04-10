using System;
public class Program
{
    public class LogPasMain
    {
        public string Usernick();
        public string Userpass();
    }
    public class DbUser
    {
        public static string[] Users = new string[] { "Admin", "MyPass", "User", "upass" };
    }
    static void Main()
    {
        Console.WriteLine("Hello fellow, ");

        Console.WriteLine("Please enter your login");
        var UsNi = new DbUser.Users;
        UsNi = Console.ReadLine();
        Console.WriteLine($"Your username is: {UsNi}");

        Console.WriteLine("And your password");
        var UsPs = new LogPasMain.Userpass();
        UsPs = Console.ReadLine();
        Console.WriteLine($"Your password is: {UsPs}");
    }
}