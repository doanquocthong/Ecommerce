using Ecommerce.Domain.Enums;
using Ecommerce.Domain.Common;
namespace Ecommerce.Domain.Entities;

public class User : BaseEntity
{
    public string Email {get; set;} = string.Empty;
    public string PasswordHash {get; set;} = string.Empty;
    public string FullName {get; set;} = string.Empty;
    public UserRole Role {get; set;} = UserRole.Customer;

    // Navigation property 1 - M relationship with Orders
    public ICollection<Order> Orders {get; set;} = [];
}