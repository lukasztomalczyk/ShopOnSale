using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnSale.services.Models;

namespace ShopOnSale.services.Context.Config
{
    /// <summary>
    /// Table configuration Products class from the database
    /// </summary>
    public class ProductsConfig : IEntityTypeConfiguration<ItemModel>
    {
        public void Configure(EntityTypeBuilder<ItemModel> builder)
        {
            builder.HasKey(o => o.Id);
        }
    }
}