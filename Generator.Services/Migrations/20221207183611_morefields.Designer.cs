﻿// <auto-generated />
using System;
using Generator.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Generator.Services.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20221207183611_morefields")]
    partial class morefields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Generator.Shared.TEST_WILL_DELETE_LATER.CHILD_CLASS", b =>
                {
                    b.Property<int>("CC_ROWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CC_ROWID"), 1L, 1);

                    b.Property<string>("CC_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CC_PARENT_REFNO")
                        .HasColumnType("int");

                    b.HasKey("CC_ROWID");

                    b.HasIndex("CC_PARENT_REFNO");

                    b.ToTable("CHILD_CLASS");
                });

            modelBuilder.Entity("Generator.Shared.TEST_WILL_DELETE_LATER.COMPUTED_TABLE", b =>
                {
                    b.Property<int>("CT_ROWID")
                        .HasColumnType("int");

                    b.Property<string>("CT_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CT_ROWID");

                    b.ToTable("COMPUTED_TABLE");
                });

            modelBuilder.Entity("Generator.Shared.TEST_WILL_DELETE_LATER.PARENT_CLASS", b =>
                {
                    b.Property<int>("PC_ROWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PC_ROWID"), 1L, 1);

                    b.Property<string>("PC_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PC_ROWID");

                    b.ToTable("PARENT_CLASS");
                });

            modelBuilder.Entity("Generator.Shared.TEST_WILL_DELETE_LATER.STRING_TABLE", b =>
                {
                    b.Property<string>("CT_ROWID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CT_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CT_ROWID");

                    b.ToTable("STRING_TABLE");
                });

            modelBuilder.Entity("Generator.Shared.TEST_WILL_DELETE_LATER.TEST_TABLE", b =>
                {
                    b.Property<int>("TT_ROWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TT_ROWID"), 1L, 1);

                    b.Property<bool>("TT_BOOLEAN")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TT_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("TT_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TT_NULLABLE_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("TT_ROWID");

                    b.ToTable("TEST_TABLE");
                });

            modelBuilder.Entity("Generator.Shared.TEST_WILL_DELETE_LATER.CHILD_CLASS", b =>
                {
                    b.HasOne("Generator.Shared.TEST_WILL_DELETE_LATER.PARENT_CLASS", null)
                        .WithMany("CHILD_CLASS")
                        .HasForeignKey("CC_PARENT_REFNO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Generator.Shared.TEST_WILL_DELETE_LATER.PARENT_CLASS", b =>
                {
                    b.Navigation("CHILD_CLASS");
                });
#pragma warning restore 612, 618
        }
    }
}
