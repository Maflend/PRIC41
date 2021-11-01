﻿// <auto-generated />
using System;
using FurnitureSalesCompanyProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FurnitureSalesCompanyProject.Migrations
{
    [DbContext(typeof(FurnitureContext))]
    [Migration("20211022151736_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Contract", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfExecution")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Number");

                    b.HasIndex("CustomerLogin");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Specifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Furnitures");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Category", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractNumber")
                        .HasColumnType("int");

                    b.Property<int>("FurnitureId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContractNumber");

                    b.HasIndex("FurnitureId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.User", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Login");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Customer", b =>
                {
                    b.HasBaseType("FurnitureSalesCompanyProject.Models.User");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasFilter("[Code] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Stuff", b =>
                {
                    b.HasBaseType("FurnitureSalesCompanyProject.Models.User");

                    b.HasDiscriminator().HasValue("Stuff");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Contract", b =>
                {
                    b.HasOne("FurnitureSalesCompanyProject.Models.Customer", "Customer")
                        .WithMany("Contracts")
                        .HasForeignKey("CustomerLogin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Furniture", b =>
                {
                    b.HasOne("FurnitureSalesCompanyProject.Models.Category", "Category")
                        .WithMany("Furnituries")
                        .HasForeignKey("Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Sale", b =>
                {
                    b.HasOne("FurnitureSalesCompanyProject.Models.Contract", "Contract")
                        .WithMany("Sales")
                        .HasForeignKey("ContractNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FurnitureSalesCompanyProject.Models.Furniture", "Furniture")
                        .WithMany("Sales")
                        .HasForeignKey("FurnitureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("Furniture");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Contract", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Furniture", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Category", b =>
                {
                    b.Navigation("Furnituries");
                });

            modelBuilder.Entity("FurnitureSalesCompanyProject.Models.Customer", b =>
                {
                    b.Navigation("Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}
