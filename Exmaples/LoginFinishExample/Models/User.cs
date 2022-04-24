using LoginFinishExample.Interfaces;

namespace LoginFinishExample.Models
{
  internal class User : IUser, IEquatable<User>
  {
    public string? Login { get; set; }
    public string? Password { get; set; }

    public bool Equals(User? other)
    {
      if (other == null || other is not User)
      {
        return false;
      }

      if (ReferenceEquals(this, other))
      {
        return true;
      }

      if (!string.Equals(Login, other.Login) || !string.Equals(Password, other.Password))
      {
        return false;
      }

      return true;
    }
  }
}
