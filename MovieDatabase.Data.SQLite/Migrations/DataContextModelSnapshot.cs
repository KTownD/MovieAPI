﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieDatabase.Data.SQLite;

#nullable disable

namespace MovieDatabase.Data.SQLite.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("MovieDatabase.Data.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Seen")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rating = 0,
                            Seen = false,
                            Title = "Shrek"
                        },
                        new
                        {
                            Id = 2,
                            Rating = 1,
                            Seen = true,
                            Title = "Inception"
                        },
                        new
                        {
                            Id = 3,
                            Rating = 2,
                            Seen = true,
                            Title = "The Green Latern"
                        },
                        new
                        {
                            Id = 4,
                            Rating = 5,
                            Seen = true,
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = 5,
                            Rating = 5,
                            Seen = true,
                            Title = "The Muppets"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
