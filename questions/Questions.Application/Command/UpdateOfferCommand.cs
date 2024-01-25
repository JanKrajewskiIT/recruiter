using MediatR;
using Questions.Application.Models;

namespace Questions.Application.Command;

public sealed record UpdateOfferCommand( Offer Offer ) : INotification;