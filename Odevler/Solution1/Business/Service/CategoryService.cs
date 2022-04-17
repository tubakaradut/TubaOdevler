using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Service
{
    public  class CategoryService
    {
        ProjeContext db = new ProjeContext();

        public string CreatedCategory(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return $"eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string DeleteCategory(int Id)
        {
            try
            {
                Category deleted = db.Categories.Find(Id);
                db.Categories.Remove(deleted);
                db.SaveChanges();
                return $"silindi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string Updatecayegory(Category category)
        {
            try
            {
                //var x = db.Categories.Find(category.Id);
                //db.Entry(x).CurrentValues.SetValues(category);
                db.Entry(category).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return $"guncellendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public List<Category> CategoriesList()
        {
            return db.Categories.ToList();
        }

        public Category SelectedCategory(string categoryName)
        {
            Category category = db.Categories.FirstOrDefault(x => x.CategoryName == categoryName);

            return category;
        }
    }
}
