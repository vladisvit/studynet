using LoginFinishExample.Interfaces;
using LoginFinishExample.Models;

namespace LoginFinishExample.Services
{
  internal class LoginService : ILoginService
  {
    private const int DelayTimeMillsec = 1000;
    private const byte LoginAttempt = 3;
    private readonly IUserInput _userInput;
    private readonly IValidation _validation;

    public LoginService(IUserInput userInput, IValidation validation)
    {
      _userInput = userInput;
      _validation = validation;
    }

    public async Task LoginExecute()
    {
      for (int i = 0; i <= LoginAttempt; i++)
      {
        Console.ResetColor();
        var user = await _userInput.GetUserData().ConfigureAwait(false);

        if (user == null)
        {
          throw new Exception("No user data");
        }

        var lastedAttempt = (byte)(LoginAttempt - i);

        if (await AttemptValidate(user, lastedAttempt).ConfigureAwait(false))
        {
          Console.BackgroundColor = ConsoleColor.DarkGreen;
          Console.WriteLine($"Welcome back {user.Login}!");
          break;
        }
      }
    }

    private async Task<bool> AttemptValidate(User user, byte lastedAttempt)
    {
      var isValid = await _validation.Validate(user).ConfigureAwait(false);
      if (!isValid)
      {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Login failed...");
        if (lastedAttempt > 0)
        {
          Console.WriteLine($"Please, try again. You have {lastedAttempt} attempt{(lastedAttempt > 1 ? "s" : string.Empty)}");
          await Task.Delay(DelayTimeMillsec);
        }
      }

      return isValid;
    }
  }
}
