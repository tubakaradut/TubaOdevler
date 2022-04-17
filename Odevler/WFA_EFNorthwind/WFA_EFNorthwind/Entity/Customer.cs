using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_EFNorthwind.Entity
{
   public class Customer
    {
        public string CustomerID { get; set; }    //nchar5 olarak girildigi için string
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }  //unvan gibi
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }  //bölge
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }



        //bir musterinin birden fazla siparisi olur

        public List<Order> Orders { get; set; }


    }
}
