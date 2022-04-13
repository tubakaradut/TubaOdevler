using System.Data.Entity;
using WFKuzeyYeli.Entity;

namespace WFKuzeyYeli.ProjeContext
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
            // Entity Splitting bir classı 2 ye bölmek için 'ayrı tablo olusturmak için
            modelBuilder.Entity<User>().Map(map =>
            {
                map.Properties(x => new
                {
                    x.UserId,
                    x.Username,
                    x.Password
                });
                map.ToTable("Users");
                map.Properties(x => new
                {
                    x.UserId,
                    x.Firstname,
                    x.Lastname,
                    x.Phonenumber,
                    x.Email,
                    x.Country,
                    x.City,
                    x.Region,
                    x.Address
                });
                map.ToTable("UserDetails");



                ///---Cok a cok ilişkilerde aradaki ara tablo olusumu
                //modelBuilder.Entity<Teacher>()
                //    .HasMany(x => x.Students)
                //    .WithMany(x => x.Teachers)
                //    .Map(map =>
                //    {
                //        map.ToTable("TeachersAndStudents");
                //        map.MapLeftKey("TeacherId");
                //        map.MapRightKey("StudentId");
                //    });


                base.OnModelCreating(modelBuilder);
            });
        }
    }
}

