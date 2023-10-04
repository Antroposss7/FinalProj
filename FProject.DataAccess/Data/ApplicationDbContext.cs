using FProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace FProject.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "First", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Second", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Third", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
               
             
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    Artist = "WS3333333301",
                    Color = "Black",
                    ListPrice = 70,
                    Price = 65,
                    Price10 = 60,
                    Price25 = 55,
                    CategoryId = 1,
                    ImageUrl =""
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    Artist = "SOTJ1111111101",
                    Color = "Black",
                    ListPrice = 30,
                    Price = 27,
                    Price10 = 25,
                    Price25 = 20,
                    CategoryId = 2,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    Artist = "FOT000000001",
                    Color = "Black",
                    ListPrice = 25,
                    Price = 23,
                    Price10 = 22,
                    Price25 = 20,
                    CategoryId = 3,
                    ImageUrl = ""

                }
                );

        }
    }
}
