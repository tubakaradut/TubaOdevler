using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_EFNorthwind.Entity
{
  public  class Order
    {

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; } //istenen tarih
        public DateTime ShippedDate { get; set; }  //sevk tarihi
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }  //tasıma ucreti ?
        public string ShipName { get; set; }  
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        //bir siparisin bir musterisi olur 
        //bir siparisin bir nakliyecisi olur
        public string CustomerID { get; set; }   //customer ıd string tanımlandıgı için
        public int ShipperID { get; set; }
        public Customer Customer { get; set; }
        public Shipper Shipper { get; set; }
    }
}
