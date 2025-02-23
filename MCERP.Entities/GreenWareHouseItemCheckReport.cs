using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class GreenWareHouseItemCheckReport
    {
        public int WorkerID { get; set; }
        public int CheckerID { get; set; }
        public Int16 ItemID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 StyleID { get; set; }
        public Int32 Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
