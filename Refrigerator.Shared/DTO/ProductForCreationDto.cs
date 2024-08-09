namespace Refrigerator.Shared.DTO;

public record ProductForCreationDto
{
    public string? Name { get; init; }
    public int Quantity { get; init; }
}