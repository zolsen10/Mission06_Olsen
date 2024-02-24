﻿using Microsoft.EntityFrameworkCore;

namespace Mission06_Olsen.Models
{
    public class MovieAdditionContext : DbContext
    {
        public MovieAdditionContext(DbContextOptions<MovieAdditionContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; } // Corrected name
        public DbSet<Category> Categories { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Television" },
                new Category { CategoryId = 4, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
            );
        }*/
    }
}
