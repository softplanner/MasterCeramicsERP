using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class GreenWareHouseBreakage
    {
        public DateTime Date { get; set; }
        public Int16 ItemID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 StyleID { get; set; }
        public string BreakageType { get; set; }
        public int WorkerID { get; set; }
        public Int16 Quantity { get; set; }
        public string Remarks { get; set; }
     }
}
