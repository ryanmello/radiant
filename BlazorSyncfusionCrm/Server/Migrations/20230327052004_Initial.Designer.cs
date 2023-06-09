﻿// <auto-generated />
using System;
using BlazorSyncfusionCrm.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorSyncfusionCrm.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230327052004_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorSyncfusionCrm.Shared.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4779),
                            DateOfBirth = new DateTime(2001, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Peter",
                            LastName = "Parker",
                            NickName = "Spider-Man",
                            Place = "New York City",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4820),
                            DateOfBirth = new DateTime(2001, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bruce",
                            LastName = "Wayne",
                            NickName = "Batman",
                            Place = "Gotham City",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4823),
                            DateOfBirth = new DateTime(2001, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Tony",
                            LastName = "Stark",
                            NickName = "Ironman",
                            Place = "Malibu",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("BlazorSyncfusionCrm.Shared.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactId = 1,
                            DateCreated = new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4947),
                            Text = "With great power comes great responsibility"
                        },
                        new
                        {
                            Id = 3,
                            ContactId = 3,
                            DateCreated = new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4951),
                            Text = "I'm Batman!"
                        },
                        new
                        {
                            Id = 2,
                            ContactId = 2,
                            DateCreated = new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4953),
                            Text = "I am Iron Man"
                        });
                });

            modelBuilder.Entity("BlazorSyncfusionCrm.Shared.Note", b =>
                {
                    b.HasOne("BlazorSyncfusionCrm.Shared.Contact", "Contact")
                        .WithMany("Notes")
                        .HasForeignKey("ContactId");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("BlazorSyncfusionCrm.Shared.Contact", b =>
                {
                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
