using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class DailyKillenReport
    {
        public DateTime Date { get; set; }
        public int ItemID { get; set; }
        public int SizeID { get; set; }
        public int StyleID { get; set; }
        public int Quantity { get; set; }
        public int KillenID { get; set; }
        public int ColorID { get; set; }
        public int ItemCategoryID { get; set; }
        public string Remarks { get; set; }
    }
}
