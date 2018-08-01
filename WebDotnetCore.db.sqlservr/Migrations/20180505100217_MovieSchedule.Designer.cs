﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebDotnetCore.db.sqlservr.yz.Models;

namespace WebDotnetCore.db.sqlservr.Migrations
{
    [DbContext(typeof(YzDbContext))]
    [Migration("20180505100217_MovieSchedule")]
    partial class MovieSchedule
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebDotnetCore.db.sqlservr.yz.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<double>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int>("Score");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("WebDotnetCore.db.sqlservr.yz.Models.MovieSchedule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MovieID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("UploadDT");

                    b.Property<string>("UploadImage")
                        .HasMaxLength(200);

                    b.Property<string>("UploadSchedule")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.HasKey("ID");

                    b.ToTable("MovieSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
