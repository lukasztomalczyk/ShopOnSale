using Microsoft.EntityFrameworkCore;
using ShopOnSale.services.Context.Config;
using ShopOnSale.services.Enums;
using ShopOnSale.services.Models;

namespace ShopOnSale.services.Context
{
    /// <summary>
    /// The main class inherited DbContext, contains references to models
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        DbSet<ItemModel> Products { get; set; }
        
        /// <summary>
        /// The method responsible for the configuration of tables in the database and their properties
        /// </summary>
        /// <param name="modelBuilder">instance of modelBuilder</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductsConfig());
            modelBuilder.Entity<ItemModel>().HasData(
                new { Name = "Produkt 1", CategoryEnum.Electronics, Price = "12,00", PrctureSrc = "http://www.wp.pl"});
        }
    }
}