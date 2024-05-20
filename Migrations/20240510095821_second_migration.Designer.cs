﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WheelsBlazor.Data;

#nullable disable

namespace WheelsBlazor.Migrations
{
    [DbContext(typeof(WheelsContext))]
    [Migration("20240510095821_second_migration")]
    partial class second_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.18");

            modelBuilder.Entity("Wheels.Models.WheelsTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrandType")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("WheelsTable");
                });

            modelBuilder.Entity("WheelsBlazor.Data.Alutec", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BoltCircle")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<float>("Diameter")
                        .HasColumnType("REAL");

                    b.Property<float>("Offset")
                        .HasColumnType("REAL");

                    b.Property<int>("WheelsTableID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WheelsTableID");

                    b.ToTable("Alutec");
                });

            modelBuilder.Entity("WheelsBlazor.Data.Anzio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BoltCircle")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<float>("Diameter")
                        .HasColumnType("REAL");

                    b.Property<float>("Offset")
                        .HasColumnType("REAL");

                    b.Property<int>("WheelsTableID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WheelsTableID");

                    b.ToTable("Anzio");
                });

            modelBuilder.Entity("WheelsBlazor.Data.Ats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BoltCircle")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<float>("Diameter")
                        .HasColumnType("REAL");

                    b.Property<float>("Offset")
                        .HasColumnType("REAL");

                    b.Property<int>("WheelsTableID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WheelsTableID");

                    b.ToTable("Ats");
                });

            modelBuilder.Entity("WheelsBlazor.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Avatar")
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("WheelsBlazor.Data.Rial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BoltCircle")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<float>("Diameter")
                        .HasColumnType("REAL");

                    b.Property<float>("Offset")
                        .HasColumnType("REAL");

                    b.Property<int>("WheelsTableID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WheelsTableID");

                    b.ToTable("Rial");
                });

            modelBuilder.Entity("WheelsBlazor.Data.Alutec", b =>
                {
                    b.HasOne("Wheels.Models.WheelsTable", "WheelsTable")
                        .WithMany()
                        .HasForeignKey("WheelsTableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WheelsTable");
                });

            modelBuilder.Entity("WheelsBlazor.Data.Anzio", b =>
                {
                    b.HasOne("Wheels.Models.WheelsTable", "WheelsTable")
                        .WithMany()
                        .HasForeignKey("WheelsTableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WheelsTable");
                });

            modelBuilder.Entity("WheelsBlazor.Data.Ats", b =>
                {
                    b.HasOne("Wheels.Models.WheelsTable", "WheelsTable")
                        .WithMany()
                        .HasForeignKey("WheelsTableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WheelsTable");
                });

            modelBuilder.Entity("WheelsBlazor.Data.Rial", b =>
                {
                    b.HasOne("Wheels.Models.WheelsTable", "WheelsTable")
                        .WithMany()
                        .HasForeignKey("WheelsTableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WheelsTable");
                });
#pragma warning restore 612, 618
        }
    }
}
