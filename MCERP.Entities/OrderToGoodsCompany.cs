using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class OrderToGoodsCompany
    {
        public Int16 CompanyID { get; set; }
        public Int64 OrderID { get; set; }
        public string BiltyNo { get; set; }
        public DateTime Date { get; set; }
    }
}
