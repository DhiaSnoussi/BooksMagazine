﻿// <auto-generated />
using System;
using BooksMagazine.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BooksMagazine.Migrations
{
    [DbContext(typeof(BooksMagazineContext))]
    [Migration("20200722121657_update_Mession_1")]
    partial class update_Mession_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BooksMagazine.Models.AboutModels.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUsId")
                        .HasColumnType("int");

                    b.Property<int?>("MessionsId")
                        .HasColumnType("int");

                    b.Property<int?>("VisionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AboutUsId");

                    b.HasIndex("MessionsId");

                    b.HasIndex("VisionId");

                    b.ToTable("About");
                });

            modelBuilder.Entity("BooksMagazine.Models.AboutModels.AboutUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutUs");
                });

            modelBuilder.Entity("BooksMagazine.Models.AboutModels.Messions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Messions");
                });

            modelBuilder.Entity("BooksMagazine.Models.AboutModels.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("FacebookLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoogleLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedInLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwitterLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Worker");
                });

            modelBuilder.Entity("BooksMagazine.Models.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AboutUsId")
                        .HasColumnType("int");

                    b.Property<string>("Paragraph")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutUsId");

                    b.ToTable("Description");
                });

            modelBuilder.Entity("BooksMagazine.Models.HomeModels.CarouselItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HomeId")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.ToTable("CarouselItem");
                });

            modelBuilder.Entity("BooksMagazine.Models.HomeModels.Home", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("WelcomeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WelcomeId");

                    b.ToTable("Home");
                });

            modelBuilder.Entity("BooksMagazine.Models.HomeModels.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HomeId")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("BooksMagazine.Models.HomeModels.Welcome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoalTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Welcome");
                });

            modelBuilder.Entity("BooksMagazine.Models.Purpose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MessionsId")
                        .HasColumnType("int");

                    b.Property<int?>("WelcomeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MessionsId");

                    b.HasIndex("WelcomeId");

                    b.ToTable("Purpose");
                });

            modelBuilder.Entity("BooksMagazine.Models.AboutModels.About", b =>
                {
                    b.HasOne("BooksMagazine.Models.AboutModels.AboutUs", "AboutUs")
                        .WithMany()
                        .HasForeignKey("AboutUsId");

                    b.HasOne("BooksMagazine.Models.AboutModels.Messions", "Messions")
                        .WithMany()
                        .HasForeignKey("MessionsId");

                    b.HasOne("BooksMagazine.Models.AboutModels.Messions", "Vision")
                        .WithMany()
                        .HasForeignKey("VisionId");
                });

            modelBuilder.Entity("BooksMagazine.Models.AboutModels.Worker", b =>
                {
                    b.HasOne("BooksMagazine.Models.AboutModels.About", null)
                        .WithMany("Team")
                        .HasForeignKey("AboutId");
                });

            modelBuilder.Entity("BooksMagazine.Models.Description", b =>
                {
                    b.HasOne("BooksMagazine.Models.AboutModels.AboutUs", null)
                        .WithMany("Descriptions")
                        .HasForeignKey("AboutUsId");
                });

            modelBuilder.Entity("BooksMagazine.Models.HomeModels.CarouselItem", b =>
                {
                    b.HasOne("BooksMagazine.Models.HomeModels.Home", null)
                        .WithMany("CarouselItems")
                        .HasForeignKey("HomeId");
                });

            modelBuilder.Entity("BooksMagazine.Models.HomeModels.Home", b =>
                {
                    b.HasOne("BooksMagazine.Models.HomeModels.Welcome", "Welcome")
                        .WithMany()
                        .HasForeignKey("WelcomeId");
                });

            modelBuilder.Entity("BooksMagazine.Models.HomeModels.Topic", b =>
                {
                    b.HasOne("BooksMagazine.Models.HomeModels.Home", null)
                        .WithMany("Topics")
                        .HasForeignKey("HomeId");
                });

            modelBuilder.Entity("BooksMagazine.Models.Purpose", b =>
                {
                    b.HasOne("BooksMagazine.Models.AboutModels.Messions", null)
                        .WithMany("Purposes")
                        .HasForeignKey("MessionsId");

                    b.HasOne("BooksMagazine.Models.HomeModels.Welcome", null)
                        .WithMany("Purposes")
                        .HasForeignKey("WelcomeId");
                });
#pragma warning restore 612, 618
        }
    }
}
