using MediatR;
using Organizer.Application.Models;
using Organizer.Domain.Enums;

namespace Organizer.Application.Queries;

public sealed record GetOffersQuery( OfferStatus Status ) : IRequest<IEnumerable<Offer>>;
