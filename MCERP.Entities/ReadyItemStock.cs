using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class ReadyItemStock
    {
        public Int16 ItemID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 StyleID { get; set; }
        public int Quantity { get; set; }
        public Int16 ColorID { get; set; }
        public Int16 Category { get; set; }
    }
}
