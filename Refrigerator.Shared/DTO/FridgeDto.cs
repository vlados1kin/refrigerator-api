using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Shared.DTO;

public record FridgeDto
{
    public string? Name { get; init; }
    public string? OwnerName { get; init; }
    public ModelDto? ModelDto { get; init; }
}