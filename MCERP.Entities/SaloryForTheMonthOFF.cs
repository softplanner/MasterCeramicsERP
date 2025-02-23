using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class SaloryForTheMonthOFF
    {
        public Int32 WorkerID { get; set; }
        public Int16 Attendence { get; set; }
        public Int16 ExtraAttendence { get; set; }
        public Int16 TotalAttendence { get; set; }
        public int TotalAmount { get; set; }
        public int BalanceAmount { get; set; }
        public int DeductShortTermLoan { get; set; }
        public int DeductAdvance { get; set; }
        public DateTime Date { get; set; }
    }
}
