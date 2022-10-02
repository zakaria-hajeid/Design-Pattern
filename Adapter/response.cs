using Adapter.Abstraction;

namespace Adapter
{
    public class response : IResponse
    {
        void IResponse.response(List<string> args)
        {
            Console.WriteLine("the response is work with the adaptered valuse");
            args.ForEach(x =>
            {
                Console.WriteLine("values in list " + x);
            });

        }
    }
}