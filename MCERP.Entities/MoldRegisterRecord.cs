using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class MoldRegisterRecord
    {
        public int CasterID { get; set; }
        public int ItemID { get; set; }
        public int Style { get; set; }
        public int SizeID { get; set; }
        public DateTime DateReceived { get; set; }
        public int QuantityReceived { get; set; }
        public int QuantityIssued { get; set; }
        public DateTime DateExpiry { get; set; }
        public int Breakage { get; set; }
        public string BreakageCause { get; set; }
        public int Balance { get; set; }
    }
}
