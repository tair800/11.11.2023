using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Account
{
    public class Account
    {
        public string Username = "lorem123";
        public string Password = "123456*";

        public void Login()
        {
            if(Username== "lorem123" && Password == "123456*")
            {
                Console.WriteLine("Successful Access");
            }
            else
                Console.WriteLine("Username or Password is wrong ");
        }
    }
}
