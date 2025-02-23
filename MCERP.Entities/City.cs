using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class City
    {
        public Int16 CityID { get; set; }
        public Int16 CountryID { get; set; }
        public Int16 ProvinceID { get; set; }
        public string Name { get; set; }
    }
}
