using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class Fridge
{
    [Column("FridgeId")] 
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Owner name is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for the Owner name field is 50 characters.")]
    public string? OwnerName { get; set; }
    
    [ForeignKey(nameof(Model))]
    public Guid ModelId { get; set; }

    public Node? Node { get; set; }
}