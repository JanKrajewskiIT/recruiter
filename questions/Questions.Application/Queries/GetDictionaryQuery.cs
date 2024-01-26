using MediatR;
using Questions.Domain.Enums;

namespace Questions.Application.Queries;

public sealed record GetDictionaryQuery( DictionaryKey Key ) : IRequest<IEnumerable<string>>;