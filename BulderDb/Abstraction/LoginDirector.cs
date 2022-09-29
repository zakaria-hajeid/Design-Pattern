using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulderDb.Abstraction
{
    public class LoginDirector
    {
        public object? MakeLogin(loginBulder login)
        {
            login.setObject();
            login.getUserInformation();
            login.getUserRole();
            login.GenerateToken();

            return login.GetTokenObjects();
        }
    }
}
