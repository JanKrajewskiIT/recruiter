namespace Questions.Domain.Entities;

internal class CategoryEntity : AuditEntity
{
    public required string Name { get; init; }

    public string? Description { get; init; }

    public string? ImageUrl { get; init; }

    public int Order { get; init; }

    public virtual CategoryEntity? ParentCategory { get; init; }

    public Guid? ParentCategoryId { get; init; }
}
