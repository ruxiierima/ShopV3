using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers
{
    public class LoginController
    {
        public static bool Login(string email)
        {
            List<User> users = new List<User>();
            users = UserController.GetUsers().ToList();
            foreach(User user in users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool CheckPass(string email,string password)
        {
            User user = UserController.GetUser(email);
            if (user.Parola == password)
            {
                return true;
            }
            return false;

        }
    }
}
