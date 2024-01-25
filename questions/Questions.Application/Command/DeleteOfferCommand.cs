using MediatR;

namespace Questions.Application.Command;

public sealed record DeleteOfferCommand( Guid Id ) : INotification;