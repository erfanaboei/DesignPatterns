﻿// <auto-generated />
using System;
using DesignPatterns.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesignPatterns.Migrations
{
    [DbContext(typeof(DesignPatternContext))]
    [Migration("20240320141615_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Composite_Application.Models.CategoryComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryComponents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CategoryComponent");
                });

            modelBuilder.Entity("Composite_Application.Models.Category", b =>
                {
                    b.HasBaseType("Composite_Application.Models.CategoryComponent");

                    b.HasDiscriminator().HasValue("Category");
                });

            modelBuilder.Entity("Composite_Application.Models.CategoryItem", b =>
                {
                    b.HasBaseType("Composite_Application.Models.CategoryComponent");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("CategoryItem");
                });

            modelBuilder.Entity("Composite_Application.Models.CategoryComponent", b =>
                {
                    b.HasOne("Composite_Application.Models.Category", null)
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Composite_Application.Models.Category", b =>
                {
                    b.Navigation("MenuItems");
                });
#pragma warning restore 612, 618
        }
    }
}