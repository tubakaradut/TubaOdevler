using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Context
{
  public  class ProjeContext:DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = "server=.\\SQLEXPRESS;Database=OrnekDB;Trusted_Connection=True;";
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
