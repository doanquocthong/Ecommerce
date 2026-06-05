using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities;

public class CartItem : BaseEntity
{
    public Guid CartId {get; set;}
    public Guid ProductId {get; set;}
    public Cart Cart {get; set;} = null!;
    public Product Product {get; set;} = null!;
    public int Quantity {get; set;}
}