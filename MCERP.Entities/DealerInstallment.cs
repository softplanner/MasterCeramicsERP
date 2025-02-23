using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class DealerInstallment
    {
        public int DealerID { get; set; }
        public DateTime Date { get; set; }
        public string AmountType { get; set; }
        public string AmountSubmitTo { get; set; }
        public Int16 CurrencyID { get; set; }
        public string SubmitTo { get; set; }
        public float Amount { get; set; }
    }
}
