﻿// <auto-generated />
using System;
using DTS.DAL.Concrete.EntityFramework;
using EntityFrameworkCore.Jet.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DTS.DAL.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240109190000_initials")]
    partial class initials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Jet:ValueGenerationStrategy", JetValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DTS.Entities.Concrete.Aidatlar", b =>
                {
                    b.Property<int>("AidatlarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Jet:ValueGenerationStrategy", JetValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aidat_Tutari")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<string>("Ay")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("smallint");

                    b.Property<string>("TC_Kimlik")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<string>("Yil")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.HasKey("AidatlarID");

                    b.ToTable("Aidatlars");
                });

            modelBuilder.Entity("DTS.Entities.Concrete.Odemeler", b =>
                {
                    b.Property<int>("OdemelerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Jet:ValueGenerationStrategy", JetValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AidatlarID")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Odeme_Tarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("Odenen_Tutar")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<string>("TC_Kimlik")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.HasKey("OdemelerID");

                    b.ToTable("Odemelers");
                });

            modelBuilder.Entity("DTS.Entities.Concrete.Uyeler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Jet:ValueGenerationStrategy", JetValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<int>("AidatlarID")
                        .HasColumnType("integer");

                    b.Property<bool>("Aktif")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Dogum_Tarihi")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("smallint");

                    b.Property<string>("Kan_Grubu")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<int>("OdemelerID")
                        .HasColumnType("integer");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.Property<string>("TC_Kimlik")
                        .IsRequired()
                        .HasColumnType("longchar");

                    b.HasKey("Id");

                    b.HasIndex("AidatlarID");

                    b.HasIndex("OdemelerID");

                    b.ToTable("Uyelers");
                });

            modelBuilder.Entity("DTS.Entities.Concrete.Uyeler", b =>
                {
                    b.HasOne("DTS.Entities.Concrete.Aidatlar", "Aidatlar")
                        .WithMany("Uyelers")
                        .HasForeignKey("AidatlarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTS.Entities.Concrete.Odemeler", "Odemeler")
                        .WithMany("Uyelers")
                        .HasForeignKey("OdemelerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
