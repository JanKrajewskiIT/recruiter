using Microsoft.EntityFrameworkCore;
using Questions.Domain.Entities;

namespace Questions.Infrastructure.Context;

internal static class ModelBuilderExtensions
{
    internal static void SeedData( this ModelBuilder modelBuilder )
    {
        modelBuilder.Entity<CategoryEntity>().HasData(
            CreateCategory( "bb1c2675-5877-4aa5-9bc6-00be8d449549", "Przygotowanie na rozmowę", "CiCircleList", 1 ),
            CreateCategory( "997bb095-fb04-4872-ac35-0d05cedc3de0", "Umiejętności miękkie", "BsPersonFillCheck", 2 ),
            CreateCategory( "28aec609-f96e-4ae6-8db2-358a1892502e", "Architektura", "BsDiagram3Fill", 3 ),
            CreateCategory( "a16bb186-092e-440d-92c9-fe57cd96ec4f", "Algorytmy", "VscServerProcess", 4 ),
            CreateCategory( "4ec57b9a-8753-4ec0-bebe-d4d361c9ecf2", "C#", "SiCsharp", 5 ),
            CreateCategory( "6c5cf69c-c674-4fc0-b613-c45daa8633c0", ".Net", "SiDotnet", 6 ),
            CreateCategory( "d5dfef6e-6be4-42b2-a5b8-4852c733bcf8", "SQL", "SiMysql", 7 ),
            CreateCategory( "3bb831ec-69aa-4a75-a71e-5079dc06ac26", "React", "SiReact", 8 ),
            CreateCategory( "c13e9522-2b62-433a-9bd6-365e49233508", "Type Script", "SiTypescript", 9 ),
            CreateCategory( "9dd3c14f-3685-4370-bc0c-42ee8bf2b2e8", "CSS3", "SiCss3", 10 ),
            CreateCategory( "db7d3eaa-d153-48d4-b000-383a8cf1fc6f", "HTML5", "SiHtml5", 11 ),

            CreateCategory( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Wzorce projektowe", string.Empty, 1, "28aec609-f96e-4ae6-8db2-358a1892502e" ),
            CreateCategory( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "OOP", string.Empty, 2, "28aec609-f96e-4ae6-8db2-358a1892502e" ),
            CreateCategory( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Wielowątkowość", string.Empty, 1, "a16bb186-092e-440d-92c9-fe57cd96ec4f" )
        );


        modelBuilder.Entity<QuestionEntity>().HasData(
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Jakie znasz wzorce projektowe i architektoniczne ? Z których i jak korzystałeś ? Najważniejsze wzorce z GOF Gang of Four." ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Singleton (dlaczego to czasem antypatern)" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Zaimplementuj singleton z bezpiecznym dostępem wielowątkowym (pamiętać o synchronizacji / double checking pattern / ew. SingletonHolder z bezpiecznym dostępem bez konieczności synchronizacji)." ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Metoda fabryki" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Fabryka abstrakcyjna" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Czym różną się wzorce fabryki abstrakcyjnej i metody fabryki ?" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Dekorator" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Obserwator" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Facade pattern (bardzo ważny wzorzec)" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Adapter" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Strategia" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Template method" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Builder" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Czy StringBuilder jest realizacją wzorca Builder ?" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Mediator" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Na czym polega wzorzec CQS i CQRS (command, action)?" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "MVC" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "MVVM" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "MVP" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "AOP" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "DAO" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "DTO" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Repository" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Unit Of Work" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Circuit Braker" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Retry" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Proxy" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Czym jest Dependency Injection ? Jak to wygląda niskopoziomowo w C# ?" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Czym jest Dependency Inversion i jak się ma do Dependency Injection ?" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Czym jest IoC ? W jaki sposób jest powiązane z DI ?" ),
            CreateQuestion( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Jakie są plusy stosowania DI i IoC? W jaki sposób stosowanie DI / IoC wspomaga testowanie jednostkowe?" ),


            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Czym jest SOLID? Opisz wszystkie zasady. Podaj przykłady." ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Jak w SOLID można złamać regułę L ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Czym jest reguła KISS ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Czym jest reguła DRY ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Czym jest reguła YAGNI ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Czym jest reguła SoC ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Czym jest reguła TDA ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Czym jest OOP ? Jakie są 4 główne zasady programowania obiektowego ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Czym jest polimorfizm dynaczminy i statyczny ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Czym charakteryzują się klasa abstrakcyjna i metoda abstrakcyjna ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Która zasada OOP według ciebie jest najważniejsza ?" ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Przedstaw ideę dziedziczenia na przykładzie z życia." ),
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Zadania z wykorzystaniem polimorfizmu i dziedziczenia, gdzie określa się co wypisze metoda." )

        );
    }

    private static CategoryEntity CreateCategory( string id, string name, string iconName, int order, string? parentId = null)
        => new()
        {
            Id = Guid.Parse( id ),
            ParentCategoryId = Guid.TryParse( parentId, out var guid ) ? guid : null ,
            Name = name,
            IconName = iconName,
            Order = order
        };

    private static QuestionEntity CreateQuestion( string categoryId, string name, string? description = null )
        => new()
        {
            Id = Guid.NewGuid(),
            CreatedBy = Guid.Empty,
            CreatedOn = DateTimeOffset.Now,
            ModifiedBy = Guid.Empty,
            ModifiedOn = DateTimeOffset.Now,
            Name = name,
            Description = description,
            CategoryId = Guid.Parse( categoryId )
        };
    
}
