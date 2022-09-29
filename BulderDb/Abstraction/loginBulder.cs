using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulderDb.Abstraction
{
    public abstract class loginBulder
    {

        public object? GetTokenObject;
        public abstract void getUserInformation();
        public abstract void getUserRole();
        public abstract void GenerateToken();

        public object? GetTokenObjects()
        {
            return GetTokenObject;
        }

        public void setObject()
        {
            GetTokenObject = new object();
        }
    }
}
