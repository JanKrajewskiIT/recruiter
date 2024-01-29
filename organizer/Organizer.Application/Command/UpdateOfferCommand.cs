using MediatR;
using Organizer.Application.Models;

namespace Organizer.Application.Command;

public sealed record UpdateOfferCommand( Guid Id, Offer Offer ) : INotification;