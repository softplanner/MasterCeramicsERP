using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class DailyGlazingReportN
    {
        public DateTime Date { get; set; }
        public int ItemID { get; set; }
        public int SizeID { get; set; }
        public int StyleID { get; set; }
        public int ColorID { get; set; }
        public int SprayManID { get; set; }
        public int Quantity { get; set; }
        public int Breakage { get; set; }
        public string Remarks { get; set; }
    }
}
