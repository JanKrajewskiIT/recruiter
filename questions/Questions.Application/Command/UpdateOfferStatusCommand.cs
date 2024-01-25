using MediatR;
using Questions.Domain.Enums;

namespace Questions.Application.Command;

public sealed record UpdateOfferStatusCommand( Guid Id, OfferStatus Status ) : INotification;