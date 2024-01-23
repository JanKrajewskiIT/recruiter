namespace Questions.Domain.Entities;

public abstract class BaseEntity : IEntity
{
    public Guid Id { get; init; }

    public bool HasAssignedId => Id != Guid.Empty;
}