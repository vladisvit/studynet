using LoginFinishExample.Interfaces;
using LoginFinishExample.Models;
using System.Text;

namespace LoginFinishExample.Services
{
  internal class UserInput : IUserInput
  {
    public async Task<User> GetUserData()
    {
      return await Task.Run(() =>
     {
       var user = new User();

       Console.WriteLine("Please input your login:");
       user.Login = Console.ReadLine();

       Console.WriteLine("Please input your password:");
       user.Password = GetUserPassword();

       return user;
     }).ConfigureAwait(false);
    }

    public string GetUserPassword()
    {
      var outputEncoding = Console.OutputEncoding;
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      StringBuilder passwordBuilder = new StringBuilder();

      char newLineChar = '\r';
      while (true)
      {
        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
        char passwordChar = consoleKeyInfo.KeyChar;

        if (passwordChar == newLineChar)
        {
          break;
        }
        Console.Write("\u2022");
        passwordBuilder.Append(passwordChar.ToString());
      }

      Console.OutputEncoding = outputEncoding;
      return passwordBuilder.ToString();
    }
  }
}
