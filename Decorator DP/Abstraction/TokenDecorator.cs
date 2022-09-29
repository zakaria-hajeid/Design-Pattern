using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP.Abstraction
{
    public abstract class TokenDecorator
    {
        public IToken tokenService;
        public TokenDecorator(IToken tokenService)
        {
            this.tokenService = tokenService;
        }

        public abstract void GenerateToken();
    }
}
