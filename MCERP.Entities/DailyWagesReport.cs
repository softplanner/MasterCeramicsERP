using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class DailyWagesReport
    {
        public int WorkerID { get; set; }
        public Int16 Attendence { get; set; }
        public int PerDayWage { get; set; }
        public int TotalAmount { get; set; }
        public int DeductShortTermLoan { get; set; }
        public int BalanceAmount { get; set; }
        public DateTime Date { get; set; }
    }
}
