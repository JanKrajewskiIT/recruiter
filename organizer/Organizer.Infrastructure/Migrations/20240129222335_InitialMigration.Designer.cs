﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Organizer.Domain.Enums;
using Organizer.Infrastructure.Context;

#nullable disable

namespace Organizer.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240129222335_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "dictionary_key", new[] { "cities", "positions", "reasons" });
            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "offer_status", new[] { "new", "considered", "sent", "rejected" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Organizer.Domain.Entities.KeyValueListEntity", b =>
                {
                    b.Property<DictionaryKey>("Key")
                        .HasColumnType("dictionary_key");

                    b.Property<string[]>("Values")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("Key");

                    b.ToTable("KeyValueLists", (string)null);

                    b.HasData(
                        new
                        {
                            Key = DictionaryKey.Positions,
                            Values = new[] { "Software Developer", "Frontend Developer", "Backend Developer", "Fullstack Developer", "Junior Software Developer", "Junior Frontend Developer", "Junior Backend Developer", "Junior Fullstack Developer", "Mid Software Developer", "Mid Frontend Developer", "Mid Backend Developer", "Mid Fullstack Developer", "Senior Software Developer", "Senior Frontend Developer", "Senior Backend Developer", "Senior Fullstack Developer", "Lead Software Developer", "Lead Frontend Developer", "Lead Backend Developer", "Lead Fullstack Developer", "Software Architect", "Frontend Architect", "Backend Architect", "DevOps" }
                        },
                        new
                        {
                            Key = DictionaryKey.Cities,
                            Values = new[] { "Warszawa", "Kraków", "Wrocław", "Łódź", "Poznań", "Gdańsk", "Gdynia", "Sopot", "Trójmiasto", "Szczecin", "Lublin", "Bydgoszcz", "Białystok", "Katowice", "Śląsk", "Remote", "Inne" }
                        },
                        new
                        {
                            Key = DictionaryKey.Reasons,
                            Values = new[] { "Stos technologiczny", "Stawka", "Forma współpracy UoP", "Forma współpracy B2B", "Praca zdalna", "Praca hybrydowa", "Praca z biura", "Język obcy", "Język ojczysty", "Zakres obowiązków", "Lokalizacja", "Godziny pracy", "Opieka medyczna", "Multisport", "Wyjazdy służbowe", "Integracje", "Biuro", "Inne" }
                        });
                });

            modelBuilder.Entity("Organizer.Domain.Entities.OfferEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("ModifiedOn")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string[]>("Reasons")
                        .HasColumnType("text[]");

                    b.Property<OfferStatus>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("offer_status")
                        .HasDefaultValue(OfferStatus.New);

                    b.HasKey("Id");

                    b.ToTable("Offers", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}