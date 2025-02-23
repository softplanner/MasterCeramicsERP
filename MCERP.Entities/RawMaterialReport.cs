using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class RawMaterialReport
    {
        public Int16 RMID { get; set; }
        public int SupplierID { get; set; }
        public float Quantity { get; set; }
        public float UnitRate { get; set; }
        public DateTime Date { get; set; }
    }
}
