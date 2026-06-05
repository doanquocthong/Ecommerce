using Ecommerce.Domain.Common;
using Ecommerce.Domain.Enums;
namespace Ecommerce.Domain.Entities;

public class Order : BaseEntity
{
    public Guid UserId {get; set;}
    public User User {get; set; } = null!;    public decimal TotalAmount {get; set;}
    public String ShippingAddress {get; set;} = string.Empty;
    public String PhoneNumber {get; set;} = string.Empty;
    public String? Note {get; set;}
    public OrderStatus Status {get; set;} = OrderStatus. Pending;

    //Navigation property 1 - M relationship with OrderItems
    public ICollection<OrderItem> OrderItems {get; set;} = [];
}