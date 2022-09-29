using BridgeDP;
using DesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignSetupConcreateStretegyClasses
{
    public class BridgeSetup : IDesignPatternSelector
    {
        public void DesigntypeSetup()
        {
            GenerateToken generateToken = new GenerateToken(new BidgeConcreate());

            generateToken.GenerateTokens();
        }
    }
}
