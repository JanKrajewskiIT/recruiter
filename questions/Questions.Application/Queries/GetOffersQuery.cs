using MediatR;
using Questions.Application.Models;
using Questions.Domain.Enums;

namespace Questions.Application.Queries;

public sealed record GetOffersQuery( OfferStatus Status ) : IRequest<IEnumerable<Offer>>;
