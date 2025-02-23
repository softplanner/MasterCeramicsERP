using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class BillDetail
    {
        public Int64 DealerID { set; get; }
        public string BillNo { set; get; }
        public DateTime Date { set; get; }
        public Int64 Total { set; get; }
    }
}
