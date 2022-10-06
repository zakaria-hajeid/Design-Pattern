using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Abstractions
{
     public abstract class ThirdPartyService
    {
        public ThirdPartyService? thirdPartyService;
        public abstract int index { get; }
        public void SetNextHandlerWhenFaliar(ThirdPartyService? thirdPartyService)
        {
            this.thirdPartyService = thirdPartyService;
        }

        public abstract void SendRequest();
    }
}
