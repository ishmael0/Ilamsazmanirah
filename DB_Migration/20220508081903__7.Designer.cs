﻿// <auto-generated />
using System;
using BackHost.DBs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackHost.DB_Migration
{
    [DbContext(typeof(DB))]
    [Migration("20220508081903__7")]
    partial class _7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BackHost.DBs.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BackHost.DBs.Organization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("BackHost.DBs.SellMethod", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("SellMethods");
                });

            modelBuilder.Entity("BackHost.DBs.Vahed", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArzesheKarshenasi")
                        .HasColumnType("int");

                    b.Property<long?>("CityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DastgaheMoarrefiKonnande")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ejare98")
                        .HasColumnType("int");

                    b.Property<int>("Ejare99")
                        .HasColumnType("int");

                    b.Property<string>("EjareName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElamBeDarayi")
                        .HasColumnType("int");

                    b.Property<string>("Estelam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyBahreBardar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gharardad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GharardadEjare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GharardadModdat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GharardadShomare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GharardadTarikh")
                        .HasColumnType("datetime2");

                    b.Property<string>("HeyatNamayandegi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Karshenasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Korooki")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MablaghNamayandegi")
                        .HasColumnType("int");

                    b.Property<string>("MadrakFeli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadrakGhabli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("NahveForoosh")
                        .HasColumnType("bigint");

                    b.Property<string>("NameBahreBardar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sanad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SayerMostanadat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SematBahreBardar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShomareNamayandegi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShomareVagozari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShomareVahed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("TarikhNamayandegi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TarikhVagozari")
                        .HasColumnType("datetime2");

                    b.Property<int>("VaziateForoosh")
                        .HasColumnType("int");

                    b.Property<int>("VaziateSanad")
                        .HasColumnType("int");

                    b.Property<int>("VaziateVahed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DastgaheMoarrefiKonnande");

                    b.HasIndex("NahveForoosh");

                    b.ToTable("Vaheds");
                });

            modelBuilder.Entity("Core.Models.FilesEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileEntityDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileType")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FilesEntities");
                });

            modelBuilder.Entity("Core.Models.LogEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.Property<long>("EntityId")
                        .HasColumnType("bigint");

                    b.Property<int>("EntityState")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LogEntities");
                });

            modelBuilder.Entity("Core.Models.SocialMedia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("Core.Models.ToDo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<int>("TaskStatus")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("BackHost.DBs.Vahed", b =>
                {
                    b.HasOne("BackHost.DBs.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("BackHost.DBs.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("DastgaheMoarrefiKonnande");

                    b.HasOne("BackHost.DBs.SellMethod", "SellMethod")
                        .WithMany()
                        .HasForeignKey("NahveForoosh");

                    b.Navigation("City");

                    b.Navigation("Organization");

                    b.Navigation("SellMethod");
                });
#pragma warning restore 612, 618
        }
    }
}
