namespace Questions.Application.Models;

public record Offer(
    string Name, 
    string CompanyName, 
    string Link, 
    string? Description);