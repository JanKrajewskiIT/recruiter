using MediatR;
using Microsoft.EntityFrameworkCore;
using Questions.Application.Models;
using Questions.Infrastructure.Context;

namespace Questions.Application.Queries;

internal class GetQuestionsQueryHandler( ApplicationDbContext dbContext ) : IRequestHandler<GetQuestionsQuery, IEnumerable<Question>>
{
    public async Task<IEnumerable<Question>> Handle( GetQuestionsQuery request, CancellationToken cancellationToken )
    {
        var questions = await dbContext.Questions
            .Where( x => x.CategoryId == request.CategoryId )
            .ToListAsync( cancellationToken );

        return questions
            .Select( x => new Question( x.Name, x.Description ) )
            .ToList();
    }
}
