using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class CasterPayment
    {
        public int WorkerID { get; set; }
        public DateTime Date { get; set; }
        public int BalanceAmount { get; set; }
        public int DeductShortTermLoan { get; set; }
        public int DeductAdvance { get; set; }
        public Int16 Quantity { get; set; }
        public Int16 Rate { get; set; }
        public Int16  ItemID{ get; set; }
        public Int16  StyleID{ get; set; }
        public Int16  SizeID{ get; set; }
    }
}
