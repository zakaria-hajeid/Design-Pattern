using Decorator_DP;
using Decorator_DP.Abstraction;
using Decorator_DP.Decorator;
using DesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignSetupConcreateStretegyClasses
{
    public class DecoratorSetup: IDesignPatternSelector
    {
        public void DesigntypeSetup()
        {
            TokenDecorator addEncryptedItemToToken = new AddEncryptedItemToToken(new TokenService());
            addEncryptedItemToToken.GenerateToken();
        }
    }
}
