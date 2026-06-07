using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Description)
            .HasMaxLength(2000);
        
        builder.Property(p => p.Price)
            .HasPrecision(18, 2);
        
        builder.Property(p => p.Slug)
            .HasMaxLength(250);
        builder.HasIndex(p => p.Slug)
            .IsUnique();
        
        builder.HasOne(p => p.Category)
            .WithMany(p => p.Products)
            .HasForeignKey(p => p.CategoryId);
    }
}