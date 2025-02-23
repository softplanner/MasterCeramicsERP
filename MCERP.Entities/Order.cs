using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class Order
    {
        public Int64 OrderID { get; set; }
        public DateTime Date { get; set; }
        public int DealerID { get; set; }
        public int DealerCustomerID { get; set; }
    }
}
