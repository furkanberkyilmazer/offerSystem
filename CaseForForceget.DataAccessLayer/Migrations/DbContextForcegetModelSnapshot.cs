﻿// <auto-generated />
using CaseForForceget.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaseForForceget.DataAccessLayer.Migrations
{
    [DbContext(typeof(DbContextForceget))]
    partial class DbContextForcegetModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CaseForForceget.EntityLayer.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountriesCities")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Incoterms")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MovementType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PackageType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Unit1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Unit2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
