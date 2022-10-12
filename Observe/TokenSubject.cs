using Observe.Absraction;
using Observe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observe
{
    public class TokenSubject : ITokenSubject
    {
        private EnumTokenStatus _tokenStatus;
        private List<ITokenObserves> observers = new List<ITokenObserves>();
        public EnumTokenStatus tokenStatus
        {
            get
            {
                return _tokenStatus;
            }
            set
            {
                Console.WriteLine($"the token status is changed from {tokenStatus} to {value}");
                _tokenStatus = value;
                NotifyObserves();
            }
        }

        public TokenSubject(EnumTokenStatus tokenStatus)
        {
            _tokenStatus=tokenStatus;
        }
        public void NotifyObserves()
        {
            foreach (var observe in observers)
            {
                observe.getTheStatusOfToken(_tokenStatus);
            }
        }

        public void registerobserv(ITokenObserves observe)
        {
            observers.Add(observe);
        }

        public void unregisterobserv(ITokenObserves observe)
        {
            observers.Remove(observe);
        }
    }
}
