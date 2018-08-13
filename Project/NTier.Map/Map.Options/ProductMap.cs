using NTier.Core.Core.Map;
using NTier.Model.Model.Entities;
namespace NTier.Map.Map.Options
{
    public class ProductMap:CoreMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");
            Property(product => product.Name).HasMaxLength(90).IsOptional();
            Property(product => product.Price).IsOptional();
            Property(product => product.Quantity).IsOptional();
            Property(product => product.UnitsInStock).IsOptional();
            Property(product => product.ImagePath).IsOptional();


            HasRequired(product => product.Category)
                .WithMany(category => category.Products)
                .HasForeignKey(product => product.CategoryID)
                .WillCascadeOnDelete(false);


            HasMany(product => product.OrderDetails)
              .WithRequired(product => product.Product)
              .HasForeignKey(product => product.ProductID)
              .WillCascadeOnDelete(false);


        }
    }
}
