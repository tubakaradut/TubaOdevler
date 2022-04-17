using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entity
{
   public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }


        //Mapping
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
