﻿// <auto-generated />
using System;
using MVC_1stAshish.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_1stAshish.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220221092230_m2")]
    partial class m2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_1stAshish.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LOCATIONID")
                        .HasColumnType("int");

                    b.Property<string>("MOBILE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LOCATIONID");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("MVC_1stAshish.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DETAILS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLACE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("location");
                });

            modelBuilder.Entity("MVC_1stAshish.Models.Customer", b =>
                {
                    b.HasOne("MVC_1stAshish.Models.Location", "LOCATION")
                        .WithMany()
                        .HasForeignKey("LOCATIONID");

                    b.Navigation("LOCATION");
                });
#pragma warning restore 612, 618
        }
    }
}
