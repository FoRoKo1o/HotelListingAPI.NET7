﻿// <auto-generated />
using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListingAPI.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    [Migration("20230617164328_SeededCountriesAndHotels")]
    partial class SeededCountriesAndHotels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelListingAPI.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Poland",
                            ShortName = "PL"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Germany",
                            ShortName = "DE"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Slovakia",
                            ShortName = "SK"
                        });
                });

            modelBuilder.Entity("HotelListingAPI.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Warszawa",
                            CountryId = 1,
                            Name = "Novotel",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Address = "Berlin",
                            CountryId = 2,
                            Name = "Riu Plaza",
                            Rating = 4.7000000000000002
                        },
                        new
                        {
                            Id = 3,
                            Address = "bratislava",
                            CountryId = 3,
                            Name = "Apollo Hotel",
                            Rating = 4.5999999999999996
                        });
                });

            modelBuilder.Entity("HotelListingAPI.Data.Hotel", b =>
                {
                    b.HasOne("HotelListingAPI.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelListingAPI.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
