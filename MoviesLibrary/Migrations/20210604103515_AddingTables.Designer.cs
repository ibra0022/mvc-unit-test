﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesLibrary.Data;

namespace MoviesLibrary.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210604103515_AddingTables")]
    partial class AddingTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MoviesLibrary.Models.FavoriteMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("FavoriteMovies");
                });

            modelBuilder.Entity("MoviesLibrary.Models.FavoriteTvShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TvShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TvShowId")
                        .IsUnique();

                    b.ToTable("FavoriteTvShows");
                });

            modelBuilder.Entity("MoviesLibrary.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("Poster")
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MoviesLibrary.Models.TvShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("Poster")
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TvShows");
                });

            modelBuilder.Entity("MoviesLibrary.Models.FavoriteMovie", b =>
                {
                    b.HasOne("MoviesLibrary.Models.Movie", "Movie")
                        .WithOne("FavoriteMovie")
                        .HasForeignKey("MoviesLibrary.Models.FavoriteMovie", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviesLibrary.Models.FavoriteTvShow", b =>
                {
                    b.HasOne("MoviesLibrary.Models.TvShow", "TvShow")
                        .WithOne("FavoriteTvShow")
                        .HasForeignKey("MoviesLibrary.Models.FavoriteTvShow", "TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
