using Microsoft.EntityFrameworkCore;
using Questions.Domain.Entities;
using Questions.Domain.Enums;

namespace Questions.Infrastructure.Context;

internal static class ModelBuilderExtensions
{
    internal static readonly List<string> positions =
    [
        "Software Developer",
        "Fullstack Developer",
        ".Net Software Developer",
        ".Net Fullstack Developer",
        "React Frontend Developer",
        "Angular Frontend Developer",
        "JavaScript Frontend Developer",
        "TypeScript Frontend Developer",
        "DevOps"
    ];

    internal static readonly List<string> cities =
    [
        "Warszawa",
        "Trójmiasto",
        "Wrocław",
        "Poznań",
        "Kraków",
        "Katowice",
        "Łódź",
        "Śląsk",
        "Remote",
        "Inne"
    ];

    internal static void SeedData( this ModelBuilder modelBuilder )
    {
        modelBuilder.Entity<KeyValueListEntity>().HasData(
            new KeyValueListEntity { Key = DictionaryKey.Positions, Values = positions },
            new KeyValueListEntity { Key = DictionaryKey.Cities, Values = cities }
        );
    }
}
