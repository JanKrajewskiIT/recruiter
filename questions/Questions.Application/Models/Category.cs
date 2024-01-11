namespace Questions.Application.Models;

public record Category(
    string Name,
    string? Description,
    string? IconName,
    int Order,
    IEnumerable<Category>? ChildCategories );
