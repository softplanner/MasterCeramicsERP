using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class MoldStockWorker
    {
        public Int32 WorkerID { get; set; }
        public Int16 ItemID { get; set; }
        public Int16 StyleID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 Quantity { get; set; }
        public Int16 CastQuantity { get; set; }
    }
}
