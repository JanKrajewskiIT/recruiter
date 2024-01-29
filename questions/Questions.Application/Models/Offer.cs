namespace Questions.Application.Models;

public record Offer(
    Guid Id,
    string Name,
    string Link,
    string Company,
    string City,
    string []Reasons,
    string? Description );