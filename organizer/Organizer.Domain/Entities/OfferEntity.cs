using Extensions.Domain.Entities;
using Organizer.Domain.Enums;

namespace Organizer.Domain.Entities;

public class OfferEntity : AuditEntity
{
    public required string Name { get; set; }

    public required string Link { get; set; }

    public required string Company { get; set; }

    public required string City { get; set; }

    public required OfferStatus Status { get; set; }

    public IList<string> Reasons { get; set; } = [];

    public string? Description { get; set; }
}
