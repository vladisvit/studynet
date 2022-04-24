using LoginFinishExample.Models;

namespace LoginFinishExample.Interfaces
{
  internal interface IValidation
  {
    Task<bool> Validate(User user);
  }
}
