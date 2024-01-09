namespace Questions.Domain.Entities;

internal abstract class AuditEntity : BaseEntity
{
    public required Guid CreatedBy { get; init; }

    public required DateTimeOffset CreatedOn { get; init; }

    public required Guid ModifiedBy { get; set; }

    public required DateTimeOffset ModifiedOn { get; set; }
}
