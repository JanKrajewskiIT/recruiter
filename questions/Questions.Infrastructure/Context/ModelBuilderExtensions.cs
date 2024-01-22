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

            CreateCategory( "0faca7b4-e59d-483b-82a9-785d960c5760", "Pojęcia", string.Empty, 1, "28aec609-f96e-4ae6-8db2-358a1892502e" ),
            CreateCategory( "7497e8fc-80a5-42df-ac48-c09f695dc402", "Wzorce projektowe", string.Empty, 2, "28aec609-f96e-4ae6-8db2-358a1892502e" ),
            CreateCategory( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "OOP", string.Empty, 3, "28aec609-f96e-4ae6-8db2-358a1892502e" ),

            CreateCategory( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Wielowątkowość", string.Empty, 1, "a16bb186-092e-440d-92c9-fe57cd96ec4f" ),

            CreateCategory( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Generalne", string.Empty, 1, "4ec57b9a-8753-4ec0-bebe-d4d361c9ecf2" ),
            CreateCategory( "77540274-e44d-47a5-94d3-86ccdacedb0c", "Wyjątki", string.Empty, 2, "4ec57b9a-8753-4ec0-bebe-d4d361c9ecf2" ),
            CreateCategory( "23441e50-8dbc-4d2c-90a2-d623104fb37b", "Wątki", string.Empty, 3, "4ec57b9a-8753-4ec0-bebe-d4d361c9ecf2" ),
            CreateCategory( "8c0ad679-b40d-4db3-8c2b-ef59204005ae", "Refleksja", string.Empty, 4, "4ec57b9a-8753-4ec0-bebe-d4d361c9ecf2" ),

            CreateCategory( "36defef5-c34e-40be-b461-d217bb255566", "Platforma", string.Empty, 1, "6c5cf69c-c674-4fc0-b613-c45daa8633c0" ),
            CreateCategory( "7dad0a17-08f5-4396-a4dc-784c427f9320", "Kompilator", string.Empty, 2, "6c5cf69c-c674-4fc0-b613-c45daa8633c0" ),
            CreateCategory( "e28039da-8c48-4fcf-ab57-09196b612864", "Ogólne", string.Empty, 3, "6c5cf69c-c674-4fc0-b613-c45daa8633c0" ),
            CreateCategory( "2a736d5a-1c48-4515-bdcb-f93bbad77db3", "GC", string.Empty, 4, "6c5cf69c-c674-4fc0-b613-c45daa8633c0" ),
            CreateCategory( "caa6e3b0-8e5a-4bd2-b36d-3114201e7be1", "Kolekcje", string.Empty, 5, "6c5cf69c-c674-4fc0-b613-c45daa8633c0" ),
            CreateCategory( "d3157372-95f8-4b34-a836-2538a87162c3", "WebAPI", string.Empty, 6, "6c5cf69c-c674-4fc0-b613-c45daa8633c0" ),
            CreateCategory( "209537e5-fdc0-4a4c-8c4b-851021855c53", "MVC", string.Empty, 7, "6c5cf69c-c674-4fc0-b613-c45daa8633c0" ),
            CreateCategory( "a483b653-422d-41bb-a2ba-c8793bf1cd6d", "WCF", string.Empty, 8, "6c5cf69c-c674-4fc0-b613-c45daa8633c0" )
        );

        modelBuilder.Entity<QuestionEntity>().HasData(
            CreateQuestion( "0faca7b4-e59d-483b-82a9-785d960c5760", "Czy różni się argument od parametru ?" ),
            CreateQuestion( "0faca7b4-e59d-483b-82a9-785d960c5760", "Czym jest deklaracja vs definicja vs inicjalizacja ?" ),
            CreateQuestion( "0faca7b4-e59d-483b-82a9-785d960c5760", "Której generacji językiem jest C# ?" ),

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
            CreateQuestion( "71c8a70b-0e81-4b79-a7f8-fb51fcbef984", "Zadania z wykorzystaniem polimorfizmu i dziedziczenia, gdzie określa się co wypisze metoda." ),

            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Czym jest wielowątkowość ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "W jakich sytuacjach warto zastosować wielowątkowość a w jakich nie ? Z jakimi problemami wiąże się takie podejście ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Czym różni się wywołanie synchroniczne od asynchronicznego ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Czym różni się proces od wątku ? Jak to się je z dostępem do zasobów ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Jakie znasz mechanizmy synchronizacji wątków i z jakich korzystałeś ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Jak działa lock ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Jak działa Monitor ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Jak działa Semafor" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Jak działa Mutex ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Czym różni się lock od monitora ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Czym są wątki foreground i background ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Czym jest deadlock ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Czym jest Event Bus ? Jakie znasz rodzaje ESB ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Jeśli uderzasz requestami do serwisu bankowego i on przestanie działać - jak temu zapobiec ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Czy każdy wątek ma swój oddzielny stos ? Ile stosów mamy w aplikacji ?" ),
            CreateQuestion( "0a07f758-355f-4796-8ab4-f5a34cfca181", "Co to znaczy, że coś jest thread safe ?" ),

            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest C# ? Jakie są jego zalety i najważniejsze cechy ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czy string jest typem wartości czy referencyjnym ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Zadanie, w którym robiony jest Replace() na stringu ale nigdzie nie jest przypisywany rezultat i co zwróci zmienna ? Łatwo się złapać." ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym różni się pole const od static readonly ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Jaka jest różnica między var a dynamic ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest delegat ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest extension i w jakim celu się stosuje ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czy można wywoływać extension method na obiektach null ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Jaka jest różnica pomiędzy ref i out ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Pytania o to, która definicja metody jest poprawna." ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Pytanie typu, co zwróci wyrażenie `var zmienna = new Abc<x, y, z>((a, b) => a == b)` jeśli nieznane typy to object" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest interfejs ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Jaka jest różnica między interfejsem a klasą abstrakcyjną ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest klasa abstrakcyjna ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Gdzie i po co stosuje się słowo kluczowe sealed ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest klasa partial i po co się ją stosuje ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest struct ? Czy jest typem prostym czy złożonym ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czy jeśli zmienisz struct przesyłany w parametrze metody to zmiana będzie widoczna poza tą metodą ? Jak na to wpłynąć ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "W jaki sposób można rzutować wartości na inne typy ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest boxing i unboxing ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym się różni rzutowanie bezpośrednie od wykorzystania \"as\" ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym są generyki ? Na co pozwalają ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "W jakich sytuacjach wykorzystujemy słowo kluczowe using ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czy można zastąpić IDisposable poprzez try/catch/finally ? Dlaczego się z tego w takim razie korzysta?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Gdzie w mechanizmie wywoływana jest metoda Dispose() ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Zaimplementuj rozszerzoną wersję klasy implementującej IDisposable." ),         
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest atrybut ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czy tworzyłeś kiedyś customowy atrybut ? Jaki?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym jest parsowanie ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Czym różni się metoda Parse od TryParse ? Jak zwracane są typy i błędy ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Jaki typ zwraca GetHashCode() ? Czy jest możliwe, że zwróci tę samą wartość dla dwóch różnych obiektów ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Gdzie wykorzystywany jest GetHashCode ? Czy w HashMapie dodanie dwóch różnych elementów z tym samym hashCodem nadpisze je ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Jakie mamy typy zmiennych w C# ? Jak są przechowywane w pamięci ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Jak działają operatory \"is\", nameof i typeof ?" ),
            CreateQuestion( "2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b", "Jaka jest różnica między typami string i String ?" ),

            CreateQuestion( "77540274-e44d-47a5-94d3-86ccdacedb0c", "Opisz blok try/catch/finally ? Co kiedy jest wywoływane ?" ),
            CreateQuestion( "77540274-e44d-47a5-94d3-86ccdacedb0c", "Jak wygląda multicatch ?" ),
            CreateQuestion( "77540274-e44d-47a5-94d3-86ccdacedb0c", "Jaki jest porządek wywoływania kolejnych bloków catch ? Jak to wygląda przy wyjątkach dziedziczonych ?" ),
            CreateQuestion( "77540274-e44d-47a5-94d3-86ccdacedb0c", "Jaka jest kolejność wywoływania bloków catch w obsłudze wyjątków ? Zwrócić uwagę na dziedziczenie wyjątków." ),
            CreateQuestion( "77540274-e44d-47a5-94d3-86ccdacedb0c", "Co jeśli w bloku finally pojawi się wyjątek ?" ),
            CreateQuestion( "77540274-e44d-47a5-94d3-86ccdacedb0c", "Jaka jest różnica w wywołaniu \"throw e\" od \"throw\" ? Który standard jest lepszy ?" ),

            CreateQuestion( "23441e50-8dbc-4d2c-90a2-d623104fb37b", "Czy korzystałeś z mechanizmów wielowątkowych w .NET ? Jeśli tak to z jakich ?" ),
            CreateQuestion( "23441e50-8dbc-4d2c-90a2-d623104fb37b", "Z czym związane są słowa async i await ?" ),
            CreateQuestion( "23441e50-8dbc-4d2c-90a2-d623104fb37b", "Co musi posiadać metoda opisana słowem kluczowym async?" ),
            CreateQuestion( "23441e50-8dbc-4d2c-90a2-d623104fb37b", "Kiedy warto korzystać z async-ów ?" ),
            CreateQuestion( "23441e50-8dbc-4d2c-90a2-d623104fb37b", "Czy można zadeklarować Task zwracający void ? Czy jest to preferowane podejście ?" ),
            CreateQuestion( "23441e50-8dbc-4d2c-90a2-d623104fb37b", "Czym różni się typ Thread od Task ?" ),
            CreateQuestion( "23441e50-8dbc-4d2c-90a2-d623104fb37b", "Czym jest klasa BackgroundWorker ?" ),
            CreateQuestion( "23441e50-8dbc-4d2c-90a2-d623104fb37b", "Wymień dwa wielowątkowe typy w .NET." ),

            CreateQuestion( "8c0ad679-b40d-4db3-8c2b-ef59204005ae", "Czym jest refleksja ?" ),
            CreateQuestion( "8c0ad679-b40d-4db3-8c2b-ef59204005ae", "Czy można wywołać metodę prywatną za pomocą refleksji ?" ),
            CreateQuestion( "8c0ad679-b40d-4db3-8c2b-ef59204005ae", "Czy za pomocą refleksji można dodać nowy typ ?" ),
            CreateQuestion( "8c0ad679-b40d-4db3-8c2b-ef59204005ae", "Czy za pomocą refleksji można dodać property do istniejącego typu ?" ),

            CreateQuestion( "36defef5-c34e-40be-b461-d217bb255566", "Czym jest .Net Framework ?" ),
            CreateQuestion( "36defef5-c34e-40be-b461-d217bb255566", "Czym jest .Net Core ?" ),
            CreateQuestion( "36defef5-c34e-40be-b461-d217bb255566", "Czym jest .Net Standard ?" ),
            CreateQuestion( "36defef5-c34e-40be-b461-d217bb255566", "Co nowego wprowadza technologia .Net Core w porównaniu do .Net Framework ?" ),
            CreateQuestion( "36defef5-c34e-40be-b461-d217bb255566", "Dlaczego korzystając z .NET Core można tworzyć aplikacje na serwery Linuxowe ?" ),
            CreateQuestion( "36defef5-c34e-40be-b461-d217bb255566", "Kiedy warto wykorzystać technologie .Net Core ?" ),
            CreateQuestion( "36defef5-c34e-40be-b461-d217bb255566", "Ile języków funkcjonuje na platformie .Net ?" ),
            CreateQuestion( "36defef5-c34e-40be-b461-d217bb255566", "Jakie są różnice między Javą a .NET ? Który język wydaje ci się fajniejszy ?" ),

            CreateQuestion( "7dad0a17-08f5-4396-a4dc-784c427f9320", "Czym jest CLI ?" ),
            CreateQuestion( "7dad0a17-08f5-4396-a4dc-784c427f9320", "Czym jest  CLS ?" ),
            CreateQuestion( "7dad0a17-08f5-4396-a4dc-784c427f9320", "Czym jest CLR ?" ),
            CreateQuestion( "7dad0a17-08f5-4396-a4dc-784c427f9320", "Czym jest JIT ? Kiedy się wykonuje ?" ),

            CreateQuestion( "e28039da-8c48-4fcf-ab57-09196b612864", "Czym jest IIS ?" ),
            CreateQuestion( "e28039da-8c48-4fcf-ab57-09196b612864", "Czym jest pula w IIS ?" ),
            CreateQuestion( "e28039da-8c48-4fcf-ab57-09196b612864", "Jaki jest cykl życia obiektów zarejestrowanych jako singleton, scoped i transient ?" ),
            CreateQuestion( "e28039da-8c48-4fcf-ab57-09196b612864", "Jakie znasz realizacje kontenerów DI w .NET ?" ),
            CreateQuestion( "e28039da-8c48-4fcf-ab57-09196b612864", "Porównaj dwa wybrane kontenery DI np. Autofac, Unity, Ninject." ),
            CreateQuestion( "e28039da-8c48-4fcf-ab57-09196b612864", "Jak w DI można obsłużyć interfejsy generyczne ?" ),
            CreateQuestion( "e28039da-8c48-4fcf-ab57-09196b612864", "Jakie poczynić kroki aby wyzbyć sie circular dependencies ?" ),
            
            CreateQuestion( "2a736d5a-1c48-4515-bdcb-f93bbad77db3", "Jak działa GC ? Kiedy wywoływany jest GC ?" ),
            CreateQuestion( "2a736d5a-1c48-4515-bdcb-f93bbad77db3", "Czy można manualnie wywołać GC ? Jak ? Jeśli można wywołać manualnie GC to czy czyszczenie wykona się od razu ?" ),
            CreateQuestion( "2a736d5a-1c48-4515-bdcb-f93bbad77db3", "Czy GC wywołuje metodę Dispose ? A może Finalize() ? Jaka jest różnica między Disposable a Finalize." ),
            CreateQuestion( "2a736d5a-1c48-4515-bdcb-f93bbad77db3", "Czym są generacje w GC ?" ),
            CreateQuestion( "2a736d5a-1c48-4515-bdcb-f93bbad77db3", "Czy GC dotyka typów value podczas czyszczenia ?" ),

            CreateQuestion( "caa6e3b0-8e5a-4bd2-b36d-3114201e7be1", "Wymień i opisz kolekcje występujące w technologii .Net." ),
            CreateQuestion( "caa6e3b0-8e5a-4bd2-b36d-3114201e7be1", "Jaka jest różnica między listą a hashsetem ?" ),
            CreateQuestion( "caa6e3b0-8e5a-4bd2-b36d-3114201e7be1", "Czym są interfejsy IEnumerable oraz IQueryable ?" ),
            CreateQuestion( "caa6e3b0-8e5a-4bd2-b36d-3114201e7be1", "Czym różnią się od siebie IEnumerable od IQueryable ?" ),
            CreateQuestion( "caa6e3b0-8e5a-4bd2-b36d-3114201e7be1", "Co się stanie po wywołaniu np. query.ToArray().Skip(20) w przypadku IEnumerable i IQueryable ?" ),
            CreateQuestion( "caa6e3b0-8e5a-4bd2-b36d-3114201e7be1", "Jak działa wykonywanie operacji Ling na IEnumerable ? Czy wykonywana jest operacja yield ? Na co to wpływa ?" )
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
