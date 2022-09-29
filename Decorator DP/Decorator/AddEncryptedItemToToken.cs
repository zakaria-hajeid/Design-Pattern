using Decorator_DP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP.Decorator
{
    public class AddEncryptedItemToToken : TokenDecorator
    {
        public AddEncryptedItemToToken(IToken tokenService) : base(tokenService)
        {
        }

        public override void GenerateToken()
        {
            tokenService.GenerateToken();
            addEncryptedItemToToken("item");
        }

        private void addEncryptedItemToToken(string v)
        {
            Console.WriteLine($"Add Item {v}");
        }


    }
}
