using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class Node
{
    [Column("NodeId")] 
    public Guid Id { get; set; }
    
    [ForeignKey(nameof(Product))] 
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    
    [ForeignKey(nameof(Fridge))] 
    public Guid FridgeId { get; set; }
    public Fridge? Fridge { get; set; }
    
    public int Quantity { get; set; }
}