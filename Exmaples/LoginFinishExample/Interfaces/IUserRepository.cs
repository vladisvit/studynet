using LoginFinishExample.Models;

namespace LoginFinishExample.Interfaces
{
  internal interface IUserRepository
  {
    Task<IEnumerable<User>> Users { get; }
  }
}
