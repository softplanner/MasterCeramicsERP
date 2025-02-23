using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
   public class ItemRate
    {
        public Int16 ItemID { get; set; }
        public Int16 SizeID { get; set; }
        public Int16 StyleID { get; set; }
        public Int16 CategoryID { get; set; }
        public Int16 ColorTypeID { get; set; }
        public float PakistanRate { get; set; }
        public float InternationalRate { get; set; }
    }
}
