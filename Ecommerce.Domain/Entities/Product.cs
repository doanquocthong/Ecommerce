using Ecommerce.Domain.Enums;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities;

public class Product : BaseEntity {
    public string Name {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public decimal Price {get; set;}
    public int StockQuantity {get; set;}
    public ICollection<ProductImage> Images {get; set;} = [];
    public String Slug {get; set;} = string.Empty;
    public StatusProduct Status {get; set;} = StatusProduct.InStock;

    public Guid CategoryId {get; set;}
    public Category Category {get; set;} = null!;
}