using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class RawMaterialStock
    {
        public Int16 RMID { get; set; }
        public float Quantity { get; set; }
        public float AlarmAmount { get; set; }
    }
}
