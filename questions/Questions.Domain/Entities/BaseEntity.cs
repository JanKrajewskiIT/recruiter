namespace Questions.Domain.Entities;

internal abstract class BaseEntity
{
    public required Guid Id { get; init; }

    public bool HasAssignedId => Id != Guid.Empty;
}