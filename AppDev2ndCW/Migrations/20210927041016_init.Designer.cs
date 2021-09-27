﻿// <auto-generated />
using System;
using AppDev2ndCW.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppDev2ndCW.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210927041016_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppDev2ndCW.Models.BookAuthor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.BookCategories", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.BookInventory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Author_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Book_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Category_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("Sales_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Stock_Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Stocked_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Author_Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("BookInventory");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.Customers", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Customer_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Last_Purchased_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Member_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.SaleItems", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Book_Id")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<long>("Sale_Id")
                        .HasColumnType("bigint");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Book_Id");

                    b.HasIndex("Sale_Id");

                    b.ToTable("SaleItems");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.Sales", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Customer_Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Sale_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sale_Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Customer_Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contacts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.BookInventory", b =>
                {
                    b.HasOne("AppDev2ndCW.Models.BookAuthor", "BookAuthor")
                        .WithMany()
                        .HasForeignKey("Author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDev2ndCW.Models.BookCategories", "BookCategories")
                        .WithMany()
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookAuthor");

                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.SaleItems", b =>
                {
                    b.HasOne("AppDev2ndCW.Models.BookInventory", "BookInventory")
                        .WithMany("SaleItems")
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppDev2ndCW.Models.Sales", "Sales")
                        .WithMany("SaleItems")
                        .HasForeignKey("Sale_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookInventory");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.Sales", b =>
                {
                    b.HasOne("AppDev2ndCW.Models.Customers", "Customers")
                        .WithMany("Sales")
                        .HasForeignKey("Customer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.BookInventory", b =>
                {
                    b.Navigation("SaleItems");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.Customers", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("AppDev2ndCW.Models.Sales", b =>
                {
                    b.Navigation("SaleItems");
                });
#pragma warning restore 612, 618
        }
    }
}
