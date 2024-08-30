﻿// <auto-generated />
using System;
using CodeBase.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ESTDesktop.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(CodebBaseDbContext))]
    [Migration("20240830095559_init-Db_v2")]
    partial class initDb_v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("CodeBase.Core.Entities.ExampleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExampleEntities");
                });

            modelBuilder.Entity("ESTDesktop.Core.Entities.TaskDomain.TaskToWork", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BranchInGit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TaskCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TaskToWorks");
                });

            modelBuilder.Entity("ESTDesktop.Core.Entities.TaskDomain.TodoInTask", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("ActualTime")
                        .HasColumnType("REAL");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("EstTime")
                        .HasColumnType("REAL");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<float>("MaxTime")
                        .HasColumnType("REAL");

                    b.Property<float>("MinTime")
                        .HasColumnType("REAL");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<float>("OpTime")
                        .HasColumnType("REAL");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TodoInTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
