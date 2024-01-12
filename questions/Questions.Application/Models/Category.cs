namespace Questions.Application.Models;

public record Category(
    string Name,
    string? Description,
    string? IconName,
    IEnumerable<Category>? ChildCategories );
