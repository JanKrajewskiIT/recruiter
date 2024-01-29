using MediatR;

namespace Organizer.Application.Command;

public sealed record DeleteOfferCommand( Guid Id ) : INotification;