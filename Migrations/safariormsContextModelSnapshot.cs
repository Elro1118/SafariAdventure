﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SafariAdventure;

namespace SafariAdventure.Migrations
{
    [DbContext(typeof(safariormsContext))]
    partial class safariormsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SafariAdventure.SeenAnimals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountOfTimesSeen");

                    b.Property<DateTime>("LastSeenTime");

                    b.Property<string>("LocationOfLastSeen");

                    b.Property<string>("Species");

                    b.HasKey("Id");

                    b.ToTable("SeenAnimals");
                });
#pragma warning restore 612, 618
        }
    }
}
