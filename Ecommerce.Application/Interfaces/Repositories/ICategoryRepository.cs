using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces.Repositories;

public interface ICategoryRepository
{
    Task<Category?> GetByIdAsync(int id);
    Task<Category?> GetBySlugAsync(string slug);
    Task<IEnumerable<Category>> GetAllAsync();
    Task AddAsync(Category category);
    Task UpdateAsync(Category category);
    Task DeleteAsync(Category category);
    Task HideAsync(Category category);
}