using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DP.Abstractions
{
    public interface IGetStatusForCollageComponent
    {
        // This Service to get the status for Departement and its chiled (instructors) Under Collage
        //in university 
        public string name { get; }
     
        void GetStatus(); 
    }
}
