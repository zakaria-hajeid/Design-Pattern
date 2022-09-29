using BridgeDP.BridgeAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP.Abstraction
{
    public abstract class GenerateTokenAbstraction
    {
        public IGenerateTokenBridge generateTokenBridge;

        protected  GenerateTokenAbstraction(IGenerateTokenBridge generateTokenBridge )
        { 
            this.generateTokenBridge = generateTokenBridge;
        }
        public abstract void GenerateTokens();
    }
}
