using Observe.Absraction;
using Observe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observe
{
    public class TokenObserve : ITokenObserves
    {
        public TokenObserve(ITokenSubject? subject)
        {
            subject?.registerobserv(this);
        }
        public void getTheStatusOfToken(EnumTokenStatus tokenStatus)
        {
            Console.WriteLine($"the current state of object is{tokenStatus}");
        }
    }
}
