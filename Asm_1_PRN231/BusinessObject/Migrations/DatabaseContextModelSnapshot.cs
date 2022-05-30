﻿// <auto-generated />
using System;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessObject.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusinessObject.Models.Author", b =>
                {
                    b.Property<int>("Author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("BusinessObject.Models.Book", b =>
                {
                    b.Property<int>("Book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Advance")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Pub_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Publisher_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Royalty")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ytd_sales")
                        .HasColumnType("datetime2");

                    b.HasKey("Book_id");

                    b.HasIndex("Pub_id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BusinessObject.Models.BookAuthor", b =>
                {
                    b.Property<int>("Author_id")
                        .HasColumnType("int");

                    b.Property<int>("Book_id")
                        .HasColumnType("int");

                    b.Property<int?>("Author_id1")
                        .HasColumnType("int");

                    b.Property<DateTime>("Author_order")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Book_id1")
                        .HasColumnType("int");

                    b.Property<int?>("Royalty_percentage")
                        .HasColumnType("int");

                    b.HasKey("Author_id", "Book_id");

                    b.HasIndex("Author_id1");

                    b.HasIndex("Book_id1");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("BusinessObject.Models.Publisher", b =>
                {
                    b.Property<int>("Pub_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pub_id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("BusinessObject.Models.Role", b =>
                {
                    b.Property<int>("Role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role_desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Role_id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BusinessObject.Models.User", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Hire_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Last_name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Middle_name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Pub_id")
                        .HasColumnType("int");

                    b.Property<int?>("Role_id")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_id");

                    b.HasIndex("Pub_id");

                    b.HasIndex("Role_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BusinessObject.Models.Book", b =>
                {
                    b.HasOne("BusinessObject.Models.Publisher", "Pub")
                        .WithMany("Books")
                        .HasForeignKey("Pub_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pub");
                });

            modelBuilder.Entity("BusinessObject.Models.BookAuthor", b =>
                {
                    b.HasOne("BusinessObject.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Author_id1");

                    b.HasOne("BusinessObject.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Book_id1");

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BusinessObject.Models.User", b =>
                {
                    b.HasOne("BusinessObject.Models.Publisher", "Pub")
                        .WithMany("Users")
                        .HasForeignKey("Pub_id");

                    b.HasOne("BusinessObject.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("Role_id");

                    b.Navigation("Pub");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BusinessObject.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("BusinessObject.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("BusinessObject.Models.Publisher", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
