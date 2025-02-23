using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class BarmilLoadInfo
    {
        public int PersonID { get; set; }
        public Int16 BarmilID { get; set; }
        public DateTime LoadDate { get; set; }
        public DateTime UnloadDate { get; set; }
        public string Status { get; set; }
    }
}
