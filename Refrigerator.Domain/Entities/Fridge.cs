using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class Fridge
{
    [Column("FridgeId")] 
    public Guid Id { get; set; }
    
    public string? OwnerName { get; set; }
    
    [ForeignKey(nameof(Model))]
    public Guid ModelId { get; set; }
    
    public Model? Model { get; set; }
    
    public FridgeProduct? Node { get; set; }
}