using Observe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observe.Absraction
{
    public interface ITokenSubject
    {
        void registerobserv(ITokenObserves observe);
        void unregisterobserv(ITokenObserves observe);
        public EnumTokenStatus tokenStatus { get; set; }
        void NotifyObserves();
    }
}
