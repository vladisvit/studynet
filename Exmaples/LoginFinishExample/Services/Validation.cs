using LoginFinishExample.Interfaces;
using LoginFinishExample.Models;

namespace LoginFinishExample.Services
{
  internal class Validation : IValidation
  {
    private readonly IUserRepository repository;

    public Validation(IUserRepository userRepository)
    {
      repository = userRepository;
    }

    public async Task<bool> Validate(User user)
    {
      var users = await repository.Users.ConfigureAwait(false);

      return users.Any(u => u.Equals(user));
    }
  }
}
