﻿// <auto-generated />
using System;
using Lunas_mini_aussies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lunas_mini_aussies_.Migrations
{
    [DbContext(typeof(PuppyDbContext))]
    partial class PuppyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("Lunas_mini_aussies.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Lunas_mini_aussies.Models.Puppy", b =>
                {
                    b.Property<int>("PuppyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<double>("Height")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Temp")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.Property<string>("dad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("mom")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("PuppyID");

                    b.HasIndex("ClientID");

                    b.ToTable("Puppies");
                });

            modelBuilder.Entity("Lunas_mini_aussies.Models.Puppy", b =>
                {
                    b.HasOne("Lunas_mini_aussies.Models.Client", "Client")
                        .WithMany("Puppys")
                        .HasForeignKey("ClientID");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Lunas_mini_aussies.Models.Client", b =>
                {
                    b.Navigation("Puppys");
                });
#pragma warning restore 612, 618
        }
    }
}
