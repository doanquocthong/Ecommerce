using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities;

public class Cart : BaseEntity
{
    public Guid Userid {get; set;}
    public User? User {get; set;}
    public ICollection<CartItem> CartItems {get; set;}  = [];
}