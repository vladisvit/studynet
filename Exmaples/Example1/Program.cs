using System;

namespace Example1
{
    class Program
    {
        public class User
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public class UserInput
        {
            public UserInput(User user)
            {
                UserData = user;
            }

            public User UserData { get; private set; }

            public void DoInput()
            {
                UserData.UserName = GetUserData("Please input login");
                UserData.Password = GetUserData("Please input password");
            }

            private string GetUserData(string inputTitle)
            {
                Console.WriteLine(inputTitle);

                return Console.ReadLine();
            }

        }

        public class UserValidation
        {
            private class DbUser
            {
                //public static string[] Users = new string[] { "Admin", "MyPass", "User", "upass" };
                public static User[] NewUsers = new User[] {
                    new User { UserName = "Admin", Password = "MyPass" },
                    new User { UserName = "User", Password = "upass" } };
            }

            public bool Validation(User user)
            {
                bool result = false;
                if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
                {
                    return result;
                }

                for (int index = 0; index < DbUser.NewUsers.Length; index++)
                {
                    var arrUser = DbUser.NewUsers[index];

                    if (user.UserName == arrUser.UserName && user.Password == arrUser.Password)
                    {
                        result = true;
                        break;
                    }
                }

                return result;
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Login");

            var user = new User();

            var userInput = new UserInput(user);
            userInput.DoInput();

            var userValidation = new UserValidation();

            if (userValidation.Validation(user))
            {
                Console.WriteLine("You are login");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }
    }
}
