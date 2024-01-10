namespace Questions.Domain.Entities;

public abstract class BaseEntity : IEntity
{
    public required Guid Id { get; init; }

    public bool HasAssignedId => Id != Guid.Empty;
}