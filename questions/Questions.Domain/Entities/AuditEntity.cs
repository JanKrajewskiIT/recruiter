namespace Questions.Domain.Entities;

public abstract class AuditEntity : BaseEntity
{
    public required Guid CreatedBy { get; init; }

    public required DateTimeOffset CreatedOn { get; init; }

    public required Guid ModifiedBy { get; init; }

    public required DateTimeOffset ModifiedOn { get; init; }
}
