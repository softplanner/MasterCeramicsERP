using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class deliveryChallan
    {
        public int DealerID { get; set; }
        //public int DealerCustomerID { get; set; }
        public Int16 ItemID { get; set; }
        public Int16 StyleID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 ColorID { get; set; }
        public Int16 CategoryID { get; set; }
        public string GatePass { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
   }
}
