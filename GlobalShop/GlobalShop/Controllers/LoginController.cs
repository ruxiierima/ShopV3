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
                    Console.WriteLine("------------OK------------");
                    return true;
                }
            }
            return false;

        }
    }
}
