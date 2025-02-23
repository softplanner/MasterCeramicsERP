using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class GatePass
    {
        public Int64 GatePassID { get; set; }
        public Int64 OrderID { get; set; }
        public DateTime Date { get; set; }
    }
}
