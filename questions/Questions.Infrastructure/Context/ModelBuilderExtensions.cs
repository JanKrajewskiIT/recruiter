using Microsoft.EntityFrameworkCore;
using Questions.Domain.Entities;

namespace Questions.Infrastructure.Context;

internal static class ModelBuilderExtensions
{
    internal static void SeedData( this ModelBuilder modelBuilder )
    {
        modelBuilder.Entity<CategoryEntity>().HasData(
            new CategoryEntity
            {
                Id = Guid.Parse( "bb1c2675-5877-4aa5-9bc6-00be8d449549" ),
                Name = "Przygotowanie na rozmowę",
                Order = 1,
            },
            new CategoryEntity
            {
                Id = Guid.Parse( "997bb095-fb04-4872-ac35-0d05cedc3de0" ),
                Name = "Umiejętności miękkie",
                Order = 2,
            },
            new CategoryEntity
            {
                Id = Guid.Parse( "28aec609-f96e-4ae6-8db2-358a1892502e" ),
                Name = "Architektura",
                Order = 3,
            },
            new CategoryEntity
            {
                Id = Guid.Parse( "a16bb186-092e-440d-92c9-fe57cd96ec4f" ),
                Name = "Algorytmy",
                Order = 4,
            },
            new CategoryEntity
            {
                Id = Guid.Parse( "e5541ffc-ed59-4f27-acb6-2b2b3da04bb2" ),
                Name = "C#",
                Order = 5,
            },
            new CategoryEntity
            {
                Id = Guid.Parse( "4ec57b9a-8753-4ec0-bebe-d4d361c9ecf2" ),
                Name = ".Net",
                Order = 6,
            },
            new CategoryEntity
            {
                Id = Guid.Parse( "7497e8fc-80a5-42df-ac48-c09f695dc402" ),
                ParentCategoryId = Guid.Parse( "28aec609-f96e-4ae6-8db2-358a1892502e" ),
                Name = "Wzorce projektowe",
                Order = 1
            },
            new CategoryEntity
            {
                Id = Guid.Parse( "0a07f758-355f-4796-8ab4-f5a34cfca181" ),
                ParentCategoryId = Guid.Parse( "a16bb186-092e-440d-92c9-fe57cd96ec4f" ),
                Name = "Wielowątkowość",
                Order = 1
            }
        );
    }
}
