using Questions.Domain.Enums;

namespace Questions.Domain.Entities;

public class OfferEntity : AuditEntity
{
    public required string Name { get; init; }

    public required string Link { get; init; }

    public required string Company { get; init; }

    public required string City { get; init; }

    public required OfferStatus Status { get; init; }

    public string? Description { get; init; }
}
