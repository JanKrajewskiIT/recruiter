using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Questions.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0a4239b6-6467-48f6-a16d-8f2353196690"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0c379c20-3789-4618-8651-8e41ec37f64e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("17a28823-4372-4dee-a830-91607d11c491"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1dc192f8-64a8-43b4-b286-d0b52924690e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1f4b0d13-3cbd-4907-8020-1864320afe19"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("21459d3d-768e-41ea-9a18-462b486c4baf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("23acaa15-fc2e-4144-ac89-036403de0384"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("244d496d-d561-4ef0-82c5-d9dc4e2d2889"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3538dab7-0c18-41a8-9884-06b6965cb221"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("392a8313-460e-4639-a2e6-becdce25a34b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3b2d90a4-6f68-4c8c-b38e-15e109c91f08"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3b57ff38-a9fb-4f51-85e7-5e208f559f68"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3eb8a463-4efa-40aa-b286-806b751c7b44"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4a1b4855-1de0-4d1a-a053-d0fb534a7851"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4b99cbd8-5072-4ad5-b533-3ecf5bff86f6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4c0294b2-2682-4c61-88a1-8ffd84306c5f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4e804a39-acb6-484d-86b7-79b64d7bbed5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4fa32e95-59a6-481b-a9e3-151e3298903b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("516a731d-1ffa-497d-a183-78bf70a7a062"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("58ee2bca-9e8d-4361-83ef-1b8d7aad951c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5b7fc34e-6700-478a-b4b9-c0b942affcdd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("610b2710-28f6-4e14-a35a-ae5fb3b1f971"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7590eea1-95a6-4d9c-b6c0-704c6e9a9f07"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("764bc69e-c33a-4b3f-8b3f-53f3029bfae5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("88aecb39-1320-4db7-9a53-87b4b3cdbdd3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("93d52e4a-93dc-4981-a3d5-347eb731f51e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9416cbd9-f53d-45dc-9662-83c44dc0ae1f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9b9954d5-8667-4b76-96db-d0cb1bd4ae5c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9da8897b-4fa0-4428-b4fb-396f1115925d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a222ffd7-0bbd-4033-a785-17c283fb66a0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b0af5f2a-1f8d-414d-914e-72d740efc594"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("baeac038-67ac-4615-bda5-2d8eaf361c75"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bfb8497d-4a58-4886-84c7-7d2d03d6ee24"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d0ddc133-17b2-4121-b3ac-5f53ebc6b86a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d18c8ae5-23db-4a22-9a28-0c9a1a33fa02"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d3c28add-dd4e-40d2-9efd-762546129364"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ddd6d783-ba62-45b4-9d3d-ca14a30b94a8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dec16c40-5c65-4ed9-a20f-ad7a1e79e82c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e18d59db-eeae-4913-9195-75cc748fb218"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e614d01d-e966-4396-a329-211a4dcf6a63"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ea67654e-ad53-400c-80cd-9c5e6cb69d0f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f05bd526-b0cf-4acd-9dbe-8f160feb87bf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f29b9ef1-9f24-49c6-ac1c-55fb4c932c1e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fb0f0cdc-a1cb-4991-a586-4b6b618cb771"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"),
                column: "Order",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"),
                column: "Order",
                value: 2);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IconName", "Name", "Order", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), null, "", "Pojęcia", 1, new Guid("28aec609-f96e-4ae6-8db2-358a1892502e") },
                    { new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), null, "", "Wszystko", 1, new Guid("4ec57b9a-8753-4ec0-bebe-d4d361c9ecf2") }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("08375e38-7720-45b9-a25f-fc6abca4c77a"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5589), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest SOLID? Opisz wszystkie zasady. Podaj przykłady." },
                    { new Guid("0f53c057-4516-4c49-bc9b-a305e0350911"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Adapter" },
                    { new Guid("11804de2-228a-4eba-8ac0-1e85ae1a1c09"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz mechanizmy synchronizacji wątków i z jakich korzystałeś ?" },
                    { new Guid("12cb1524-d170-4af7-9df4-eb9127da7c93"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5759), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest klasa BackgroundWorker ?" },
                    { new Guid("1707dd59-11e2-4775-a0b4-7053ecf91072"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła YAGNI ?" },
                    { new Guid("1a785719-9a00-4198-9a2b-3356e3dc8a5e"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5626), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest polimorfizm dynaczminy i statyczny ?" },
                    { new Guid("1c969ae4-82cf-4f9f-94ee-c710b5f365b5"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w SOLID można złamać regułę L ?" },
                    { new Guid("20657193-1dd1-4f1f-b5a1-2e6febb86ee7"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5574), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Inversion i jak się ma do Dependency Injection ?" },
                    { new Guid("2626ee9e-d63a-462f-b25f-81db103b2d28"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5750), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się typ Thread od Task ?" },
                    { new Guid("2a3c3bae-e5c6-48bb-a99b-efa16d97f5bf"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Repository" },
                    { new Guid("2a4f1bc7-80a9-4e84-97ec-14958b17e1ee"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5382), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz wzorce projektowe i architektoniczne ? Z których i jak korzystałeś ? Najważniejsze wzorce z GOF Gang of Four." },
                    { new Guid("31eb41f2-6e25-4208-8a43-0f214d3c7497"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się proces od wątku ? Jak to się je z dostępem do zasobów ?" },
                    { new Guid("33a8556c-2de1-48de-b562-4b8056937959"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5585), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są plusy stosowania DI i IoC? W jaki sposób stosowanie DI / IoC wspomaga testowanie jednostkowe?" },
                    { new Guid("342dd61f-7992-4944-9464-12150762f0be"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5520), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVC" },
                    { new Guid("37357f2d-b9a0-4a94-b2bc-41918734817e"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5776), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jeśli uderzasz requestami do serwisu bankowego i on przestanie działać - jak temu zapobiec ?" },
                    { new Guid("38f38490-ad71-4deb-986d-b8a03bb1e410"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Wymień dwa wielowątkowe typy w .NET." },
                    { new Guid("4275bbb7-9c8c-4de1-8ed2-948290858dfc"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła TDA ?" },
                    { new Guid("4427cf12-f3db-4234-b48c-7958760a1470"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5537), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DAO" },
                    { new Guid("475bac8f-a6cc-4e3a-9309-583af1b46e05"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa lock ?" },
                    { new Guid("4f16b845-eaf0-42ff-b616-8413bba49a76"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła SoC ?" },
                    { new Guid("5031173c-f094-448b-9f0f-241779e2035e"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Retry" },
                    { new Guid("51c9cd8e-6e00-415a-aac3-db6c90d94e27"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Z czym związane są słowa async i await ?" },
                    { new Guid("521a793a-5f65-4fda-b8f2-d712342cacf8"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5767), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest deadlock ?" },
                    { new Guid("538aeaec-db6e-44b2-abc4-60d64db9c264"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Na czym polega wzorzec CQS i CQRS (command, action)?" },
                    { new Guid("556896eb-8fd0-44fd-8109-cc61cffd4e34"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5524), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVVM" },
                    { new Guid("5946768e-c506-4048-a53a-d9ff13e0421a"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy każdy wątek ma swój oddzielny stos ? Ile stosów mamy w aplikacji ?" },
                    { new Guid("59c01f15-8652-4191-b580-4f7120aff6cd"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5544), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DTO" },
                    { new Guid("5a57d061-150e-42fc-a6ff-b47fd54762a9"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5739), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiedy warto korzystać z async-ów ?" },
                    { new Guid("5d5fb65c-2c02-4495-a3d1-0e59b5ce4ac7"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5556), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Circuit Braker" },
                    { new Guid("5f0be25a-8c09-46c3-998d-2659c0a07d72"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5671), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jakich sytuacjach warto zastosować wielowątkowość a w jakich nie ? Z jakimi problemami wiąże się takie podejście ?" },
                    { new Guid("610578d1-8f41-49f9-b2fd-bc5a952887da"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Metoda fabryki" },
                    { new Guid("6d420c03-b0e8-408a-ad9b-dbe25f33d9c1"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5495), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Template method" },
                    { new Guid("73559766-dee2-4b72-93a2-ceb49775ee0c"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Obserwator" },
                    { new Guid("73d441e2-5f22-4378-989f-e64686ca79ba"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5662), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest wielowątkowość ?" },
                    { new Guid("76deb51e-ebde-4e80-85ae-8590e5af4202"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5552), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Unit Of Work" },
                    { new Guid("78f8fd2e-28f8-4d57-86fa-3af500e330c6"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5771), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Event Bus ? Jakie znasz rodzaje ESB ?" },
                    { new Guid("79c94cce-dcc4-4dd6-8d04-714e1ca7627d"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co musi posiadać metoda opisana słowem kluczowym async?" },
                    { new Guid("7c12d4de-36af-445d-848d-e6ad24594a06"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5446), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zaimplementuj singleton z bezpiecznym dostępem wielowątkowym (pamiętać o synchronizacji / double checking pattern / ew. SingletonHolder z bezpiecznym dostępem bez konieczności synchronizacji)." },
                    { new Guid("7dcf7706-eb3f-4ee2-a8a2-15058c8c0285"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się wywołanie synchroniczne od asynchronicznego ?" },
                    { new Guid("8334a817-5270-4134-8220-2edb4dd01322"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5455), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Fabryka abstrakcyjna" },
                    { new Guid("867d937a-7c5d-49c8-9daf-43622cf4e4b9"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5482), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Facade pattern (bardzo ważny wzorzec)" },
                    { new Guid("8e010ee2-60a1-47f9-bc9d-7f2070cb73a0"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Przedstaw ideę dziedziczenia na przykładzie z życia." },
                    { new Guid("8ff1b513-1a23-4189-a589-a190c5719505"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5491), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Strategia" },
                    { new Guid("94f0cca5-bcfb-41ed-ba81-7ec52d5928c3"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5727), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się lock od monitora ?" },
                    { new Guid("952a1158-02f5-4949-b112-996b901f6d6d"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5507), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy StringBuilder jest realizacją wzorca Builder ?" },
                    { new Guid("964f10f5-20be-4425-bf80-186e4a737f72"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5597), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła KISS ?" },
                    { new Guid("9775fb88-a995-46cc-8eb7-5de97af770b6"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5643), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zadania z wykorzystaniem polimorfizmu i dziedziczenia, gdzie określa się co wypisze metoda." },
                    { new Guid("9f170771-0558-4755-81df-d8da076c7cbb"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5511), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Mediator" },
                    { new Guid("a4676f0f-132e-4697-9e8a-180243ab54a0"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można zadeklarować Task zwracający void ? Czy jest to preferowane podejście ?" },
                    { new Guid("aa31ae3a-a657-42ab-81ad-55beb9aead6c"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5754), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są wątki foreground i background ?" },
                    { new Guid("ac12ffd0-af55-46e2-b8a4-1b86d5e18601"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym charakteryzują się klasa abstrakcyjna i metoda abstrakcyjna ?" },
                    { new Guid("adafcbb4-9174-4896-bcdd-f425872c5586"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5532), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "AOP" },
                    { new Guid("af05244f-cd5f-48b6-a383-32cf3cab3d5b"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVP" },
                    { new Guid("b359c77d-4f43-4753-8c52-8fcd7355a5a5"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5442), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Singleton (dlaczego to czasem antypatern)" },
                    { new Guid("b8aaed18-7367-4426-83a1-271ed8fabedd"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa Mutex ?" },
                    { new Guid("bd9365ae-c629-4c94-bd07-4fbb82279a6a"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5718), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa Semafor" },
                    { new Guid("bdd89903-716b-4576-8b31-32a9b71c32b6"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Proxy" },
                    { new Guid("bde67600-be64-45a3-b7a8-c7fecaaa93a9"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5602), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła DRY ?" },
                    { new Guid("c3986e4e-4404-4d4d-987b-c80a7175aef9"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest OOP ? Jakie są 4 główne zasady programowania obiektowego ?" },
                    { new Guid("c5b18eda-8644-4a68-accb-b0f17695104c"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5474), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Dekorator" },
                    { new Guid("cd1edb2c-80d5-416e-9b3f-0ba597c9c8ed"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5787), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co to znaczy, że coś jest thread safe ?" },
                    { new Guid("cddef40f-f7e2-4a60-a54c-cece5c72b84c"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5713), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działa Monitor ?" },
                    { new Guid("cdeb137b-e024-4a96-938b-c6693f6477d8"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Builder" },
                    { new Guid("d870570a-52c9-4578-a7a6-32a7801d0721"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5469), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różną się wzorce fabryki abstrakcyjnej i metody fabryki ?" },
                    { new Guid("db0b9b59-2fa9-4c9e-ab2c-b5e5bd956e25"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5580), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest IoC ? W jaki sposób jest powiązane z DI ?" },
                    { new Guid("dc73efa7-5460-48d7-a9ef-c9ec54290867"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Injection ? Jak to wygląda niskopoziomowo w C# ?" },
                    { new Guid("e714e6b4-66c2-451e-b523-b7461cde4c2d"), new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5666), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy korzystałeś z mechanizmów wielowątkowych w .NET ? Jeśli tak to z jakich ?" },
                    { new Guid("eac3e839-c0f7-41e6-ae54-b819b3a44154"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5634), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Która zasada OOP według ciebie jest najważniejsza ?" },
                    { new Guid("076807f0-67c3-41ad-8ede-84da46c2529b"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5863), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest struct ? Czy jest typem prostym czy złożonym ?" },
                    { new Guid("07d21a8f-c21f-445c-b4d7-b4677b6bd25b"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5791), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest C# ? Jakie są jego zalety i najważniejsze cechy ?" },
                    { new Guid("0d77f80e-fa5d-4b9e-a302-8577058ae51d"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5909), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest refleksja ?" },
                    { new Guid("0d80459e-730f-4628-aaff-24e98d77f7c3"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5854), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Gdzie i po co stosuje się słowo kluczowe sealed ?" },
                    { new Guid("0f8e1e55-ab44-415d-9077-31a5637ed313"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5836), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Pytanie typu, co zwróci wyrażenie `var zmienna = new Abc<x, y, z>((a, b) => a == b)` jeśli nieznane typy to object" },
                    { new Guid("0fa04a4d-5101-47bc-8136-9dbdb1d2329f"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5905), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zaimplementuj rozszerzoną wersję klasy implementującej IDisposable." },
                    { new Guid("18e31d60-e17c-4650-8c8d-8087a1bae760"), new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5647), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy różni się argument od parametru ?" },
                    { new Guid("196146e2-47f3-48dd-ac2a-e031dcd3333d"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5859), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest klasa partial i po co się ją stosuje ?" },
                    { new Guid("24bc6cc0-6113-4921-8680-fa65c6ecf892"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaki typ zwraca GetHashCode() ? Czy jest możliwe, że zwróci tę samą wartość dla dwóch różnych obiektów ?" },
                    { new Guid("2b345671-8273-4ba3-a976-4118448343ab"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5918), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy za pomocą refleksji można dodać nowy typ ?" },
                    { new Guid("447c06b0-f6e7-47f8-87de-89312c0c05b2"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5827), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica pomiędzy ref i out ?" },
                    { new Guid("4c31028c-c86c-4160-bac4-0d70394bbbeb"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się metoda Parse od TryParse ? Jak zwracane są typy i błędy ?" },
                    { new Guid("4d5fea49-10d4-4433-9b4e-60493e3be2e8"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5977), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie mamy typy zmiennych w C# ? Jak są przechowywane w pamięci ?" },
                    { new Guid("4f29e7a8-b817-4b1f-987d-bfd283fd420c"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5946), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaki jest porządek wywoływania kolejnych bloków catch ? Jak to wygląda przy wyjątkach dziedziczonych ?" },
                    { new Guid("50d0f124-4670-43d4-8c1d-545249606a48"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5876), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest boxing i unboxing ?" },
                    { new Guid("55aeba2b-1c18-4e58-bed8-3abfed97269a"), new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5654), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest deklaracja vs definicja vs inicjalizacja ?" },
                    { new Guid("56c2461b-a476-4814-b01c-51a075625e9d"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5804), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różni się pole const od static readonly ?" },
                    { new Guid("58224cc3-6734-4934-95b4-a1433e728075"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5819), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest extension i w jakim celu się stosuje ?" },
                    { new Guid("5bcaf1bd-8af8-41ce-82ce-57089447f5e2"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5937), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Opisz blok try/catch/finally ? Co kiedy jest wywoływane ?" },
                    { new Guid("666b57df-6df6-46b9-84c8-2afc8cb6af25"), new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Której generacji językiem jest C# ?" },
                    { new Guid("6aad4613-a097-4dd2-9d3e-96cdb66d651c"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5973), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Gdzie wykorzystywany jest GetHashCode ? Czy w HashMapie dodanie dwóch różnych elementów z tym samym hashCodem nadpisze je ?" },
                    { new Guid("6cad0f2b-7093-40fb-b9bf-777eec6d1618"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5913), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można wywołać metodę prywatną za pomocą refleksji ?" },
                    { new Guid("73c42d76-0d18-4d96-9e5e-79d2f60deab3"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między interfejsem a klasą abstrakcyjną ?" },
                    { new Guid("7e6791b5-f0e3-47fa-ae52-28fea1f72672"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5868), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy jeśli zmienisz struct przesyłany w parametrze metody to zmiana będzie widoczna poza tą metodą ? Jak na to wpłynąć ?" },
                    { new Guid("7f3dd83e-fa9d-4670-a82f-6df8af89868a"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest interfejs ?" },
                    { new Guid("8b73a60e-8455-44b6-bedb-902155f18ac5"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5880), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym się różni rzutowanie bezpośrednie od wykorzystania \"as\" ?" },
                    { new Guid("94187da3-810f-49a2-b84d-e9210798f588"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między typami string i String ?" },
                    { new Guid("95538482-226e-4338-a272-d1a0b751c701"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5982), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak działają operatory \"is\", nameof i typeof ?" },
                    { new Guid("98ff5175-2867-48e4-bddd-1b7c2bcaad85"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5808), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica między var a dynamic ?" },
                    { new Guid("9af5ccbe-ce44-467a-aeb2-b785778856ef"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5933), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy tworzyłeś kiedyś customowy atrybut ? Jaki?" },
                    { new Guid("9da66d41-209e-4749-96df-b69c3ee6e990"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5799), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zadanie, w którym robiony jest Replace() na stringu ale nigdzie nie jest przypisywany rezultat i co zwróci zmienna ? Łatwo się złapać." },
                    { new Guid("a1bee6f4-f254-4722-8704-689e9d85818d"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5986), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest kolejność wywoływania bloków catch w obsłudze wyjątków ? Zwrócić uwagę na dziedziczenie wyjątków." },
                    { new Guid("a4250f8f-df4b-4e5b-8ceb-e3705f3bc6d0"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5831), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Pytania o to, która definicja metody jest poprawna." },
                    { new Guid("ad9acf84-e08b-4f80-afc8-a7a32c724e09"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5872), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jaki sposób można rzutować wartości na inne typy ?" },
                    { new Guid("ae7a845f-7cb7-4594-8c31-d3ef9c35bb9a"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5941), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak wygląda multicatch ?" },
                    { new Guid("c155e2fb-2f02-407a-87ba-224ea536e808"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5901), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Gdzie w mechanizmie wywoływana jest metoda Dispose() ?" },
                    { new Guid("cf23fa15-3229-4775-b354-af57905c09c7"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5812), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest delegat ?" },
                    { new Guid("d4a30a78-21df-4ab7-8601-dc2aa5647a78"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5892), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "W jakich sytuacjach wykorzystujemy słowo kluczowe using ?" },
                    { new Guid("d5c998fb-49cb-4d3c-8531-76c01d9c3f6f"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy string jest typem wartości czy referencyjnym ?" },
                    { new Guid("df52da51-69d5-479e-be81-37b211bbbadd"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jaka jest różnica w wywołaniu \"throw e\" od \"throw\" ? Który standard jest lepszy ?" },
                    { new Guid("e3024dce-ea6d-427f-9443-d6ff4a8a9b95"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5885), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym są generyki ? Na co pozwalają ?" },
                    { new Guid("e76bf3d7-d769-4a1c-8eb0-5c023cc33934"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy za pomocą refleksji można dodać property do istniejącego typu ?" },
                    { new Guid("e91f6181-bea9-44a8-9b9a-150c5599682b"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5928), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest atrybut ?" },
                    { new Guid("f4a83eb5-91d5-4bd5-b637-8f1ebd775e71"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest klasa abstrakcyjna ?" },
                    { new Guid("f514362e-6b9b-46df-9a37-8b7a0c086f14"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest parsowanie ?" },
                    { new Guid("f602f466-836a-4a5b-a6a8-facddf6633f0"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5823), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można wywoływać extension method na obiektach null ?" },
                    { new Guid("f92f7ba9-92e5-43e8-a7c6-a274a98f377d"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5896), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy można zastąpić IDisposable poprzez try/catch/finally ? Dlaczego się z tego w takim razie korzysta?" },
                    { new Guid("fa467c45-fdfc-43ad-b2a4-b3290cde5b73"), new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 20, 56, 21, 443, DateTimeKind.Unspecified).AddTicks(5950), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Co jeśli w bloku finally pojawi się wyjątek ?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("076807f0-67c3-41ad-8ede-84da46c2529b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("07d21a8f-c21f-445c-b4d7-b4677b6bd25b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("08375e38-7720-45b9-a25f-fc6abca4c77a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0d77f80e-fa5d-4b9e-a302-8577058ae51d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0d80459e-730f-4628-aaff-24e98d77f7c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0f53c057-4516-4c49-bc9b-a305e0350911"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0f8e1e55-ab44-415d-9077-31a5637ed313"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0fa04a4d-5101-47bc-8136-9dbdb1d2329f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("11804de2-228a-4eba-8ac0-1e85ae1a1c09"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("12cb1524-d170-4af7-9df4-eb9127da7c93"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1707dd59-11e2-4775-a0b4-7053ecf91072"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("18e31d60-e17c-4650-8c8d-8087a1bae760"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("196146e2-47f3-48dd-ac2a-e031dcd3333d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1a785719-9a00-4198-9a2b-3356e3dc8a5e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1c969ae4-82cf-4f9f-94ee-c710b5f365b5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("20657193-1dd1-4f1f-b5a1-2e6febb86ee7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("24bc6cc0-6113-4921-8680-fa65c6ecf892"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2626ee9e-d63a-462f-b25f-81db103b2d28"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2a3c3bae-e5c6-48bb-a99b-efa16d97f5bf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2a4f1bc7-80a9-4e84-97ec-14958b17e1ee"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2b345671-8273-4ba3-a976-4118448343ab"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("31eb41f2-6e25-4208-8a43-0f214d3c7497"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("33a8556c-2de1-48de-b562-4b8056937959"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("342dd61f-7992-4944-9464-12150762f0be"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("37357f2d-b9a0-4a94-b2bc-41918734817e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("38f38490-ad71-4deb-986d-b8a03bb1e410"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4275bbb7-9c8c-4de1-8ed2-948290858dfc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4427cf12-f3db-4234-b48c-7958760a1470"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("447c06b0-f6e7-47f8-87de-89312c0c05b2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("475bac8f-a6cc-4e3a-9309-583af1b46e05"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4c31028c-c86c-4160-bac4-0d70394bbbeb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4d5fea49-10d4-4433-9b4e-60493e3be2e8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4f16b845-eaf0-42ff-b616-8413bba49a76"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4f29e7a8-b817-4b1f-987d-bfd283fd420c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5031173c-f094-448b-9f0f-241779e2035e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("50d0f124-4670-43d4-8c1d-545249606a48"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("51c9cd8e-6e00-415a-aac3-db6c90d94e27"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("521a793a-5f65-4fda-b8f2-d712342cacf8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("538aeaec-db6e-44b2-abc4-60d64db9c264"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("556896eb-8fd0-44fd-8109-cc61cffd4e34"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("55aeba2b-1c18-4e58-bed8-3abfed97269a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("56c2461b-a476-4814-b01c-51a075625e9d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("58224cc3-6734-4934-95b4-a1433e728075"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5946768e-c506-4048-a53a-d9ff13e0421a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("59c01f15-8652-4191-b580-4f7120aff6cd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5a57d061-150e-42fc-a6ff-b47fd54762a9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5bcaf1bd-8af8-41ce-82ce-57089447f5e2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5d5fb65c-2c02-4495-a3d1-0e59b5ce4ac7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5f0be25a-8c09-46c3-998d-2659c0a07d72"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("610578d1-8f41-49f9-b2fd-bc5a952887da"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("666b57df-6df6-46b9-84c8-2afc8cb6af25"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6aad4613-a097-4dd2-9d3e-96cdb66d651c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6cad0f2b-7093-40fb-b9bf-777eec6d1618"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d420c03-b0e8-408a-ad9b-dbe25f33d9c1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("73559766-dee2-4b72-93a2-ceb49775ee0c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("73c42d76-0d18-4d96-9e5e-79d2f60deab3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("73d441e2-5f22-4378-989f-e64686ca79ba"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("76deb51e-ebde-4e80-85ae-8590e5af4202"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("78f8fd2e-28f8-4d57-86fa-3af500e330c6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("79c94cce-dcc4-4dd6-8d04-714e1ca7627d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7c12d4de-36af-445d-848d-e6ad24594a06"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7dcf7706-eb3f-4ee2-a8a2-15058c8c0285"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7e6791b5-f0e3-47fa-ae52-28fea1f72672"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7f3dd83e-fa9d-4670-a82f-6df8af89868a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8334a817-5270-4134-8220-2edb4dd01322"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("867d937a-7c5d-49c8-9daf-43622cf4e4b9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8b73a60e-8455-44b6-bedb-902155f18ac5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8e010ee2-60a1-47f9-bc9d-7f2070cb73a0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8ff1b513-1a23-4189-a589-a190c5719505"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("94187da3-810f-49a2-b84d-e9210798f588"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("94f0cca5-bcfb-41ed-ba81-7ec52d5928c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("952a1158-02f5-4949-b112-996b901f6d6d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("95538482-226e-4338-a272-d1a0b751c701"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("964f10f5-20be-4425-bf80-186e4a737f72"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9775fb88-a995-46cc-8eb7-5de97af770b6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("98ff5175-2867-48e4-bddd-1b7c2bcaad85"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9af5ccbe-ce44-467a-aeb2-b785778856ef"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9da66d41-209e-4749-96df-b69c3ee6e990"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9f170771-0558-4755-81df-d8da076c7cbb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a1bee6f4-f254-4722-8704-689e9d85818d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a4250f8f-df4b-4e5b-8ceb-e3705f3bc6d0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a4676f0f-132e-4697-9e8a-180243ab54a0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aa31ae3a-a657-42ab-81ad-55beb9aead6c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ac12ffd0-af55-46e2-b8a4-1b86d5e18601"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ad9acf84-e08b-4f80-afc8-a7a32c724e09"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("adafcbb4-9174-4896-bcdd-f425872c5586"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ae7a845f-7cb7-4594-8c31-d3ef9c35bb9a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("af05244f-cd5f-48b6-a383-32cf3cab3d5b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b359c77d-4f43-4753-8c52-8fcd7355a5a5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b8aaed18-7367-4426-83a1-271ed8fabedd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bd9365ae-c629-4c94-bd07-4fbb82279a6a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bdd89903-716b-4576-8b31-32a9b71c32b6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bde67600-be64-45a3-b7a8-c7fecaaa93a9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c155e2fb-2f02-407a-87ba-224ea536e808"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c3986e4e-4404-4d4d-987b-c80a7175aef9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c5b18eda-8644-4a68-accb-b0f17695104c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cd1edb2c-80d5-416e-9b3f-0ba597c9c8ed"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cddef40f-f7e2-4a60-a54c-cece5c72b84c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cdeb137b-e024-4a96-938b-c6693f6477d8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cf23fa15-3229-4775-b354-af57905c09c7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d4a30a78-21df-4ab7-8601-dc2aa5647a78"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d5c998fb-49cb-4d3c-8531-76c01d9c3f6f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d870570a-52c9-4578-a7a6-32a7801d0721"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("db0b9b59-2fa9-4c9e-ab2c-b5e5bd956e25"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dc73efa7-5460-48d7-a9ef-c9ec54290867"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("df52da51-69d5-479e-be81-37b211bbbadd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e3024dce-ea6d-427f-9443-d6ff4a8a9b95"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e714e6b4-66c2-451e-b523-b7461cde4c2d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e76bf3d7-d769-4a1c-8eb0-5c023cc33934"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e91f6181-bea9-44a8-9b9a-150c5599682b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("eac3e839-c0f7-41e6-ae54-b819b3a44154"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f4a83eb5-91d5-4bd5-b637-8f1ebd775e71"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f514362e-6b9b-46df-9a37-8b7a0c086f14"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f602f466-836a-4a5b-a6a8-facddf6633f0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f92f7ba9-92e5-43e8-a7c6-a274a98f377d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fa467c45-fdfc-43ad-b2a4-b3290cde5b73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0faca7b4-e59d-483b-82a9-785d960c5760"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f18dc0d-4ec4-4cc2-aba9-1af04b6fcf4b"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"),
                column: "Order",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"),
                column: "Order",
                value: 1);

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("0a4239b6-6467-48f6-a16d-8f2353196690"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1093), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Metoda fabryki" },
                    { new Guid("0c379c20-3789-4618-8651-8e41ec37f64e"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1266), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła DRY ?" },
                    { new Guid("17a28823-4372-4dee-a830-91607d11c491"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1293), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym charakteryzują się klasa abstrakcyjna i metoda abstrakcyjna ?" },
                    { new Guid("1dc192f8-64a8-43b4-b286-d0b52924690e"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1143), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Mediator" },
                    { new Guid("1f4b0d13-3cbd-4907-8020-1864320afe19"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym różną się wzorce fabryki abstrakcyjnej i metody fabryki ?" },
                    { new Guid("21459d3d-768e-41ea-9a18-462b486c4baf"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1280), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła TDA ?" },
                    { new Guid("23acaa15-fc2e-4144-ac89-036403de0384"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1276), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła SoC ?" },
                    { new Guid("244d496d-d561-4ef0-82c5-d9dc4e2d2889"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1261), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła KISS ?" },
                    { new Guid("3538dab7-0c18-41a8-9884-06b6965cb221"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1139), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czy StringBuilder jest realizacją wzorca Builder ?" },
                    { new Guid("392a8313-460e-4639-a2e6-becdce25a34b"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1079), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zaimplementuj singleton z bezpiecznym dostępem wielowątkowym (pamiętać o synchronizacji / double checking pattern / ew. SingletonHolder z bezpiecznym dostępem bez konieczności synchronizacji)." },
                    { new Guid("3b2d90a4-6f68-4c8c-b38e-15e109c91f08"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1180), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Repository" },
                    { new Guid("3b57ff38-a9fb-4f51-85e7-5e208f559f68"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1193), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Retry" },
                    { new Guid("3eb8a463-4efa-40aa-b286-806b751c7b44"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1111), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Obserwator" },
                    { new Guid("4a1b4855-1de0-4d1a-a053-d0fb534a7851"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1289), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest polimorfizm dynaczminy i statyczny ?" },
                    { new Guid("4b99cbd8-5072-4ad5-b533-3ecf5bff86f6"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1221), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest SOLID? Opisz wszystkie zasady. Podaj przykłady." },
                    { new Guid("4c0294b2-2682-4c61-88a1-8ffd84306c5f"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1074), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Singleton (dlaczego to czasem antypatern)" },
                    { new Guid("4e804a39-acb6-484d-86b7-79b64d7bbed5"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1131), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Template method" },
                    { new Guid("4fa32e95-59a6-481b-a9e3-151e3298903b"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Na czym polega wzorzec CQS i CQRS (command, action)?" },
                    { new Guid("516a731d-1ffa-497d-a183-78bf70a7a062"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVC" },
                    { new Guid("58ee2bca-9e8d-4361-83ef-1b8d7aad951c"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1308), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Zadania z wykorzystaniem polimorfizmu i dziedziczenia, gdzie określa się co wypisze metoda." },
                    { new Guid("5b7fc34e-6700-478a-b4b9-c0b942affcdd"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1217), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie są plusy stosowania DI i IoC? W jaki sposób stosowanie DI / IoC wspomaga testowanie jednostkowe?" },
                    { new Guid("610b2710-28f6-4e14-a35a-ae5fb3b1f971"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Proxy" },
                    { new Guid("7590eea1-95a6-4d9c-b6c0-704c6e9a9f07"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1167), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "AOP" },
                    { new Guid("764bc69e-c33a-4b3f-8b3f-53f3029bfae5"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1285), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest OOP ? Jakie są 4 główne zasady programowania obiektowego ?" },
                    { new Guid("88aecb39-1320-4db7-9a53-87b4b3cdbdd3"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Strategia" },
                    { new Guid("93d52e4a-93dc-4981-a3d5-347eb731f51e"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1015), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jakie znasz wzorce projektowe i architektoniczne ? Z których i jak korzystałeś ? Najważniejsze wzorce z GOF Gang of Four." },
                    { new Guid("9416cbd9-f53d-45dc-9662-83c44dc0ae1f"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1156), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVVM" },
                    { new Guid("9b9954d5-8667-4b76-96db-d0cb1bd4ae5c"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1176), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DTO" },
                    { new Guid("9da8897b-4fa0-4428-b4fb-396f1115925d"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1160), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "MVP" },
                    { new Guid("a222ffd7-0bbd-4033-a785-17c283fb66a0"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1098), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Fabryka abstrakcyjna" },
                    { new Guid("b0af5f2a-1f8d-414d-914e-72d740efc594"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1302), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Przedstaw ideę dziedziczenia na przykładzie z życia." },
                    { new Guid("baeac038-67ac-4615-bda5-2d8eaf361c75"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1225), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jak w SOLID można złamać regułę L ?" },
                    { new Guid("bfb8497d-4a58-4886-84c7-7d2d03d6ee24"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1188), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Circuit Braker" },
                    { new Guid("d0ddc133-17b2-4121-b3ac-5f53ebc6b86a"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1116), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Facade pattern (bardzo ważny wzorzec)" },
                    { new Guid("d18c8ae5-23db-4a22-9a28-0c9a1a33fa02"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1120), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Adapter" },
                    { new Guid("d3c28add-dd4e-40d2-9efd-762546129364"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1272), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest reguła YAGNI ?" },
                    { new Guid("ddd6d783-ba62-45b4-9d3d-ca14a30b94a8"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1212), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest IoC ? W jaki sposób jest powiązane z DI ?" },
                    { new Guid("dec16c40-5c65-4ed9-a20f-ad7a1e79e82c"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Dekorator" },
                    { new Guid("e18d59db-eeae-4913-9195-75cc748fb218"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1208), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Inversion i jak się ma do Dependency Injection ?" },
                    { new Guid("e614d01d-e966-4396-a329-211a4dcf6a63"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1184), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Unit Of Work" },
                    { new Guid("ea67654e-ad53-400c-80cd-9c5e6cb69d0f"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1171), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "DAO" },
                    { new Guid("f05bd526-b0cf-4acd-9dbe-8f160feb87bf"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1135), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Builder" },
                    { new Guid("f29b9ef1-9f24-49c6-ac1c-55fb4c932c1e"), new Guid("71c8a70b-0e81-4b79-a7f8-fb51fcbef984"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1297), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Która zasada OOP według ciebie jest najważniejsza ?" },
                    { new Guid("fb0f0cdc-a1cb-4991-a586-4b6b618cb771"), new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(2024, 1, 22, 11, 48, 38, 47, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 1, 0, 0, 0)), null, new Guid("00000000-0000-0000-0000-000000000000"), "Czym jest Dependency Injection ? Jak to wygląda niskopoziomowo w C# ?" }
                });
        }
    }
}
