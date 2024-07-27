using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class Model
{
    [Column("ModelId")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Owner name is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for the Owner name field is 50 characters.")]
    public string? Name { get; set; }
    public int Year { get; set; }

    public Fridge? Fridge { get; set; }
}