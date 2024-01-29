using Organizer.Domain.Enums;

namespace Organizer.Application.Models;

public record OfferState(
    Guid Id,
    OfferStatus Status,
    string[] Reasons );