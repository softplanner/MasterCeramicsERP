using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class OrderPostInfo
    {
        public Int16 ItemID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 StyleID { get; set; }
        public Int16 ColorID { get; set; }
        public Int16 Quantity { get; set; }
        public DateTime Date { get; set; }
        public Int32 DealerID { get; set; }
        public Int32 DealerCustomerID { get; set; }
        public string GatePass { get; set; }
        public string BiltyNo { get; set; }
        public Int16 GoodsCompanyID { get; set; }
   }
}
