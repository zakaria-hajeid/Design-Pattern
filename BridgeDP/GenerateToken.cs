using BridgeDP.Abstraction;
using BridgeDP.BridgeAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    public class GenerateToken : GenerateTokenAbstraction
    {
        public GenerateToken(IGenerateTokenBridge generateTokenBridge) : base(generateTokenBridge)
        {
        }

        public override void GenerateTokens()
        {
            generateTokenBridge.GenerateToken();

        }
    }
}
