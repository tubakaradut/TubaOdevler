using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class ProductService
    {
        ProjeContext db = new ProjeContext();

        public string CreateProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();

            return "urun eklendi";
        }
        public string DeleteCProduct(int Id)
        {
            Product delete = db.Products.Find(Id);
            db.Products.Remove(delete);
            db.SaveChanges();

            return $"urun silindi";
        }
        public string UpdateProduct(Product product)
        {
            using (ProjeContext context = new ProjeContext())
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return $"urun güncellendi";
        }
        public List<Product> ProductsListesi()
        {
            return db.Products.ToList();
        }
    }
}
