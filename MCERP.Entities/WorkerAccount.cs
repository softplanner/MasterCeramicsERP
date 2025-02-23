using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class WorkerAccount
    {
        public int WorkerID { get; set; }
        public float ShortTermLoan { get; set; }
        public float Advance { get; set; }
        public float BalanceAmount { get; set; }
    }
}
