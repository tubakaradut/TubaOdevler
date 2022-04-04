using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAbstraction.FakeDatabase;

namespace ProductAbstraction
{
    public class Product : BaseClass
    {

        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }

        public override string Add()
        {
            Database.productList.Add(new Product()
            {
                ProductName = ProductName,
                UnitPrice = UnitPrice,
                UnitsInStock = UnitsInStock,
                Category = Category,
                Supplier = Supplier,
                CreatedDate = DateTime.Now,
                IsActive = true
            });

            return $"{DateTime.Now} Tarihinde {ProductName} İsimli Ürün Eklendi.";
        }

        public override string Delete(int index)
        {
            Product product = Database.productList[index];

            Database.productList.RemoveAt(index);

            return $"{DateTime.Now} Tarihinde {product.ProductName} İsimli Ürün Silindi.";
        }

        public override string List()
        {
            return "Ürün Listeleniyor...";
        }

        public override string Update(int index)
        {
            Product product = Database.productList[index];
            product.ProductName = ProductName;
            product.UnitPrice = UnitPrice;
            product.UnitsInStock = UnitsInStock;
            product.Category = Category;
            product.Supplier = Supplier;


            return $"{DateTime.Now} Tarihinde {product.ProductName} İsimli Ürün Güncellendi.";
        }

        public string Promotion(double val)
        {
            return "Promosyon uygulandı";
        }

        public override string ToString()
        {
            return $"Urün Adı: {ProductName}, Birim fiyat: { UnitPrice}, Birim Stok:  {UnitsInStock}, Kategori: {Category}, Tedarikçi: {Supplier}";
        }
    }
}
