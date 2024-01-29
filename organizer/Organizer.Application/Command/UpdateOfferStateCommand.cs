using MediatR;
using Organizer.Application.Models;

namespace Organizer.Application.Command;

public sealed record UpdateOfferStateCommand( Guid Id, OfferState State ) : INotification;