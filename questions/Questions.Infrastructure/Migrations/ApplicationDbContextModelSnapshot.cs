﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Questions.Infrastructure.Context;

#nullable disable

namespace Questions.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Questions.Domain.Entities.CategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<string>("IconName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<Guid?>("ParentCategoryId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb1c2675-5877-4aa5-9bc6-00be8d449549"),
                            Name = "Przygotowanie na rozmowę",
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("997bb095-fb04-4872-ac35-0d05cedc3de0"),
                            Name = "Umiejętności miękkie",
                            Order = 2
                        },
                        new
                        {
                            Id = new Guid("28aec609-f96e-4ae6-8db2-358a1892502e"),
                            Name = "Architektura",
                            Order = 3
                        },
                        new
                        {
                            Id = new Guid("a16bb186-092e-440d-92c9-fe57cd96ec4f"),
                            Name = "Algorytmy",
                            Order = 4
                        },
                        new
                        {
                            Id = new Guid("e5541ffc-ed59-4f27-acb6-2b2b3da04bb2"),
                            Name = "C#",
                            Order = 5
                        },
                        new
                        {
                            Id = new Guid("4ec57b9a-8753-4ec0-bebe-d4d361c9ecf2"),
                            Name = ".Net",
                            Order = 6
                        },
                        new
                        {
                            Id = new Guid("7497e8fc-80a5-42df-ac48-c09f695dc402"),
                            Name = "Wzorce projektowe",
                            Order = 1,
                            ParentCategoryId = new Guid("28aec609-f96e-4ae6-8db2-358a1892502e")
                        },
                        new
                        {
                            Id = new Guid("0a07f758-355f-4796-8ab4-f5a34cfca181"),
                            Name = "Wielowątkowość",
                            Order = 1,
                            ParentCategoryId = new Guid("a16bb186-092e-440d-92c9-fe57cd96ec4f")
                        });
                });

            modelBuilder.Entity("Questions.Domain.Entities.QuestionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

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

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Questions", (string)null);
                });

            modelBuilder.Entity("Questions.Domain.Entities.CategoryEntity", b =>
                {
                    b.HasOne("Questions.Domain.Entities.CategoryEntity", null)
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentCategoryId");
                });

            modelBuilder.Entity("Questions.Domain.Entities.QuestionEntity", b =>
                {
                    b.HasOne("Questions.Domain.Entities.CategoryEntity", null)
                        .WithMany("Questions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Questions.Domain.Entities.CategoryEntity", b =>
                {
                    b.Navigation("ChildCategories");

                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
