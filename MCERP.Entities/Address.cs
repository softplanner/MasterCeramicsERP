using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class Address
    {
        public Int64 ID { get; set; }
        public Int32 PersonID { get; set; }
        public string AddressType { get; set; }
        public string StreetAddress { get; set; }
        public Int16 CityID { get; set; }
        public string ZipCode { get; set; }
    }
}
