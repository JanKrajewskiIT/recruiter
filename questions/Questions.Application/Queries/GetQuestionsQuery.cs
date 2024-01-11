using MediatR;
using Questions.Application.Models;

namespace Questions.Application.Queries;

public sealed record GetQuestionsQuery( Guid CategoryId ) : IRequest<IEnumerable<Question>>;
