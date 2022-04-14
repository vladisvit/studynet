namespace LoginProgram
{
    public partial class Program
    {
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
    }
}