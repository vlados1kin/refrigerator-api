using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class Node
{
    [Column("NodeId")] 
    public Guid Id { get; set; }
    
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }

    [ForeignKey(nameof(Fridge))]
    public Guid FridgeId { get; set; }

    [Required(ErrorMessage = "Quantity is a required field.")]
    public int Quantity { get; set; }
}