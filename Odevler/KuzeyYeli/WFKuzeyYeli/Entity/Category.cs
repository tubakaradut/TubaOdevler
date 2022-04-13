using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFKuzeyYeli.Entity
{
  public  class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }


        //bir kategorinin birden cok urunu olur

        public List<Product> Products { get; set; }

    }
}
