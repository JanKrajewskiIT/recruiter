using MediatR;
using Organizer.Domain.Enums;

namespace Organizer.Application.Queries;

public sealed record GetDictionaryQuery( DictionaryKey Key ) : IRequest<IEnumerable<string>>;