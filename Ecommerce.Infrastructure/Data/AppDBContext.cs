using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Ecommerce.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products {get; set;}
}