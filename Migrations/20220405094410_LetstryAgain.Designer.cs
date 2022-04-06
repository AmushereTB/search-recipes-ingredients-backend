﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LastProject.API.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20220405094410_LetstryAgain")]
    partial class LetstryAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Recipe", b =>
                {
                    b.Property<string>("idMeal")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GoogleId")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UserGoogleId")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("strMeal")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("strMealThumb")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("idMeal");

                    b.HasIndex("UserGoogleId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<string>("GoogleId")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("GoogleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Recipe", b =>
                {
                    b.HasOne("User", null)
                        .WithMany("Recipes")
                        .HasForeignKey("UserGoogleId");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
