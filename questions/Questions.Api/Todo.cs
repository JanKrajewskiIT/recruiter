namespace Questions.Api;

internal record Todo( int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false );