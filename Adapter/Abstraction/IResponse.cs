using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Abstraction
{
    public interface IResponse
    {
        public void response(List<string> args);
    }
}
