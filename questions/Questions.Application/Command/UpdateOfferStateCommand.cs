using MediatR;
using Questions.Application.Models;

namespace Questions.Application.Command;

public sealed record UpdateOfferStateCommand( Guid Id, OfferState State ) : INotification;