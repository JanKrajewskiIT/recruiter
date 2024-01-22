using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Questions.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: true),
                    IconName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    ParentCategoryId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IconName", "Name", "Order", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("28aec609-f96e-4ae6-8db2-358a1892502e"), null, "", "Architektura", 3, null },
                    { new Guid("3bb831ec-69aa-4a75-a71e-5079dc06ac26"), null, "", "React", 8, null },
                    { new Guid("4ec57b9a-8753-4ec0-bebe-d4d361c9ecf2"), null, "", "C#", 5, null },
                    { new Guid("6c5cf69c-c674-4fc0-b613-c45daa8633c0"), null, "", ".Net", 6, null },
                    { new Guid("997bb095-fb04-4872-ac35-0d05cedc3de0"), null, "", "Umiejętności miękkie", 2, null },
                    { new Guid("9dd3c14f-3685-4370-bc0c-42ee8bf2b2e8"), null, "", "CSS", 10, null },
                    { new Guid("a16bb186-092e-440d-92c9-fe57cd96ec4f"), null, "", "Algorytmy", 4, null },
                    { new Guid("bb1c2675-5877-4aa5-9bc6-00be8d449549"), null, "", "Przygotowanie na rozmowę", 1, null },
                    { new Guid("c13e9522-2b62-433a-9bd6-365e49233508"), null, "", "Type Script", 9, null },
                    { new Guid("d5dfef6e-6be4-42b2-a5b8-4852c733bcf8"), null, "", "SQL", 7, null },
                    { new Guid("db7d3eaa-d153-48d4-b000-383a8cf1fc6f"), null, "", "HTML", 11, null },
                    { new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), null, "", "Wielowątkowość", 1, new Guid("a16bb186-092e-440d-92c9-fe57cd96ec4f") },
                    { new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), null, "", "OOP", 2, new Guid("28aec609-f96e-4ae6-8db2-358a1892502e") },
                    { new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), null, "", "Wzorce projektowe", 1, new Guid("28aec609-f96e-4ae6-8db2-358a1892502e") }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("00ea2cd9-29fc-4edf-9678-856d2e0d026c"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1483), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Template method" },
                    { new Guid("05244e2d-bff1-4aad-9f9f-1d6358601015"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1560), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DTO" },
                    { new Guid("099057e7-cdbf-435c-9bd1-8bbeed1fb1cf"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Inversion i jak się ma do Dependency Injection ?" },
                    { new Guid("09d9ea00-c11d-46ef-8e92-6b937d6acddb"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1545), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVP" },
                    { new Guid("0a526e95-5e05-4556-a72d-ae9ea53b7212"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1536), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVC" },
                    { new Guid("0f38d66c-7f9b-413e-8fcf-ddcccd653313"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1474), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Adapter" },
                    { new Guid("14eed201-e5c2-4cec-9053-e4c970516cc6"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1479), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Strategia" },
                    { new Guid("1a3bc195-634b-4248-973f-72ba6b2d74eb"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1516), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Builder" },
                    { new Guid("27ae4e63-b6a9-4ce7-8c54-b7e915dbd0b4"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1568), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Unit Of Work" },
                    { new Guid("28261dbf-e6f9-4f3d-982c-77205cb2a827"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Proxy" },
                    { new Guid("34d97f39-eb30-43c9-abb4-bfed43705f4e"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest IoC ? W jaki sposób jest powiązane z DI ?" },
                    { new Guid("36c9767b-8b8b-440a-a07b-7eb7c8d7537b"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1646), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym charakteryzują się klasa abstrakcyjna i metoda abstrakcyjna ?" },
                    { new Guid("441a80ef-8109-4d10-bd7a-d5334cd9871e"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1540), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVVM" },
                    { new Guid("44277bb3-0a84-47a5-aade-6978080216a0"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest SOLID? Opisz wszystkie zasady. Podaj przykłady." },
                    { new Guid("548e56fa-6f51-41fb-a946-6886e1f5704c"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1626), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła SoC ?" },
                    { new Guid("56411403-30ba-4dca-b3c8-c32b106c1222"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1585), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Injection ? Jak to wygląda niskopoziomowo w C# ?" },
                    { new Guid("5f519d61-30d3-4fa7-a69c-2d346d7406a4"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1470), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Facade pattern (bardzo ważny wzorzec)" },
                    { new Guid("66308f56-aea1-4896-8c2b-65fcc81bfc11"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zaimplementuj singleton z bezpiecznym dostępem wielowątkowym (pamiętać o synchronizacji / double checking pattern / ew. SingletonHolder z bezpiecznym dostępem bez konieczności synchronizacji)." },
                    { new Guid("6aa1562f-706d-4a4f-8b14-aab3f04bf51c"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1437), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Metoda fabryki" },
                    { new Guid("6b25df27-e50a-4177-921b-1b177ccfb73b"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła KISS ?" },
                    { new Guid("6bcfb1c1-30a9-4b4a-a211-98624f8fb8f4"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1553), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DAO" },
                    { new Guid("6ec0ffbc-7e73-460a-9b2c-7eee9bcf095a"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1654), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Przedstaw ideę dziedziczenia na przykładzie z życia." },
                    { new Guid("7fb796e7-a90a-40dd-9702-950c4922064f"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1428), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Singleton (dlaczego to czasem antypatern)" },
                    { new Guid("80ab5d56-c5da-4169-93dc-e0591978d67b"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1658), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zadania z wykorzystaniem polimorfizmu i dziedziczenia, gdzie określa się co wypisze metoda." },
                    { new Guid("8c46bca7-c348-4267-8252-a3825b1ab522"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1564), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Repository" },
                    { new Guid("8ca02f69-35cd-4ed3-b7c7-da1fb7699654"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1532), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Na czym polega wzorzec CQS i CQRS (command, action)?" },
                    { new Guid("8d75dbe0-1bb7-4176-af2a-c2c9cf1fb8fe"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła TDA ?" },
                    { new Guid("94aabedc-a65f-4dba-8626-64ab98edc377"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1549), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "AOP" },
                    { new Guid("96c85022-fa17-4d44-8f1b-2c02739164e7"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1523), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy StringBuilder jest realizacją wzorca Builder ?" },
                    { new Guid("9c73c066-d507-445a-9aee-937dd7cee0dc"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Retry" },
                    { new Guid("9cb074c5-fb65-49e0-a39c-14f3a0c02f35"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1457), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różną się wzorce fabryki abstrakcyjnej i metody fabryki ?" },
                    { new Guid("9d51056d-b87a-4405-851b-9fcc961bdb52"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1609), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w SOLID można złamać regułę L ?" },
                    { new Guid("9fe58812-2193-4b8c-9c69-2c743718999a"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1365), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz wzorce projektowe i architektoniczne ? Z których i jak korzystałeś ? Najważniejsze wzorce z GOF Gang of Four." },
                    { new Guid("a2764b5b-4ea4-4e64-9b2c-fce0767663aa"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest OOP ? Jakie są 4 główne zasady programowania obiektowego ?" },
                    { new Guid("a5d3e8d1-a7a3-4e1d-aa44-fa3cc8e75a57"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła DRY ?" },
                    { new Guid("b1c34f5d-7a3a-4241-94fe-49da5348625f"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła YAGNI ?" },
                    { new Guid("b58819f1-0aac-4141-81da-99f5bc500017"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1641), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest polimorfizm dynaczminy i statyczny ?" },
                    { new Guid("c6e9451e-d980-44f4-93bb-ef9cc0c5fca4"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1650), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Która zasada OOP według ciebie jest najważniejsza ?" },
                    { new Guid("ce8e00d5-da96-4083-9023-b9054eb2710a"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1600), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są plusy stosowania DI i IoC? W jaki sposób stosowanie DI / IoC wspomaga testowanie jednostkowe?" },
                    { new Guid("ceab8e84-ab29-4bb0-ac04-6d0da576ca44"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1442), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Fabryka abstrakcyjna" },
                    { new Guid("d6a35f54-7a35-49b1-bb16-f19944ea7628"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1466), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Obserwator" },
                    { new Guid("d80333b1-8a90-4304-985f-c34015c40d43"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Mediator" },
                    { new Guid("e64847d9-606d-4036-a2bb-10d25138edf4"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1573), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Circuit Braker" },
                    { new Guid("ecd6b0cc-9d4a-4357-8c93-f1ea489f482f"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 36, 3, 991, DateTimeKind.Unspecified).AddTicks(1462), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Dekorator" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
