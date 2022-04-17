using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class CategoryService
    {
        ProjeContext db = new ProjeContext();

        public string CreateCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();

            return "category eklendi";
        }
        public string DeleteCategory(int Id)
        {
            Category delete = db.Categories.Find(Id);
            db.Categories.Remove(delete);
            db.SaveChanges();

            return $"category silindi";
        }
        public string UpdateCategory(Category category)
        {
            try
            {
                var x = db.Categories.Find(category.CategoryID);
                db.Entry(x).CurrentValues.SetValues(category);
                db.SaveChanges();
                //db.Categories.Attach(category);
                //db.Entry(category).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();
                return $"category güncellendi";
                //using (ProjeContext context = new ProjeContext())
                //{
                //    context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                //    context.SaveChanges();
                //    return $"category güncellendi";
                //}
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Category> Categories()
        {
            return db.Categories.ToList();
        }
    }
}
