﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkyApi.Data;

namespace ParkyApi.Migrations
{
    [DbContext(typeof(ParkyDbContext))]
    [Migration("20201206185842_AddedPictureToNationalPark")]
    partial class AddedPictureToNationalPark
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParkyApi.Models.Instances.NationalPark", b =>
                {
                    b.Property<int>("NationalParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Established")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalParkId");

                    b.ToTable("NationalParks");
                });

            modelBuilder.Entity("ParkyApi.Models.Instances.Trail", b =>
                {
                    b.Property<int>("TrailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Difficulity")
                        .HasColumnType("int");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalParkId")
                        .HasColumnType("int");

                    b.HasKey("TrailId");

                    b.HasIndex("NationalParkId");

                    b.ToTable("Trails");
                });

            modelBuilder.Entity("ParkyApi.Models.Instances.Trail", b =>
                {
                    b.HasOne("ParkyApi.Models.Instances.NationalPark", "NationalPark")
                        .WithMany()
                        .HasForeignKey("NationalParkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NationalPark");
                });
#pragma warning restore 612, 618
        }
    }
}
