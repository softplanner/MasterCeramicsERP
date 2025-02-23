using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
   public class ItemWeight
    {
       public Int16 ItemID { get; set; }
       public Int16 SizeID { get; set; }
       public Int16 StyleID { get; set; }
       public double Weight { get; set; }
    }
}
