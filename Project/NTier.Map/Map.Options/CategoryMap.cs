﻿using NTier.Core.Core.Map;
using NTier.Model.Model.Entities;

namespace NTier.Map.Map.Options
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");

            Property(category => category.Name).HasMaxLength(90).IsOptional();
            Property(category => category.Description).HasMaxLength(255).IsOptional();

            HasMany(category => category.Products)
                .WithRequired(product => product.Category)
                .HasForeignKey(product => product.CategoryID)
                .WillCascadeOnDelete(false);
            

        }
    }
}
