namespace Extensions.Domain.Entities;

public abstract class AuditEntity : BaseEntity
{
    public Guid CreatedBy { get; init; }

    public DateTimeOffset CreatedOn { get; init; }

    public Guid ModifiedBy { get; init; }

    public DateTimeOffset ModifiedOn { get; init; }
}
