using WebApi.Models;

namespace WebApi.Repositories
{
    public static class UserRepository
    {
        private static List<User> users = new List<User>()
        {
        new User {id=1,name="behnam",email="test",password="t" }
        };

       public static List<User> GetUsers()
        {
            return users;
        }

        public static void AddUser(User user)
        {
            users.Add(user);
        }
        public static SignedUser getUser(string email,string password)
        {
            Console.WriteLine("this is a dample {0}",users);
            var user= users.FirstOrDefault(x => x.email == email && x.password == password);
            Guid g = Guid.NewGuid();
            string GuidString = Convert.ToBase64String(g.ToByteArray());
            GuidString = GuidString.Replace("=", "");
            GuidString = GuidString.Replace("+", "");
            GuidString = GuidString.Replace("/", "");

            var signedUser = new SignedUser();
            if (user != null)
            {
                signedUser.id = user.id;
                signedUser.name = user.name;
                signedUser.email = user.email;
                signedUser.token = GuidString;

                return signedUser;
            }
           return null;
        }
    }
}
