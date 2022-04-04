using System.Collections.Generic;

namespace ProductAbstraction.FakeDatabase
{
    public static class Database
    {
        public static List<Product> productList = new List<Product>();
        public static List<Category> categoryList = new List<Category>();
        public static List<Supplier> supplierList = new List<Supplier>();
    }
}
