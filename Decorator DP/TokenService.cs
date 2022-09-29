using Decorator_DP.Abstraction;

namespace Decorator_DP
{
    public class TokenService : IToken
    {
        public void GenerateToken()
        {
            Console.WriteLine("Token Is Generated ");
        }
    }
}