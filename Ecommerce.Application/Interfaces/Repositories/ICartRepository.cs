using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces.Repositories;

public interface ICartRepository
{
    Task<Cart?> GetByIdAsync(int id);
    Task<Cart?> GetByUserIdAsync(int userId);
    Task AddAsync(Cart cart);
    Task UpdateAsync(Cart cart);
    // Normally, we don't delete carts, but wer can have a method to clear the cart items instead of deleting the cart itself
    Task DeleteAsync(Cart cart);
}