﻿// <auto-generated />
using System;
using Deskbug.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Deskbug.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221114202540_ProjectTableUpdates")]
    partial class ProjectTableUpdates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Deskbug.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryLevel")
                        .HasColumnType("int")
                        .HasColumnName("category_level");

                    b.Property<int>("CategoryReference")
                        .HasColumnType("int")
                        .HasColumnName("category_reference");

                    b.Property<int>("CategoryStatus")
                        .HasColumnType("int")
                        .HasColumnName("category_status");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime")
                        .HasColumnName("created_date");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int")
                        .HasColumnName("display_order");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("Deskbug.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime")
                        .HasColumnName("created_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("name");

                    b.Property<string>("ProjectColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)")
                        .HasColumnName("project_color");

                    b.Property<int>("ProjectStatus")
                        .HasColumnType("int")
                        .HasColumnName("project_status");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("short_name");

                    b.HasKey("Id");

                    b.ToTable("project", (string)null);
                });

            modelBuilder.Entity("Deskbug.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("full_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("password");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("token");

                    b.Property<DateTime>("TokenDate")
                        .HasColumnType("DateTime")
                        .HasColumnName("token_date");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("user_name");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int")
                        .HasColumnName("user_status");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
