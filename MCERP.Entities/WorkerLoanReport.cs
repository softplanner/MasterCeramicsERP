using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class WorkerLoanReport
    {
        public int WorkerID { get; set; }
        public string LoanType { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
