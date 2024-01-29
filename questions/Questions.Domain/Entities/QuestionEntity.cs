using Extensions.Domain.Entities;

namespace Questions.Domain.Entities;

public class QuestionEntity : AuditEntity
{
    public required string Name { get; init; }

    public string? Description { get; init; }

    public required Guid CategoryId { get; init; }
}
