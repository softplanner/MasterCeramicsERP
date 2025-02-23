using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class OilInspectionReport
    {
        public DateTime Date { get; set; }
        public int WorkerID { get; set; }
        public int CheckerID { get; set; }
        public Int16 ItemID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 StyleID { get; set; }
        public Int16 CheckedQuantity { get; set; }
        public Int16 RejectQuantity { get; set; }
        public string Remarks { get; set; }
    }
}
