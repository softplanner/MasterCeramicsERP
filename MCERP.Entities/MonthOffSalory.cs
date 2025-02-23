using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class MonthOffSalory
    {
        public int WorkerID { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public float DeductShortTermLoan { get; set; }
        public float  DeductAdvance { get; set; }
    }
}
