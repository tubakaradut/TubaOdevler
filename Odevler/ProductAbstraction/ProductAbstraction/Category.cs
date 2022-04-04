using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAbstraction.FakeDatabase;

namespace ProductAbstraction
{
    public class Category : BaseClass
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string Add()
        {
            Database.categoryList.Add(new Category()
            {
               CategoryName=CategoryName,
               Description=Description,
               CreatedDate = DateTime.Now,
               IsActive = true
            });

            return $"{DateTime.Now} Tarihinde {CategoryName} İsimli Kategori Eklendi.";
        }
        public override string Update(int index)
        {
            Category category = Database.categoryList[index];
            category.CategoryName = CategoryName;
            category.Description = Description;
            


            return $"{DateTime.Now} Tarihinde {category.CategoryName} İsimli Kategori Güncellendi.";
        }
        public override string Delete(int index)
        {
           Category category = Database.categoryList[index];

            Database.categoryList.RemoveAt(index);

            return $"{DateTime.Now} Tarihinde {category.CategoryName} İsimli Kategori Silindi.";
        }
        public override string List()
        {
            throw new System.NotImplementedException();

        }


        public override string ToString()
        {
            return $" Kategori Adı: {CategoryName}, Açıklama: {Description} ";
        }
    }
}
