using System.Data;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AspNetMiniProj.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : 
            base(options) 
        { 
        }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



           
            modelBuilder.Entity<Movie>().HasData(
                    new Movie { Id = 5, Name = "Ghostbusters", Description = "Ghostbusters is a 1984 American supernatural comedy film directed and produced by Ivan Reitman, and written by Dan Aykroyd and Harold Ramis." },
                    new Movie { Id = 2, Name = "Titanic", Description = "Titanic is a 1997 American disaster film directed, written, produced, and co-edited by James Cameron." },
                    new Movie { Id = 3, Name = "Saw", Description = "Saw is a 2004 American horror film directed by James Wan, in his feature directorial debut, and written by Leigh Whannell from a story by Wan and Whannell." });
        }


    }
}

