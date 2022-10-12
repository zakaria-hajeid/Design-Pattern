using Observe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observe.Absraction
{
    public interface ITokenObserves
    {
        void getTheStatusOfToken(EnumTokenStatus tokenStatus);
    }
}
