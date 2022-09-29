using BulderDb.Abstraction;
using System.Reflection;
using System.Reflection.Emit;

namespace BulderDb
{
    public class LoginTokenDirictor : loginBulder
    {
    
        public override void GenerateToken()
        {
            Console.WriteLine("tokenGenerated");
        }

        public override void getUserInformation()
        {
            // GetTokenObject.set any properety
            Console.WriteLine("getUserInformation");
        }

        public override void getUserRole()
        {
            Console.WriteLine("getUserRole");
        }
    }
}