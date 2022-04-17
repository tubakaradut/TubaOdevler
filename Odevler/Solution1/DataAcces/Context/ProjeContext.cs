using DataAcces.Entity;
using System.Data.Entity;


namespace DataAcces.Context
{
    public class ProjeContext : DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = "server=.\\SQLEXPRESS;Database=FilmDB;Trusted_Connection=True;";
        }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<MovieCategory> MoviesCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>().HasKey(sc => new { sc.MovieId, sc.CategoryId });


            //modelBuilder.Entity<Movie>()
            //    .HasMany(x => x.Categories)
            //    .WithMany(x => x.Movies)
            //    .Map(map =>
            //    {
            //        map.ToTable("MovieCategories");
            //        map.MapLeftKey("MovieId");
            //        map.MapRightKey("CategoryId");
            //    });


            base.OnModelCreating(modelBuilder);
        }
    }
    }
