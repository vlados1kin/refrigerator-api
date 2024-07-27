using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class Product
{
    [Column("ProductId")] 
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Name is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for the Name field is 50 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Default Quantity is a required field.")]
    public int DefaultQuantity { get; set; }

    public Node? Node { get; set; }
}