using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class Fridge
{
    [Column("FridgeId")] 
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? OwnerName { get; set; }
    public Guid ModelId { get; set; }
    
    public virtual Model? Model { get; set; }
    public virtual FridgeProduct? FridgeProduct { get; set; }
}