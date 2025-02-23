using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class CasterPaymentNew
    {
        public int WorkerID { get; set; }
        public int ItemID { get; set; }
        public int StyleID { get; set; }
        public int SizeID { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public int TotalAmount { get; set; }
        public int ShortLoan { get; set; }
        public int AdvanceLoan { get; set; }
        public int DeductSTLoan { get; set; }
        public int DeductAdvLoan { get; set; }
        public int BalanceSTLoan { get; set; }
        public int BalanceAdvLoan { get; set; }
        public int BalanceAmount { get; set; }
        public DateTime Date { get; set; }
    }
}
