﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission_11_Bangerter.Models;

#nullable disable

namespace Mission_11_Bangerter.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20240320225422_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Mission_11_Bangerter.Models.Book", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ProjectINstallation")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectImpact")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectID");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
