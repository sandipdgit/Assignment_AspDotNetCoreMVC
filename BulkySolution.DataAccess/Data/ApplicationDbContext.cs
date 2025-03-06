using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                     new Product
                     {
                         Id = 1,
                         Title = "Fortune of Time",
                         Author = "Billy Spark",
                         Description = "A book is an object recording information in the form of printed writing or images. Bookselling is the commercial trading of books that forms \r\n\r\nthe retail and distribution end of the publishing process.",
                         ISBN = "SWD9999001",
                         ListPrice = 99,
                         Price = 90,
                         Price50 = 85,
                         Price100 = 80,
                         CategoryId = 1
                     },
                    new Product
                    {
                        Id = 2,
                        Title = "Dark Skies",
                        Author = "Nancy Hoover",
                        Description = "A book is an object recording information in the form of printed writing or images. Bookselling is the commercial trading of books that forms \r\n\r\nthe retail and distribution end of the publishing process.",
                        ISBN = "CAW777777701",
                        ListPrice = 40,
                        Price = 30,
                        Price50 = 25,
                        Price100 = 20,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Vanish in the Sunset",
                        Author = "Julian Button",
                        Description = "A book is an object recording information in the form of printed writing or images. Bookselling is the commercial trading of books that forms \r\n\r\nthe retail and distribution end of the publishing process.",
                        ISBN = "RITO5555501",
                        ListPrice = 55,
                        Price = 50,
                        Price50 = 40,
                        Price100 = 35,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "Cotton Candy",
                        Author = "Abby Muscles",
                        Description = "A book is an object recording information in the form of printed writing or images. Bookselling is the commercial trading of books that forms \r\n\r\nthe retail and distribution end of the publishing process.",
                        ISBN = "WS3333333301",
                        ListPrice = 70,
                        Price = 65,
                        Price50 = 60,
                        Price100 = 55,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Rock in the Ocean",
                        Author = "Ron Parker",
                        Description = "A book is an object recording information in the form of printed writing or images. Bookselling is the commercial trading of books that forms \r\n\r\nthe retail and distribution end of the publishing process.",
                        ISBN = "SOTJ1111111101",
                        ListPrice = 30,
                        Price = 27,
                        Price50 = 25,
                        Price100 = 20,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "Leaves and Wonders",
                        Author = "Laura Phantom",
                        Description = "A book is an object recording information in the form of printed writing or images. Bookselling is the commercial trading of books that forms \r\n\r\nthe retail and distribution end of the publishing process. ",
                        ISBN = "FOT000000001",
                        ListPrice = 25,
                        Price = 23,
                        Price50 = 22,
                        Price100 = 20,
                        CategoryId = 3
                    }

                );


        }

    }
}
