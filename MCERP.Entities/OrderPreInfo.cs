using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class OrderPreInfo
    {
        public int DealerID { get; set; }
        public int DealerCustomerID { get; set; }
        public Int16 ItemID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 StyleID { get; set; }
        public Int16 ColorID { get; set; }
        public Int16 Quantity { get; set; }
        public DateTime Date { get; set; }

    }
}
