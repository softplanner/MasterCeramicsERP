using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class AttendenceDetail
    {
        public Int32 WorkerID { get; set; }
        public string ExtraAttendence { get; set; }
        public DateTime Date { get; set; }
    }
}
