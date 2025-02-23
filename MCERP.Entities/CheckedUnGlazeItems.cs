using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class CheckedUnGlazeItems
    {
        public Int32 WorkerID { get; set; }
        public Int32 CheckerID { get; set; }
        public Int16 ItemID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 StyleID { get; set; }
        public Int16 Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
