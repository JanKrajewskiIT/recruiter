using Questions.Domain.Enums;

namespace Questions.Application.Models;

public record OfferState(
    Guid Id,
    OfferStatus Status,
    string[] Reasons );