﻿// <auto-generated />
using System;
using EasyProfiler.SQLServer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyProfiler.SQLServer.Migrations
{
    [DbContext(typeof(ProfilerDbContext))]
    [Migration("20201125200702_AddQueryType")]
    partial class AddQueryType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyProfiler.Core.Entities.Profiler", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Duration")
                        .HasColumnType("bigint");

                    b.Property<string>("Query")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Duration");

                    b.ToTable("Profilers");
                });
#pragma warning restore 612, 618
        }
    }
}
