using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Shared.DTO;

public record ModelDto
{
    public string? Name { get; set; }
    public int Year { get; init; }
}