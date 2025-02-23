using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class PersonExtraInfo
    {
        public string NIC { get; set; }
        public int PersonID { get; set; }
        public byte[] ThumImage { get; set; }
        public byte[] Image { get; set; }
        public string EMail { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
