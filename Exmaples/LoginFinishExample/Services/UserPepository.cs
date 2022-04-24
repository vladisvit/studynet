using LoginFinishExample.Interfaces;
using LoginFinishExample.Models;

namespace LoginFinishExample.Services
{
  internal class UserPepository : IUserRepository
  {
    public Task<IEnumerable<User>> Users => Task.Run(() => new List<User> {
      new User { Login = "Admin", Password = "Pass"},
      new User { Login = "User", Password = "UPass"}}.AsEnumerable());
  }
}