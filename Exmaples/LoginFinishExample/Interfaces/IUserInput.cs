using LoginFinishExample.Models;

namespace LoginFinishExample.Interfaces
{
  internal interface IUserInput
  {
    Task<User> GetUserData();
  }
}
