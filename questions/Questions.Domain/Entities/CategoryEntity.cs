namespace Questions.Domain.Entities;

public class CategoryEntity : BaseEntity
{
    public required string Name { get; init; }

    public string? Description { get; init; }

    public string? IconName { get; init; }

    public int Order { get; init; }

    public Guid? ParentCategoryId { get; init; }

    public virtual ICollection<CategoryEntity> ChildCategories { get; init; } = new HashSet<CategoryEntity>();

    public virtual ICollection<QuestionEntity> Questions { get; init; } = new HashSet<QuestionEntity>();
}
