using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces.Repositories;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(int id);
    Task<User?> GetByEmailAsync(string email);
    Task<bool> ExitsByEmailAsync(string email);
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task BlockAsync(User user);
}