using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Organizer.Domain.Enums;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Organizer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:dictionary_key", "cities,positions,reasons")
                .Annotation("Npgsql:Enum:offer_status", "new,considered,sent,rejected");

            migrationBuilder.CreateTable(
                name: "KeyValueLists",
                columns: table => new
                {
                    Key = table.Column<DictionaryKey>(type: "dictionary_key", nullable: false),
                    Values = table.Column<string[]>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyValueLists", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Link = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Company = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<OfferStatus>(type: "offer_status", nullable: false, defaultValue: OfferStatus.New),
                    Reasons = table.Column<string[]>(type: "text[]", nullable: true),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KeyValueLists",
                columns: new[] { "Key", "Values" },
                values: new object[,]
                {
                    { DictionaryKey.Cities, new[] { "Warszawa", "Kraków", "Wrocław", "Łódź", "Poznań", "Gdańsk", "Gdynia", "Sopot", "Trójmiasto", "Szczecin", "Lublin", "Bydgoszcz", "Białystok", "Katowice", "Śląsk", "Remote", "Inne" } },
                    { DictionaryKey.Positions, new[] { "Software Developer", "Frontend Developer", "Backend Developer", "Fullstack Developer", "Junior Software Developer", "Junior Frontend Developer", "Junior Backend Developer", "Junior Fullstack Developer", "Mid Software Developer", "Mid Frontend Developer", "Mid Backend Developer", "Mid Fullstack Developer", "Senior Software Developer", "Senior Frontend Developer", "Senior Backend Developer", "Senior Fullstack Developer", "Lead Software Developer", "Lead Frontend Developer", "Lead Backend Developer", "Lead Fullstack Developer", "Software Architect", "Frontend Architect", "Backend Architect", "DevOps" } },
                    { DictionaryKey.Reasons, new[] { "Stos technologiczny", "Stawka", "Forma współpracy UoP", "Forma współpracy B2B", "Praca zdalna", "Praca hybrydowa", "Praca z biura", "Język obcy", "Język ojczysty", "Zakres obowiązków", "Lokalizacja", "Godziny pracy", "Opieka medyczna", "Multisport", "Wyjazdy służbowe", "Integracje", "Biuro", "Inne" } }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeyValueLists");

            migrationBuilder.DropTable(
                name: "Offers");
        }
    }
}
