using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planb.Entities
{
    public class postoffice
    {
        public string Name { get; set; }
        
        public pincode pincode { get; set; }
        public int MyProperty { get; set; }
        public district district { get; set; }
        
        public State state { get; set; }

    }
}
