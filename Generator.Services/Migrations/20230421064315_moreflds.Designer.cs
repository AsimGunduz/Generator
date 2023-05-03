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
    [Migration("20230421064315_moreflds")]
    partial class moreflds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Generator.Examples.Shared.ORDERS_D", b =>
                {
                    b.Property<int>("OD_ROWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OD_ROWID"));

                    b.Property<int>("OD_M_REFNO")
                        .HasColumnType("int");

                    b.Property<string>("OD_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OD_PRICE")
                        .HasPrecision(19, 2)
                        .HasColumnType("decimal(19,2)");

                    b.Property<int>("OD_QUANTITY")
                        .HasColumnType("int");

                    b.HasKey("OD_ROWID");

                    b.HasIndex("OD_M_REFNO");

                    b.ToTable("ORDERS_D");
                });

            modelBuilder.Entity("Generator.Examples.Shared.ORDERS_M", b =>
                {
                    b.Property<int>("OM_ROWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OM_ROWID"));

                    b.Property<string>("OM_DESCRIPTION")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OM_MORE_FIELD_EIGHT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OM_MORE_FIELD_FIVE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OM_MORE_FIELD_FOUR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OM_MORE_FIELD_ONE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OM_MORE_FIELD_SEVEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OM_MORE_FIELD_SIX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OM_MORE_FIELD_THREE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OM_MORE_FIELD_TWO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OM_USER_REFNO")
                        .HasColumnType("int");

                    b.HasKey("OM_ROWID");

                    b.HasIndex("OM_USER_REFNO");

                    b.ToTable("ORDERS_M");
                });

            modelBuilder.Entity("Generator.Examples.Shared.USER", b =>
                {
                    b.Property<int>("U_ROWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("U_ROWID"));

                    b.Property<int>("U_AGE")
                        .HasColumnType("int");

                    b.Property<bool>("U_IS_MARRIED")
                        .HasColumnType("bit");

                    b.Property<string>("U_LASTNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("U_REGISTER_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("U_ROWID");

                    b.ToTable("USER");
                });

            modelBuilder.Entity("Generator.Shared.TEST_WILL_DELETE_LATER.CHILD_CLASS", b =>
                {
                    b.Property<int>("CC_ROWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CC_ROWID"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PC_ROWID"));

                    b.Property<string>("PC_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PC_STRING_TABLE_CODE")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PC_ROWID");

                    b.HasIndex("PC_STRING_TABLE_CODE");

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TT_ROWID"));

                    b.Property<bool>("TT_BOOLEAN")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TT_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("TT_DEFAULT_VALUE_STRING")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TT_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TT_NULLABLE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("TT_STRING_TABLE_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TT_ROWID");

                    b.ToTable("TEST_TABLE");
                });

            modelBuilder.Entity("Generator.Examples.Shared.ORDERS_D", b =>
                {
                    b.HasOne("Generator.Examples.Shared.ORDERS_M", null)
                        .WithMany("ORDERS_D")
                        .HasForeignKey("OD_M_REFNO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Generator.Examples.Shared.ORDERS_M", b =>
                {
                    b.HasOne("Generator.Examples.Shared.USER", null)
                        .WithMany("ORDERS_M")
                        .HasForeignKey("OM_USER_REFNO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Generator.Shared.TEST_WILL_DELETE_LATER.STRING_TABLE", "STRING_TABLE")
                        .WithMany()
                        .HasForeignKey("PC_STRING_TABLE_CODE");

                    b.Navigation("STRING_TABLE");
                });

            modelBuilder.Entity("Generator.Examples.Shared.ORDERS_M", b =>
                {
                    b.Navigation("ORDERS_D");
                });

            modelBuilder.Entity("Generator.Examples.Shared.USER", b =>
                {
                    b.Navigation("ORDERS_M");
                });

            modelBuilder.Entity("Generator.Shared.TEST_WILL_DELETE_LATER.PARENT_CLASS", b =>
                {
                    b.Navigation("CHILD_CLASS");
                });
#pragma warning restore 612, 618
        }
    }
}
