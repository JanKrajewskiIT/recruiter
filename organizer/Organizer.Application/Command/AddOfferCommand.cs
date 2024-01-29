using MediatR;
using Organizer.Application.Models;

namespace Organizer.Application.Command;

public sealed record AddOfferCommand( Offer Offer ) : INotification;