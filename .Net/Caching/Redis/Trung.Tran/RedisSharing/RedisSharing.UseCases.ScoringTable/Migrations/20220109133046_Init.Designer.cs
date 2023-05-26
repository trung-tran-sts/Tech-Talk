﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedisSharing.UseCases.ScoringTable.SqlServerStore;

#nullable disable

namespace RedisSharing.UseCases.ScoringTable.Migrations
{
    [DbContext(typeof(ScoringContext))]
    [Migration("20220109133046_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RedisSharing.UseCases.ScoringTable.Models.PlayerRankRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("RecordedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"), false);

                    b.HasIndex("RecordedTime");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("RecordedTime"), false);

                    b.HasIndex("Score");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("Score"));

                    b.ToTable("PlayerRankRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
