using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces.Repositories;
public interface IProductRepository
{
    Task<Product?> GetByIdAsync(int id);
    Task<Product?> GetBySlugAsync(string slug);
    Task<IEnumerable<Product?>> GetAllAsync();
    Task<List<Product>> GetPageAsync(
        int pageNumber,
        int pageSize,
        string? searchTerm = null,
        int? categoryId = null
    );
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Product product);
}