using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFKuzeyYeli.Entity
{
   public class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }


        //bir nakliyecinin birden cok siparisi olur
        public List<Order> Orders { get; set; }
    }
}
