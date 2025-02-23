using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class AttandanceWorkerNew
    {
        public int WorkerID { get; set; }
        public int Status { get; set; }
        public int ExtraAttandance { get; set; }
        public DateTime DateTime_Attandance { get; set; }
    }
}
