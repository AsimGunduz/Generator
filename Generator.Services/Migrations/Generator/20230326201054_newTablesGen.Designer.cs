﻿// <auto-generated />
using Generator.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Generator.Services.Migrations.Generator
{
    [DbContext(typeof(GeneratorContext))]
    [Migration("20230326201054_newTablesGen")]
    partial class newTablesGen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Generator.Shared.Models.ComponentModels.COMPONENT_BASE", b =>
                {
                    b.Property<int>("CB_ROWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CB_ROWID"), 1L, 1);

                    b.Property<string>("CB_COMPONENT_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CB_ROWID");

                    b.ToTable("COMPONENT_BASE");
                });

            modelBuilder.Entity("Generator.Shared.Models.ComponentModels.PERMISSIONS", b =>
                {
                    b.Property<int>("PER_ROWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PER_ROWID"), 1L, 1);

                    b.Property<string>("PER_AUTH_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PER_COMP_REFNO")
                        .HasColumnType("int");

                    b.Property<string>("PER_COMP_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PER_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PER_ROWID");

                    b.HasIndex("PER_COMP_REFNO");

                    b.ToTable("PERMISSIONS");
                });

            modelBuilder.Entity("Generator.Shared.Models.ComponentModels.PAGES_M", b =>
                {
                    b.HasBaseType("Generator.Shared.Models.ComponentModels.COMPONENT_BASE");

                    b.Property<bool>("PB_CREATE")
                        .HasColumnType("bit");

                    b.Property<bool>("PB_DELETE")
                        .HasColumnType("bit");

                    b.Property<string>("PB_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PB_READ")
                        .HasColumnType("bit");

                    b.Property<bool>("PB_UPDATE")
                        .HasColumnType("bit");

                    b.ToTable("PAGES_M");
                });

            modelBuilder.Entity("Generator.Shared.Models.ComponentModels.PAGES_D", b =>
                {
                    b.HasBaseType("Generator.Shared.Models.ComponentModels.PAGES_M");

                    b.Property<int>("PD_M_REFNO")
                        .HasColumnType("int");

                    b.ToTable("PAGES_D");
                });

            modelBuilder.Entity("Generator.Shared.Models.ComponentModels.PERMISSIONS", b =>
                {
                    b.HasOne("Generator.Shared.Models.ComponentModels.COMPONENT_BASE", null)
                        .WithMany("PERMISSIONS")
                        .HasForeignKey("PER_COMP_REFNO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Generator.Shared.Models.ComponentModels.PAGES_M", b =>
                {
                    b.HasOne("Generator.Shared.Models.ComponentModels.COMPONENT_BASE", null)
                        .WithOne()
                        .HasForeignKey("Generator.Shared.Models.ComponentModels.PAGES_M", "CB_ROWID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Generator.Shared.Models.ComponentModels.PAGES_D", b =>
                {
                    b.HasOne("Generator.Shared.Models.ComponentModels.PAGES_M", null)
                        .WithOne()
                        .HasForeignKey("Generator.Shared.Models.ComponentModels.PAGES_D", "CB_ROWID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Generator.Shared.Models.ComponentModels.COMPONENT_BASE", b =>
                {
                    b.Navigation("PERMISSIONS");
                });
#pragma warning restore 612, 618
        }
    }
}
