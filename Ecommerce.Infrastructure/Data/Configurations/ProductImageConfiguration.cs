using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Data.Configurations;

public class ProductImageConfiguration
    : IEntityTypeConfiguration<ProductImage>
{
    public void Configure(
        EntityTypeBuilder<ProductImage> builder)
    {
        builder.ToTable("ProductImages");

        builder.HasKey(pi => pi.Id);
        builder.Property(pi => pi.ImageUrl)
            .IsRequired();

        builder.HasOne(pi => pi.Product)
            .WithMany(pi => pi.Images)
            .HasForeignKey(pi => pi.ProductId);
    }
}