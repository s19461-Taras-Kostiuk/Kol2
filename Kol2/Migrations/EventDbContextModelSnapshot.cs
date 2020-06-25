﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Kol2.Models;

namespace Kol2.Migrations
{
    [DbContext(typeof(EventDbContext))]
    partial class EventDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrzykladKolokwium2.Models.Artist", b =>
                {
                    b.Property<int>("IdArtist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("IdArtist");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            IdArtist = 1,
                            Nickname = "AAA"
                        },
                        new
                        {
                            IdArtist = 2,
                            Nickname = "BBB"
                        },
                        new
                        {
                            IdArtist = 3,
                            Nickname = "CCC"
                        });
                });

            modelBuilder.Entity("PrzykladKolokwium2.Models.Artist_Event", b =>
                {
                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.Property<int>("IdArtist")
                        .HasColumnType("int");

                    b.Property<DateTime>("PerfomanceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdEvent", "IdArtist");

                    b.HasIndex("IdArtist");

                    b.ToTable("Artist_Events");

                    b.HasData(
                        new
                        {
                            IdEvent = 1,
                            IdArtist = 1,
                            PerfomanceDate = new DateTime(2004, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdEvent = 2,
                            IdArtist = 2,
                            PerfomanceDate = new DateTime(2005, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdEvent = 3,
                            IdArtist = 3,
                            PerfomanceDate = new DateTime(2006, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PrzykladKolokwium2.Models.Event", b =>
                {
                    b.Property<int>("IdEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdEvent");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            IdEvent = 1,
                            EndDate = new DateTime(2004, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "koncert 1",
                            StartDate = new DateTime(2004, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdEvent = 2,
                            EndDate = new DateTime(2005, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "koncert 2",
                            StartDate = new DateTime(2005, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdEvent = 3,
                            EndDate = new DateTime(2006, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "koncert 3",
                            StartDate = new DateTime(2006, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PrzykladKolokwium2.Models.Event_Organiser", b =>
                {
                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.Property<int>("IdOrganiser")
                        .HasColumnType("int");

                    b.HasKey("IdEvent", "IdOrganiser");

                    b.HasIndex("IdOrganiser");

                    b.ToTable("Event_Organisers");

                    b.HasData(
                        new
                        {
                            IdEvent = 1,
                            IdOrganiser = 1
                        },
                        new
                        {
                            IdEvent = 2,
                            IdOrganiser = 2
                        },
                        new
                        {
                            IdEvent = 2,
                            IdOrganiser = 3
                        });
                });

            modelBuilder.Entity("PrzykladKolokwium2.Models.Organiser", b =>
                {
                    b.Property<int>("IdOrganiser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("IdOrganiser");

                    b.ToTable("Organisers");

                    b.HasData(
                        new
                        {
                            IdOrganiser = 1,
                            Name = "WAW"
                        },
                        new
                        {
                            IdOrganiser = 2,
                            Name = "LON"
                        },
                        new
                        {
                            IdOrganiser = 3,
                            Name = "BRU"
                        });
                });

            modelBuilder.Entity("PrzykladKolokwium2.Models.Artist_Event", b =>
                {
                    b.HasOne("PrzykladKolokwium2.Models.Artist", "Artist")
                        .WithMany("ArtistEvent")
                        .HasForeignKey("IdArtist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrzykladKolokwium2.Models.Event", "Event")
                        .WithMany("ArtistEvent")
                        .HasForeignKey("IdEvent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrzykladKolokwium2.Models.Event_Organiser", b =>
                {
                    b.HasOne("PrzykladKolokwium2.Models.Event", "Event")
                        .WithMany("EventOrganiser")
                        .HasForeignKey("IdEvent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrzykladKolokwium2.Models.Organiser", "Organiser")
                        .WithMany("EventOrganiser")
                        .HasForeignKey("IdOrganiser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
