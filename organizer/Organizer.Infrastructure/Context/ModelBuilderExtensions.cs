using Microsoft.EntityFrameworkCore;
using Organizer.Domain.Entities;
using Organizer.Domain.Enums;

namespace Organizer.Infrastructure.Context;

internal static class ModelBuilderExtensions
{
    internal static readonly List<string> positions =
    [
        "Software Developer",
        "Frontend Developer",
        "Backend Developer",
        "Fullstack Developer",
        "Junior Software Developer",
        "Junior Frontend Developer",
        "Junior Backend Developer",
        "Junior Fullstack Developer",
        "Mid Software Developer",
        "Mid Frontend Developer",
        "Mid Backend Developer",
        "Mid Fullstack Developer",
        "Senior Software Developer",
        "Senior Frontend Developer",
        "Senior Backend Developer",
        "Senior Fullstack Developer",
        "Lead Software Developer",
        "Lead Frontend Developer",
        "Lead Backend Developer",
        "Lead Fullstack Developer",
        "Software Architect",
        "Frontend Architect",
        "Backend Architect",
        "DevOps"
    ];

    internal static readonly List<string> cities =
    [
        "Warszawa",
        "Kraków",
        "Wrocław",
        "Łódź",
        "Poznań",
        "Gdańsk",
        "Gdynia",
        "Sopot",
        "Trójmiasto",
        "Szczecin",
        "Lublin",
        "Bydgoszcz",
        "Białystok",
        "Katowice",
        "Śląsk",
        "Remote",
        "Inne"
    ];

    internal static readonly List<string> reasons =
    [
        "Stos technologiczny",
        "Stawka",
        "Forma współpracy UoP",
        "Forma współpracy B2B",
        "Praca zdalna",
        "Praca hybrydowa",
        "Praca z biura",
        "Język obcy",
        "Język ojczysty",
        "Zakres obowiązków",
        "Lokalizacja",
        "Godziny pracy",
        "Opieka medyczna",
        "Multisport",
        "Wyjazdy służbowe",
        "Integracje",
        "Biuro",
        "Inne"
    ];

    internal static void SeedData( this ModelBuilder modelBuilder )
    {
        modelBuilder.Entity<KeyValueListEntity>().HasData(
            new KeyValueListEntity { Key = DictionaryKey.Positions, Values = positions },
            new KeyValueListEntity { Key = DictionaryKey.Cities, Values = cities },
            new KeyValueListEntity { Key = DictionaryKey.Reasons, Values = reasons }
        );
    }
}
