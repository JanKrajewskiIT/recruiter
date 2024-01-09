namespace Questions.Domain.Entities;

internal class QuestionEntity
{
    public required string Name { get; init; }

    public string? Description { get; init; }

    public virtual required CategoryEntity Category { get; init; }

    public required Guid CategoryId { get; init; }
}
