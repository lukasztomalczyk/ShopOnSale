using Microsoft.EntityFrameworkCore;
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
    }
}