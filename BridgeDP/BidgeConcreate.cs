using BridgeDP.BridgeAbstraction;

namespace BridgeDP
{
    public class BidgeConcreate : IGenerateTokenBridge
    {
        public void GenerateToken()
        {
            Console.WriteLine("Welcome to Brideg Db The token is Generated");        
        }
    }
}