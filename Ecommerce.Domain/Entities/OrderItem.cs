using Ecommerce.Domain.Common;
namespace Ecommerce.Domain.Entities;

public class OrderItem : BaseEntity
{
    public Guid OrderId {get; set;}
    public Guid ProductId {get; set;}
    public Order Order {get; set;} = null!;
    public string ProductName {get; set;} = string.Empty;
    public decimal UnitPrice {get; set;}
    public int Quantity {get; set;}
}