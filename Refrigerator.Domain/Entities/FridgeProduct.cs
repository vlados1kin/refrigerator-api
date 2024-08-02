using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class FridgeProduct
{
    [Column("FridgeProductId")] 
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid FridgeId { get; set; }
    public int Quantity { get; set; }
    
    public ICollection<Product>? Products { get; set; }
    public ICollection<Fridge>? Fridges { get; set; }
}