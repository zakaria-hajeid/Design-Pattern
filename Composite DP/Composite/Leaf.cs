using Composite_DP.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DP.Composite
{
    public class Leaf : IGetStatusForCollageComponent
    {
        private StatusEnum Status;
        private string name;

        public Leaf(string name, StatusEnum Status)
        {
            _name = name;
            _Status = Status;
        }
        public string _name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public StatusEnum _Status
        {
            get
            {
                return Status;
            }

            set
            {
                Status = value;
            }
        }
        public void GetStatus()
        {
            Console.WriteLine($"the status for {_name} is {_Status}");
        }
        string IGetStatusForCollageComponent.name => _name;

    }
}
