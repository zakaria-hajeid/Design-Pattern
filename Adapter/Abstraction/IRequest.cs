using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Abstraction
{
    public interface IRequest
    {
        public void request(string[] arg);
    }
}
