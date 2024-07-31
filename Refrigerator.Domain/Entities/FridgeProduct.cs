using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class FridgeProduct
{
    [Column("FridgeProductId")] 
    public Guid Id { get; set; }
    
    [ForeignKey(nameof(Product))] 
    public Guid ProductId { get; set; }
    
    [ForeignKey(nameof(Fridge))] 
    public Guid FridgeId { get; set; }
    
    public int Quantity { get; set; }
    
    public virtual Product? Product { get; set; }
    public virtual Fridge? Fridge { get; set; }
}