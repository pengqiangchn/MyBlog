﻿// <auto-generated />
using System;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(UnitOfWorkDbContext))]
    [Migration("20200203122119_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Modules.BlogInfoAgg.BlogInfo", b =>
                {
                    b.Property<string>("BlogId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("BlogName")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(32)");

                    b.HasKey("BlogId");

                    b.ToTable("BlogInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
