namespace Questions.Application.Models;

public record Category(
    Guid Id,
    string Name,
    string? Description,
    string? IconName,
    IEnumerable<Category>? ChildCategories );
