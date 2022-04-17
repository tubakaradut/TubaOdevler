using System.Data.Entity;
using WFA_EFNorthwind.Entity;

namespace WFA_EFNorthwind.ProjeContext
{
    public class ProjeContext : DbContext
    {

        public ProjeContext()
        {
            Database.Connection.ConnectionString = "Server=.\\SQLEXPRESS;Database=ProjeDB;Trusted_Connection=True;";
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Shipper> Shippers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Entity Splitting bir classı 2 ye bölmek için 'ayrı tablo olusturmak için
            //modelBuilder.Entity<AppUser>().Map(map =>
            //{
            //    map.Properties(x => new
            //    {
            //        x.ID,
            //        x.Username,
            //        x.Password
            //    });
            //    map.ToTable("Users");

            //modelBuilder.Entity<User>().Map(map =>
            //{
            //    map.Properties(x => new
            //    {
            //        x.UserId,
            //        x.Username,
            //        x.Password
            //    });
            //    map.ToTable("Users");
            //});



            //modelBuilder.Entity<User>().Map(map =>
            //{
            //    map.Properties(x => new
            //    {

            //        x.UserId,
            //        x.Firstname,
            //        x.Lastname,
            //        x.Phonenumber,
            //        x.Address,
            //        x.City,
            //        x.Country,
            //        x.Region,
            //        x.Email,

            //    });



            //});





            base.OnModelCreating(modelBuilder);
        }
    }
}
